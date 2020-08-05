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
            this.uxCurrentFlag = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxFlagTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxCurrentFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLog
            // 
            this.uxLog.Location = new System.Drawing.Point(12, 550);
            this.uxLog.Multiline = true;
            this.uxLog.Name = "uxLog";
            this.uxLog.ReadOnly = true;
            this.uxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxLog.Size = new System.Drawing.Size(1131, 349);
            this.uxLog.TabIndex = 0;
            // 
            // uxLogLabel
            // 
            this.uxLogLabel.AutoSize = true;
            this.uxLogLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxLogLabel.Location = new System.Drawing.Point(12, 532);
            this.uxLogLabel.Name = "uxLogLabel";
            this.uxLogLabel.Size = new System.Drawing.Size(72, 15);
            this.uxLogLabel.TabIndex = 1;
            this.uxLogLabel.Text = "[DATA LOG]";
            // 
            // uxCurrentFlag
            // 
            this.uxCurrentFlag.Location = new System.Drawing.Point(343, 27);
            this.uxCurrentFlag.Name = "uxCurrentFlag";
            this.uxCurrentFlag.Size = new System.Drawing.Size(800, 500);
            this.uxCurrentFlag.TabIndex = 2;
            this.uxCurrentFlag.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "[CURRENT FLAG]";
            // 
            // uxFlagTypeLabel
            // 
            this.uxFlagTypeLabel.BackColor = System.Drawing.Color.Black;
            this.uxFlagTypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxFlagTypeLabel.ForeColor = System.Drawing.Color.White;
            this.uxFlagTypeLabel.Location = new System.Drawing.Point(360, 455);
            this.uxFlagTypeLabel.Name = "uxFlagTypeLabel";
            this.uxFlagTypeLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.uxFlagTypeLabel.Size = new System.Drawing.Size(768, 54);
            this.uxFlagTypeLabel.TabIndex = 3;
            this.uxFlagTypeLabel.Text = "FLAG TYPE";
            this.uxFlagTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 911);
            this.Controls.Add(this.uxFlagTypeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxCurrentFlag);
            this.Controls.Add(this.uxLogLabel);
            this.Controls.Add(this.uxLog);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACC Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.uxCurrentFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxLog;
        private System.Windows.Forms.Label uxLogLabel;
        private System.Windows.Forms.PictureBox uxCurrentFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxFlagTypeLabel;
    }
}

