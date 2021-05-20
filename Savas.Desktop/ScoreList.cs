using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas.Desktop
{
    public partial class ScoreList : Form
    {
        public ScoreList()
        {
            InitializeComponent();
            string fileLocation = @"score.txt";
            if (!File.Exists(fileLocation))
            {
                scoresLabel.Text = "You are expected to play the game to view the scoreboard.";
            }
            else
            {
                string allScores = File.ReadAllText(fileLocation, Encoding.UTF8);
                scoresLabel.Text = allScores;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Image.FromFile(@"Images\close_hover.png");
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Image.FromFile(@"Images\close.png");
        }
    }
}
