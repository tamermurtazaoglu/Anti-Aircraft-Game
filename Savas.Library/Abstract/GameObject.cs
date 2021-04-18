using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas.Library.Abstract
{
    internal abstract class GameObject : PictureBox, IMovable
    {
        protected GameObject(Size movingAreaSizes)
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
            MovingAreaSizes = movingAreaSizes;
        }

        public Size MovingAreaSizes { get; }

        public int MovingDistance { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public new bool Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    return MoveUp();
                case Direction.Right:
                    return MoveRight();
                case Direction.Left:
                    return MoveLeft();
                case Direction.Down:
                    return MoveDown();
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }
        
        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }
        private bool MoveDown()
        {
            if (Bottom == MovingAreaSizes.Height) return true;

            var newBottom = Bottom + MovingDistance;
            var overTheBorder = newBottom > MovingAreaSizes.Height;
            Bottom = overTheBorder ? MovingAreaSizes.Height : newBottom;
            return Bottom == MovingAreaSizes.Height;
        }

        private bool MoveLeft()
        {
            if (Left == 0) return true;

            var newLeft = Left - MovingDistance;
            var overTheBorder = newLeft < 0;
            Left = overTheBorder ? 0 : newLeft;

            return Left == 0;
        }

        private bool MoveRight()
        {
            if (Right == MovingAreaSizes.Width) return true;

            var newRight = Right + MovingDistance;
            var overTheBorder = newRight > MovingAreaSizes.Width;
            Right = overTheBorder ? MovingAreaSizes.Width : newRight;
            return Right == MovingAreaSizes.Width;
        }

        private bool MoveUp()
        {
            if (Top == 0) return true;

            var newTop = Top - MovingDistance;
            var overTheBorder = newTop < 0;
            Top = overTheBorder ? 0 : newTop;

            return Top == 0;
        }
    }
}