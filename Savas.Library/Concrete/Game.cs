using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Savas.Library.Concrete
{
    public class Game : IGame
    {
        #region Alanlar
        private readonly Timer _elapsedTimeTimer = new Timer { Interval = 1000 };
        private readonly Timer _moveTimer = new Timer { Interval = 25 };
        private TimeSpan _elapsedTime;
        private readonly Panel _antiaircraftPanel;
        private Antiaircraft _antiaircraft;
        private readonly Panel _warareaPanel;
        private readonly List<Bullet> _bullets = new List<Bullet>();
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
        public Game(Panel antiaircraftPanel, Panel warareaPanel)
        {
            _antiaircraftPanel = antiaircraftPanel;
            _warareaPanel = warareaPanel;

            _elapsedTimeTimer.Tick += ElapsedTimeTimer_Tick;
            _moveTimer.Tick += MoveTimer_Tick;
        }

        private void ElapsedTimeTimer_Tick(object sender, EventArgs e)
        {
            ElapsedTime += TimeSpan.FromSeconds(1);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            MoveBullets();
        }

        private void MoveBullets()
        {
            for (int i = _bullets.Count -1; i >= 0; i--)
            {
                var bullet = _bullets[i];
                var didHitToTop = bullet.Move(Direction.Up);
                if (didHitToTop)
                {
                    _bullets.Remove(bullet);
                    _warareaPanel.Controls.Remove(bullet);
                }
            }
        }

        public void Fire()
        {
            if (!DoesItContinue) return;
            
            var bullet = new Bullet(_warareaPanel.Size, _antiaircraft.Center);
            _bullets.Add(bullet);
            _warareaPanel.Controls.Add(bullet);
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
            StartTimers();

            Create_AntiAircraft();
        }

        private void StartTimers()
        {
            _elapsedTimeTimer.Start();
            _moveTimer.Start();
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
            FinishTimers();
        }

        private void FinishTimers()
        {
            _elapsedTimeTimer.Stop();
            _moveTimer.Stop();
        }

        #endregion
    }
}
