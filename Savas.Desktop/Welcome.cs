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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        // Form movement start
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // Form movement end

            
        /*
        // Box-shadow for form start
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        // Box-shadow for form end
        */

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(@"Images\button_start_animated.jpg");
        }


        private void startbutton_MouseEnter(object sender, EventArgs e)
        {
            //startbutton.Image = Image.FromFile(@"Images\button_start_animated.gif");
        }

        private void startbutton_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void startbutton_MouseLeave(object sender, EventArgs e)
        {
            startbutton.Image = Image.FromFile(@"Images\button_start.gif");

        }

        private void Welcome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Image.FromFile(@"Images\close_hover.png");
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Image.FromFile(@"Images\close.png");
        }

        private void top5ScoresLabel_Click(object sender, EventArgs e)
        {
            ScoreList scoreListForm = new ScoreList();
            scoreListForm.ShowDialog();
        }
    }
}
