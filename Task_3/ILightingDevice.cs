using System;

namespace Light
{
    public interface ILightingDevice
    {
        void TurnOn();
        void TurnOff();

        void Break();
    }
}
