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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.uxLog = new System.Windows.Forms.TextBox();
            this.uxLogLabel = new System.Windows.Forms.Label();
            this.uxCurrentFlag = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxFlagTypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxCurrentSector = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "| SECTOR";
            // 
            // uxCurrentSector
            // 
            this.uxCurrentSector.BackColor = System.Drawing.Color.Black;
            this.uxCurrentSector.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxCurrentSector.ForeColor = System.Drawing.Color.White;
            this.uxCurrentSector.Location = new System.Drawing.Point(12, 39);
            this.uxCurrentSector.Margin = new System.Windows.Forms.Padding(0);
            this.uxCurrentSector.Name = "uxCurrentSector";
            this.uxCurrentSector.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.uxCurrentSector.Size = new System.Drawing.Size(110, 110);
            this.uxCurrentSector.TabIndex = 1;
            this.uxCurrentSector.Text = "0";
            this.uxCurrentSector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.uxCurrentSector);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uxCurrentSector;
    }
}

