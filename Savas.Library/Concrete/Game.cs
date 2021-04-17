using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Windows.Forms;

namespace Savas.Library.Concrete
{
    public class Game : IGame
    {
        #region Alanlar
        private readonly Timer _elapsedTimeTimer = new Timer { Interval = 1000 };
        private TimeSpan _elapsedTime;
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
        public Game()
        {
            _elapsedTimeTimer.Tick += ElapsedTimeTimer_Tick;
        }

        private void ElapsedTimeTimer_Tick(object sender, EventArgs e)
        {
            ElapsedTime += TimeSpan.FromSeconds(1);
        }

        public void Fire()
        {
            throw new NotImplementedException();
        }

        public void Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            if (DoesItContinue) return;
            DoesItContinue = true;
            _elapsedTimeTimer.Start();
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
