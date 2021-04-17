using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Windows.Forms;

namespace Savas.Library.Concrete
{
    public class Game : IGame
    {
        public bool DoesItContinue { get; private set; }

        public TimeSpan ElapsedTime { get; }

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
            MessageBox.Show("Game started.");
            DoesItContinue = true;  
        }

        private void Finish()
        {
            if (!DoesItContinue) return;
            MessageBox.Show("Game over.");
            DoesItContinue = false;

        }
    }
}
