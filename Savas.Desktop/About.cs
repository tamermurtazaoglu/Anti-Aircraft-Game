using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Savas.Desktop
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void github_Click(object sender, EventArgs e)
        {

            Process.Start("https://github.com/tamermurtazaoglu");
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/mr.tamerm");
        }

        private void linkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/tamermurtazaoglu");
        }

        private void website_Click(object sender, EventArgs e)
        {
            Process.Start("https://tamerm.com");
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
