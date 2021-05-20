using Savas.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas.Library.Concrete
{
    internal class Aircraft : GameObject
    {
        private static readonly Random Random = new Random();
        public int Level { get; set; }
        public Aircraft(string level, Size movingAreaSizes) : base(movingAreaSizes)
        {
            Image = Image.FromFile($@"Images\Aircraft_Level{level}.gif");
            MovingDistance = (int)Height / 10;
            Left = Random.Next(movingAreaSizes.Width - Width + 1);
        }


        public Bullet BulletThatShotIt(List<Bullet> bullets)
        {
            foreach (var bullet in bullets)
            {
                var didItShot = bullet.Top < Bottom && bullet.Right > Left && bullet.Left < Right;
                if (didItShot) return bullet;
            }
            return null;
        }
    }
}
