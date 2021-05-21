
namespace Savas.Desktop
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.scoresLabel = new System.Windows.Forms.Label();
            this.top5ScoresLabel = new System.Windows.Forms.Label();
            this.github = new System.Windows.Forms.PictureBox();
            this.instagram = new System.Windows.Forms.PictureBox();
            this.linkedin = new System.Windows.Forms.PictureBox();
            this.website = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.website)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = global::Savas.Desktop.Properties.Resources.close;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(188, 19);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 29);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 9;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // scoresLabel
            // 
            this.scoresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoresLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoresLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoresLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scoresLabel.Location = new System.Drawing.Point(12, 91);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(376, 45);
            this.scoresLabel.TabIndex = 7;
            this.scoresLabel.Text = "This game developed by Tamer M.";
            this.scoresLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // top5ScoresLabel
            // 
            this.top5ScoresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top5ScoresLabel.BackColor = System.Drawing.Color.Transparent;
            this.top5ScoresLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.top5ScoresLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.top5ScoresLabel.Location = new System.Drawing.Point(112, 56);
            this.top5ScoresLabel.Name = "top5ScoresLabel";
            this.top5ScoresLabel.Size = new System.Drawing.Size(176, 25);
            this.top5ScoresLabel.TabIndex = 8;
            this.top5ScoresLabel.Text = "About Game";
            this.top5ScoresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // github
            // 
            this.github.BackColor = System.Drawing.Color.Transparent;
            this.github.Image = ((System.Drawing.Image)(resources.GetObject("github.Image")));
            this.github.Location = new System.Drawing.Point(38, 128);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(100, 100);
            this.github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.github.TabIndex = 10;
            this.github.TabStop = false;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // instagram
            // 
            this.instagram.BackColor = System.Drawing.Color.Transparent;
            this.instagram.Image = ((System.Drawing.Image)(resources.GetObject("instagram.Image")));
            this.instagram.Location = new System.Drawing.Point(144, 128);
            this.instagram.Name = "instagram";
            this.instagram.Size = new System.Drawing.Size(100, 100);
            this.instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.instagram.TabIndex = 10;
            this.instagram.TabStop = false;
            this.instagram.Click += new System.EventHandler(this.instagram_Click);
            // 
            // linkedin
            // 
            this.linkedin.BackColor = System.Drawing.Color.Transparent;
            this.linkedin.Image = ((System.Drawing.Image)(resources.GetObject("linkedin.Image")));
            this.linkedin.Location = new System.Drawing.Point(250, 128);
            this.linkedin.Name = "linkedin";
            this.linkedin.Size = new System.Drawing.Size(100, 100);
            this.linkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.linkedin.TabIndex = 10;
            this.linkedin.TabStop = false;
            this.linkedin.Click += new System.EventHandler(this.linkedin_Click);
            // 
            // website
            // 
            this.website.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.website.BackColor = System.Drawing.Color.White;
            this.website.Image = ((System.Drawing.Image)(resources.GetObject("website.Image")));
            this.website.Location = new System.Drawing.Point(12, 244);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(376, 68);
            this.website.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.website.TabIndex = 11;
            this.website.TabStop = false;
            this.website.Click += new System.EventHandler(this.website_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Savas.Desktop.Properties.Resources.mainformBack2_1000x700;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 333);
            this.Controls.Add(this.website);
            this.Controls.Add(this.linkedin);
            this.Controls.Add(this.instagram);
            this.Controls.Add(this.github);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.scoresLabel);
            this.Controls.Add(this.top5ScoresLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.website)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label scoresLabel;
        private System.Windows.Forms.Label top5ScoresLabel;
        private System.Windows.Forms.PictureBox github;
        private System.Windows.Forms.PictureBox instagram;
        private System.Windows.Forms.PictureBox linkedin;
        private System.Windows.Forms.PictureBox website;
    }
}