using Savas.Library.Concrete;
using Savas.Library.Enum;
using System;
using System.Windows.Forms;

namespace Savas.Desktop
{
    public partial class MainForm : Form
    {

        public int Difficulty { get; set; }

        private Game _game;

        private int maximumLevel = 3;

        public MainForm()
        {
            InitializeComponent();
            _game = new Game(antiaircraftPanel,warAreaPanel,infoPanel,"1");
            _game.ElapsedTimeChanged += Game_ElapsedTimeChanged;
            Difficulty = 1;
        }

        #region Customized design and flexibility

        // Form movement start
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // Form movement end

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

        #endregion

        private void infoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if(!_game.DoesItContinue)
                    {
                        Game newGame = new Game(antiaircraftPanel, warAreaPanel, infoPanel, "1");
                        _game = newGame;
                        _game.ElapsedTimeChanged += Game_ElapsedTimeChanged;
                        Difficulty = 1;
                    }
                    _game.Start();
                    break;
                case Keys.P:
                    _game.PauseOrContinue();
                    break;
                case Keys.Right:
                    if(_game.IsPaused == true) return;
                    _game.MoveAntiaircraft(Direction.Right);
                    break;
                case Keys.Left:
                    if (_game.IsPaused == true) return;
                    _game.MoveAntiaircraft(Direction.Left);
                    break;
                case Keys.Space:
                    if (_game.IsPaused == true) return;
                    _game.Fire();
                    break;


            }
        }

        int tempTime = 0;
        int _time = 0;
        private void Game_ElapsedTimeChanged(object sender, EventArgs e)
        {
            timeLabel.Text = _game.ElapsedTime.ToString(@"m\:ss");

            tempTime += 1;
            if (tempTime - _time == 30)
            {
                if (Difficulty > maximumLevel) return;
                Difficulty += 1;
                _game.SetDifficulty(Difficulty);
                _time = _time + 30;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
