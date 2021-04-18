using Savas.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas.Library.Concrete
{
    internal class Antiaircraft : GameObject
    {
        public Antiaircraft(int panelWidth, Size movingAreaSizes) : base(movingAreaSizes)
        {
            Image = Image.FromFile(@"Images\antiaircraft.gif");
            Center = panelWidth / 2;
            MovingDistance = Width / 10;
        }
    }
}
