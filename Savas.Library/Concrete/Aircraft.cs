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
        public Aircraft(Size movingAreaSizes) : base(movingAreaSizes)
        {
            Image = Image.FromFile(@"Images\Aircraft.gif");
            Left = Random.Next(movingAreaSizes.Width - Width + 1);
        }
    }
}
