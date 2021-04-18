using Savas.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas.Library.Concrete
{
    internal class Bullet : GameObject
    {
        public Bullet(Size movingAreaSizes, int centerOfGunbarrelX) : base(movingAreaSizes)
        {
            Image = Image.FromFile(@"Images\bullet.png");
            SetStartingPosition(centerOfGunbarrelX);
            MovingDistance = (int)(Height * 0.5);
        }

        private void SetStartingPosition(int centerOfGunbarrelX)
        {
            Bottom = MovingAreaSizes.Height;
            Center = centerOfGunbarrelX;
            
        }
    }
}
