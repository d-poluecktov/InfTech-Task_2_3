using System;

namespace Light
{
    public abstract class LightingDevice
    {
        public bool IsOn { get; set; }
        public double BreakProbability { get; set; }
        public bool IsBroken { get; set; }
        public event EventHandler Broken;

        public LightingDevice(bool isOn, double breakProbability, bool isBroken)
        {
            this.IsOn = isOn;
            this.BreakProbability = breakProbability;
            this.IsBroken = isBroken;
        }

        public abstract void TurnOn();

        public abstract void TurnOff();

        protected void Break()
        {
            Broken?.Invoke(this, EventArgs.Empty);
            this.IsOn = false;
            this.IsBroken = true;
        }
    }
}
