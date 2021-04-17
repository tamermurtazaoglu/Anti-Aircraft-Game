using Savas.Library.Enum;
using System;

namespace Savas.Library.Interface
{
    internal interface IGame
    {
        bool DoesItContinue { get; }
        TimeSpan ElapsedTime { get; }
        void Start();
        void Fire();
        void Move(Direction direction);
    }
}
