
namespace Savas.Desktop
{
    partial class ScoreList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreList));
            this.top5ScoresLabel = new System.Windows.Forms.Label();
            this.scoresLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // top5ScoresLabel
            // 
            this.top5ScoresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top5ScoresLabel.BackColor = System.Drawing.Color.Transparent;
            this.top5ScoresLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.top5ScoresLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.top5ScoresLabel.Location = new System.Drawing.Point(12, 60);
            this.top5ScoresLabel.Name = "top5ScoresLabel";
            this.top5ScoresLabel.Size = new System.Drawing.Size(176, 25);
            this.top5ScoresLabel.TabIndex = 5;
            this.top5ScoresLabel.Text = "Top 5 Scores";
            this.top5ScoresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoresLabel
            // 
            this.scoresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoresLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoresLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoresLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scoresLabel.Location = new System.Drawing.Point(12, 95);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(176, 116);
            this.scoresLabel.TabIndex = 5;
            this.scoresLabel.Text = "scores";
            this.scoresLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = global::Savas.Desktop.Properties.Resources.close;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(88, 23);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 29);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 6;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // ScoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Savas.Desktop.Properties.Resources.mainformBack2_1000x700;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(200, 220);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.scoresLabel);
            this.Controls.Add(this.top5ScoresLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScoreList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "v";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label top5ScoresLabel;
        private System.Windows.Forms.Label scoresLabel;
        private System.Windows.Forms.PictureBox closeButton;
    }
}