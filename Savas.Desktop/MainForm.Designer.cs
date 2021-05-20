
namespace Savas.Desktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.healthLabel = new System.Windows.Forms.Label();
            this.healthTextLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreTextLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.antiaircraftPanel = new System.Windows.Forms.Panel();
            this.warAreaPanel = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.infoPanel.Controls.Add(this.healthLabel);
            this.infoPanel.Controls.Add(this.healthTextLabel);
            this.infoPanel.Controls.Add(this.scoreLabel);
            this.infoPanel.Controls.Add(this.scoreTextLabel);
            this.infoPanel.Controls.Add(this.timeLabel);
            this.infoPanel.Controls.Add(this.infoLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(800, 94);
            this.infoPanel.TabIndex = 0;
            this.infoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.infoPanel_MouseDown);
            // 
            // healthLabel
            // 
            this.healthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.healthLabel.Font = new System.Drawing.Font("Phenomena", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(531, 42);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(108, 37);
            this.healthLabel.TabIndex = 0;
            this.healthLabel.Text = "?";
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.healthLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // healthTextLabel
            // 
            this.healthTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.healthTextLabel.Font = new System.Drawing.Font("Phenomena", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthTextLabel.ForeColor = System.Drawing.Color.White;
            this.healthTextLabel.Location = new System.Drawing.Point(528, 10);
            this.healthTextLabel.Name = "healthTextLabel";
            this.healthTextLabel.Size = new System.Drawing.Size(108, 32);
            this.healthTextLabel.TabIndex = 0;
            this.healthTextLabel.Text = "Health";
            this.healthTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.healthTextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.Font = new System.Drawing.Font("Phenomena", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(365, 41);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(145, 37);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreTextLabel
            // 
            this.scoreTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreTextLabel.Font = new System.Drawing.Font("Phenomena", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextLabel.ForeColor = System.Drawing.Color.White;
            this.scoreTextLabel.Location = new System.Drawing.Point(362, 9);
            this.scoreTextLabel.Name = "scoreTextLabel";
            this.scoreTextLabel.Size = new System.Drawing.Size(145, 32);
            this.scoreTextLabel.TabIndex = 0;
            this.scoreTextLabel.Text = "Score";
            this.scoreTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scoreTextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Font = new System.Drawing.Font("Phenomena", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(645, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(143, 69);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "0:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel.Font = new System.Drawing.Font("Phenomena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(23, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(303, 70);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "info";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // antiaircraftPanel
            // 
            this.antiaircraftPanel.BackColor = System.Drawing.Color.LightGray;
            this.antiaircraftPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.antiaircraftPanel.Location = new System.Drawing.Point(0, 411);
            this.antiaircraftPanel.Name = "antiaircraftPanel";
            this.antiaircraftPanel.Size = new System.Drawing.Size(800, 50);
            this.antiaircraftPanel.TabIndex = 1;
            // 
            // warAreaPanel
            // 
            this.warAreaPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.warAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warAreaPanel.Location = new System.Drawing.Point(0, 94);
            this.warAreaPanel.Name = "warAreaPanel";
            this.warAreaPanel.Size = new System.Drawing.Size(800, 317);
            this.warAreaPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.warAreaPanel);
            this.Controls.Add(this.antiaircraftPanel);
            this.Controls.Add(this.infoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Anti - Aircraft Modern";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel antiaircraftPanel;
        private System.Windows.Forms.Panel warAreaPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label scoreTextLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label healthTextLabel;
    }
}