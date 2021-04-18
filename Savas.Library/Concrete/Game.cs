using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Savas.Library.Concrete
{
    public class Game : IGame
    {
        #region Alanlar
        private readonly Timer _elapsedTimeTimer = new Timer { Interval = 1000 };
        private TimeSpan _elapsedTime;
        private readonly Panel _antiaircraftPanel;
        private Antiaircraft _antiaircraft;
        #endregion

        #region Events
        public event EventHandler ElapsedTimeChanged;
        #endregion

        #region Properties

        public bool DoesItContinue { get; private set; }
        public TimeSpan ElapsedTime {
            get => _elapsedTime;
            private set
            {
                _elapsedTime = value;
                ElapsedTimeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Methods
        public Game(Panel antiaircraftPanel)
        {
            _elapsedTimeTimer.Tick += ElapsedTimeTimer_Tick;
            _antiaircraftPanel = antiaircraftPanel;

        }

        private void ElapsedTimeTimer_Tick(object sender, EventArgs e)
        {
            ElapsedTime += TimeSpan.FromSeconds(1);
        }

        public void Fire()
        {
        }

        public void MoveAntiaircraft(Direction direction)
        {
            if (!DoesItContinue) return;
            
            _antiaircraft.Move(direction);
        }

        public void Start()
        {
            if (DoesItContinue) return;
            DoesItContinue = true;
            _elapsedTimeTimer.Start();

            Create_AntiAircraft();
        }

        private void Create_AntiAircraft()
        {
            _antiaircraft = new Antiaircraft(_antiaircraftPanel.Width, _antiaircraftPanel.Size);
            _antiaircraftPanel.Controls.Add(_antiaircraft);
        }

        private void Finish()
        {
            if (!DoesItContinue) return;
            DoesItContinue = false;
            _elapsedTimeTimer.Stop();
        }

        #endregion
    }
}
