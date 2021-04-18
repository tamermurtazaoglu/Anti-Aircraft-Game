using Savas.Library.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas.Library.Interface
{
    interface IMovable
    {
        Size MovingAreaSizes { get; }
        int MovingDistance { get; }

        /// <summary>
        /// Move game object in the desired direction.
        /// </summary>
        /// <param name="direction">Which direction to move</param>
        /// <returns>If game object hit the wall, return true.</returns>
        bool Move(Direction direction);

    }
}
