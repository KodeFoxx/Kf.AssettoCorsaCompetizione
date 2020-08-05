using Kf.AssettoCorsaCompetizione.PageFiles.Graphics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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

            LoadFlagPictures();

            InitializeGraphics();
            InitializeUpdateTimer();
        }

        private Timer _updateTimer;
        private void InitializeUpdateTimer()
        {
            _updateTimer = new Timer { Interval = 100, Enabled = true };
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

            UpdateFlagPicture(_graphicsInfo?.Flag ?? FlagTypes.None);
            UpdateSector(_graphicsInfo?.Sector ?? 0);
        }

        private void UpdateSector(int sectorNumber)
            => uxCurrentSector.Text = sectorNumber.ToString();

        private Dictionary<FlagTypes, Image> _flags;
        private void UpdateFlagPicture(FlagTypes flag)
        {
            uxCurrentFlag.Image = _flags[flag];
            uxFlagTypeLabel.Text = flag.ToString().ToUpper();
        }
        private void LoadFlagPictures()
        {
            string flagPictureDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Images", "Flags");
            var flagPictures = Enum.GetNames(typeof(FlagTypes))
                .Select(flagName =>
                    new
                    {
                        Type = flagName,
                        Image = Image.FromFile(Path.Combine(flagPictureDirectory, $"{flagName.ToLower()}.png"))
                    }
                );

            _flags = flagPictures.ToDictionary(
                keySelector: kvp => (FlagTypes)Enum.Parse(typeof(FlagTypes), kvp.Type),
                elementSelector: kvp => kvp.Image
            );

            UpdateFlagPicture(FlagTypes.None);
        }
    }
}
