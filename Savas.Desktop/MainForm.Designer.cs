
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.antiaircraftPanel = new System.Windows.Forms.Panel();
            this.warArea = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.infoPanel.Controls.Add(this.timeLabel);
            this.infoPanel.Controls.Add(this.infoLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(800, 94);
            this.infoPanel.TabIndex = 0;
            this.infoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.infoPanel_MouseDown);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Font = new System.Drawing.Font("Phenomena", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(611, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(177, 69);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "0:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Phenomena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(23, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(177, 69);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Press \"Enter\" to start game.\r\n< > to move.\r\nPress \"Space\" to fire.";
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
            // warArea
            // 
            this.warArea.BackColor = System.Drawing.Color.Gainsboro;
            this.warArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warArea.Location = new System.Drawing.Point(0, 94);
            this.warArea.Name = "warArea";
            this.warArea.Size = new System.Drawing.Size(800, 317);
            this.warArea.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.warArea);
            this.Controls.Add(this.antiaircraftPanel);
            this.Controls.Add(this.infoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Anti - Aircraft Modern";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel antiaircraftPanel;
        private System.Windows.Forms.Panel warArea;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}