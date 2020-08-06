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
            this.uxFlagTypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxCurrentSector = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uxIsValidLap = new System.Windows.Forms.Label();
            this.uxFlagHistory3 = new System.Windows.Forms.PictureBox();
            this.uxFlagHistory2 = new System.Windows.Forms.PictureBox();
            this.uxFlagHistory1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uxPreviousLap = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uxEstimatedLap = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.uxBestLap = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxCurrentFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFlagHistory3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFlagHistory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFlagHistory1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLog
            // 
            this.uxLog.Location = new System.Drawing.Point(655, 764);
            this.uxLog.Multiline = true;
            this.uxLog.Name = "uxLog";
            this.uxLog.ReadOnly = true;
            this.uxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxLog.Size = new System.Drawing.Size(820, 185);
            this.uxLog.TabIndex = 0;
            // 
            // uxLogLabel
            // 
            this.uxLogLabel.AutoSize = true;
            this.uxLogLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxLogLabel.Location = new System.Drawing.Point(655, 746);
            this.uxLogLabel.Name = "uxLogLabel";
            this.uxLogLabel.Size = new System.Drawing.Size(72, 15);
            this.uxLogLabel.TabIndex = 1;
            this.uxLogLabel.Text = "[DATA LOG]";
            // 
            // uxCurrentFlag
            // 
            this.uxCurrentFlag.Location = new System.Drawing.Point(665, 57);
            this.uxCurrentFlag.Name = "uxCurrentFlag";
            this.uxCurrentFlag.Size = new System.Drawing.Size(800, 500);
            this.uxCurrentFlag.TabIndex = 2;
            this.uxCurrentFlag.TabStop = false;
            // 
            // uxFlagTypeLabel
            // 
            this.uxFlagTypeLabel.BackColor = System.Drawing.Color.Black;
            this.uxFlagTypeLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxFlagTypeLabel.ForeColor = System.Drawing.Color.White;
            this.uxFlagTypeLabel.Location = new System.Drawing.Point(655, 485);
            this.uxFlagTypeLabel.Name = "uxFlagTypeLabel";
            this.uxFlagTypeLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.uxFlagTypeLabel.Size = new System.Drawing.Size(820, 81);
            this.uxFlagTypeLabel.TabIndex = 3;
            this.uxFlagTypeLabel.Text = "FLAG TYPE";
            this.uxFlagTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label2.Size = new System.Drawing.Size(142, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "SECTOR";
            // 
            // uxCurrentSector
            // 
            this.uxCurrentSector.BackColor = System.Drawing.Color.Black;
            this.uxCurrentSector.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxCurrentSector.ForeColor = System.Drawing.Color.White;
            this.uxCurrentSector.Location = new System.Drawing.Point(4, 46);
            this.uxCurrentSector.Margin = new System.Windows.Forms.Padding(0);
            this.uxCurrentSector.Name = "uxCurrentSector";
            this.uxCurrentSector.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.uxCurrentSector.Size = new System.Drawing.Size(150, 150);
            this.uxCurrentSector.TabIndex = 1;
            this.uxCurrentSector.Text = "0";
            this.uxCurrentSector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(8, 34);
            this.label3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(655, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(820, 683);
            this.label4.TabIndex = 1;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(663, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label5.Size = new System.Drawing.Size(220, 34);
            this.label5.TabIndex = 1;
            this.label5.Text = "CURRENT FLAG";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(655, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(8, 34);
            this.label6.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 34);
            this.label1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(166, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label7.Size = new System.Drawing.Size(166, 34);
            this.label7.TabIndex = 1;
            this.label7.Text = "VALID LAP?";
            // 
            // uxIsValidLap
            // 
            this.uxIsValidLap.BackColor = System.Drawing.Color.Black;
            this.uxIsValidLap.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxIsValidLap.ForeColor = System.Drawing.Color.White;
            this.uxIsValidLap.Location = new System.Drawing.Point(158, 46);
            this.uxIsValidLap.Margin = new System.Windows.Forms.Padding(0);
            this.uxIsValidLap.Name = "uxIsValidLap";
            this.uxIsValidLap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.uxIsValidLap.Size = new System.Drawing.Size(174, 150);
            this.uxIsValidLap.TabIndex = 1;
            this.uxIsValidLap.Text = "0";
            this.uxIsValidLap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxFlagHistory3
            // 
            this.uxFlagHistory3.Location = new System.Drawing.Point(1225, 569);
            this.uxFlagHistory3.Name = "uxFlagHistory3";
            this.uxFlagHistory3.Size = new System.Drawing.Size(240, 150);
            this.uxFlagHistory3.TabIndex = 2;
            this.uxFlagHistory3.TabStop = false;
            // 
            // uxFlagHistory2
            // 
            this.uxFlagHistory2.Location = new System.Drawing.Point(949, 569);
            this.uxFlagHistory2.Name = "uxFlagHistory2";
            this.uxFlagHistory2.Size = new System.Drawing.Size(240, 150);
            this.uxFlagHistory2.TabIndex = 2;
            this.uxFlagHistory2.TabStop = false;
            // 
            // uxFlagHistory1
            // 
            this.uxFlagHistory1.Location = new System.Drawing.Point(665, 569);
            this.uxFlagHistory1.Name = "uxFlagHistory1";
            this.uxFlagHistory1.Size = new System.Drawing.Size(240, 150);
            this.uxFlagHistory1.TabIndex = 2;
            this.uxFlagHistory1.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(4, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(8, 34);
            this.label8.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label9.Size = new System.Drawing.Size(421, 34);
            this.label9.TabIndex = 1;
            this.label9.Text = "PREVIOUS LAP";
            // 
            // uxPreviousLap
            // 
            this.uxPreviousLap.BackColor = System.Drawing.Color.Black;
            this.uxPreviousLap.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxPreviousLap.ForeColor = System.Drawing.Color.White;
            this.uxPreviousLap.Location = new System.Drawing.Point(4, 244);
            this.uxPreviousLap.Margin = new System.Windows.Forms.Padding(0);
            this.uxPreviousLap.Name = "uxPreviousLap";
            this.uxPreviousLap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.uxPreviousLap.Size = new System.Drawing.Size(643, 150);
            this.uxPreviousLap.TabIndex = 1;
            this.uxPreviousLap.Text = "0";
            this.uxPreviousLap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(4, 409);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(8, 34);
            this.label10.TabIndex = 1;
            // 
            // uxEstimatedLap
            // 
            this.uxEstimatedLap.BackColor = System.Drawing.Color.Black;
            this.uxEstimatedLap.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxEstimatedLap.ForeColor = System.Drawing.Color.White;
            this.uxEstimatedLap.Location = new System.Drawing.Point(4, 443);
            this.uxEstimatedLap.Margin = new System.Windows.Forms.Padding(0);
            this.uxEstimatedLap.Name = "uxEstimatedLap";
            this.uxEstimatedLap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.uxEstimatedLap.Size = new System.Drawing.Size(643, 150);
            this.uxEstimatedLap.TabIndex = 1;
            this.uxEstimatedLap.Text = "0";
            this.uxEstimatedLap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(12, 406);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label12.Size = new System.Drawing.Size(421, 34);
            this.label12.TabIndex = 1;
            this.label12.Text = "ESTIMATED LAP";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(4, 610);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(8, 34);
            this.label13.TabIndex = 1;
            // 
            // uxBestLap
            // 
            this.uxBestLap.BackColor = System.Drawing.Color.Black;
            this.uxBestLap.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uxBestLap.ForeColor = System.Drawing.Color.White;
            this.uxBestLap.Location = new System.Drawing.Point(4, 644);
            this.uxBestLap.Margin = new System.Windows.Forms.Padding(0);
            this.uxBestLap.Name = "uxBestLap";
            this.uxBestLap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.uxBestLap.Size = new System.Drawing.Size(643, 150);
            this.uxBestLap.TabIndex = 1;
            this.uxBestLap.Text = "0";
            this.uxBestLap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(12, 607);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label15.Size = new System.Drawing.Size(421, 34);
            this.label15.TabIndex = 1;
            this.label15.Text = "BEST LAP";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.uxEstimatedLap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.uxPreviousLap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uxFlagHistory1);
            this.Controls.Add(this.uxFlagHistory2);
            this.Controls.Add(this.uxFlagHistory3);
            this.Controls.Add(this.uxIsValidLap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxFlagTypeLabel);
            this.Controls.Add(this.uxLogLabel);
            this.Controls.Add(this.uxLog);
            this.Controls.Add(this.uxCurrentSector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxCurrentFlag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxBestLap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACC Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.uxCurrentFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFlagHistory3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFlagHistory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxFlagHistory1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxLog;
        private System.Windows.Forms.Label uxLogLabel;
        private System.Windows.Forms.PictureBox uxCurrentFlag;
        private System.Windows.Forms.Label uxFlagTypeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uxCurrentSector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label uxIsValidLap;
        private System.Windows.Forms.PictureBox uxFlagHistory3;
        private System.Windows.Forms.PictureBox uxFlagHistory2;
        private System.Windows.Forms.PictureBox uxFlagHistory1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label uxPreviousLap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label uxEstimatedLap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label uxBestLap;
        private System.Windows.Forms.Label label15;
    }
}

