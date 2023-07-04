using System;
namespace Firstone
{
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void Move();
        void Stop();
    }
}

