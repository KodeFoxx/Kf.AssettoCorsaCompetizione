using Kf.AssettoCorsaCompetizione.PageFiles.Graphics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Kf.AssettoCorsaCompetizione.Monitor
{
    public partial class Main : Form
    {
        private Queue<string> _log;
        private int _logHistoryCount = 50;

        public Main()
        {
            InitializeComponent();
            InitializeGraphics();
            InitializeUpdateTimer();
        }

        private Timer _updateTimer;
        private void InitializeUpdateTimer()
        {
            _updateTimer = new Timer { Interval = 2500, Enabled = true };
            _updateTimer.Tick += (s, e) =>
            {
                ReadGraphics();
            };
        }

        private void Log(string message, bool noDate = false)
        {
            if (_log == null)
                _log = new Queue<string>(_logHistoryCount);

            if (_log.Count >= _logHistoryCount)
                _log.Dequeue();

            var dateTime = noDate ? String.Empty : $"[{DateTime.Now.ToString("HH:mm:ss.fff")}] - ";
            _log.Enqueue($"{dateTime}{message}");

            uxLog.Text = String.Join(Environment.NewLine, _log.Reverse().Select(m => m));
        }

        private GraphicsInfoPageFile _graphicsInfo = null;
        private void InitializeGraphics()
        {
            _graphicsInfo = new GraphicsInfoPageFile();
            var result = _graphicsInfo.Connect();

            Log($"Connected to graphics shared memory: '{result.Success}'.");
            if (!result.Success)
            {
                Log($"Failed to connect to graphics shared memory: '{result.ErrorInfo.InnerException.Message}'.");
                _graphicsInfo = null;
            }
        }
        private void ReadGraphics()
        {
            if (_graphicsInfo == null)
                InitializeGraphics();

            if (_graphicsInfo != null)
            {
                _graphicsInfo.RefreshData();
                Log($"==== GRAPHICS INFO PACKETID #:{_graphicsInfo.PacketId} ====", noDate: true);
                Log($"       Session: '{_graphicsInfo.Session}'.");
                Log($"    Game State: '{_graphicsInfo.GameState}'.");
                Log($"      Position: '{_graphicsInfo.Position}/{_graphicsInfo.TotalCars}'.");
                Log($" Tyre Compound: '{_graphicsInfo.TyreCompound}'.");
                Log($"          Flag: '{_graphicsInfo.Flag}'.");
                Log($"==// END GRAPHICS INFO PACKET #{_graphicsInfo.PacketId} //==", noDate: true);
            }
        }
    }
}
