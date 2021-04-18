using Savas.Library.Enum;
using System;

namespace Savas.Library.Interface
{
    internal interface IGame
    {
        event EventHandler ElapsedTimeChanged;
        bool DoesItContinue { get; }
        TimeSpan ElapsedTime { get; }
        void Start();
        void Fire();
        void MoveAntiaircraft(Direction direction);
    }
}
