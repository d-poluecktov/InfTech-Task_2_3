using System;

namespace Light
{
    public class Flashlight : ILightingDevice
    {
        public bool IsOn { get; set; }
        public bool IsBroken { get; set; }
        public double BreakProbability { get; set; }
        public Flashlight() { }
        public Flashlight(
            bool isOn, double breakProbability, bool isBroken
            ) 
        {
            IsOn = isOn;
            IsBroken = isBroken;
            BreakProbability = breakProbability;
        }
        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            if (IsBroken)
                return;
            Random rnd = new Random();
            int randNum = rnd.Next(100);
            Console.WriteLine(randNum);
            if (randNum < BreakProbability * 100)
                Break();
            else
                IsOn = true;
        }

        public void Break()
        {
            this.IsOn = false;
            this.IsBroken = true;
        }
    }
}
