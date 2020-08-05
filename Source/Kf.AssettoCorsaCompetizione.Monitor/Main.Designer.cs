namespace Kf.AssettoCorsaCompetizione.Monitor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxLog = new System.Windows.Forms.TextBox();
            this.uxLogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxLog
            // 
            this.uxLog.Location = new System.Drawing.Point(12, 599);
            this.uxLog.Multiline = true;
            this.uxLog.Name = "uxLog";
            this.uxLog.ReadOnly = true;
            this.uxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxLog.Size = new System.Drawing.Size(1131, 300);
            this.uxLog.TabIndex = 0;
            // 
            // uxLogLabel
            // 
            this.uxLogLabel.AutoSize = true;
            this.uxLogLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxLogLabel.Location = new System.Drawing.Point(12, 581);
            this.uxLogLabel.Name = "uxLogLabel";
            this.uxLogLabel.Size = new System.Drawing.Size(72, 15);
            this.uxLogLabel.TabIndex = 1;
            this.uxLogLabel.Text = "[DATA LOG]";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 911);
            this.Controls.Add(this.uxLogLabel);
            this.Controls.Add(this.uxLog);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACC Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxLog;
        private System.Windows.Forms.Label uxLogLabel;
    }
}

