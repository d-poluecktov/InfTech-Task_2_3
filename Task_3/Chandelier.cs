using System;

namespace Light
{
    public class Chandelier : ILightingDevice
    {
        public bool IsOn { get; set; }
        public bool IsBroken { get; set; }
        public double BreakProbability { get; set; }
        public int CurrentMode { get; set; }

        public Chandelier() { }

        public Chandelier(
            bool isOn, 
            double breakProbability, 
            bool isBroken,
            int curMode
        ) 
        {
            IsOn = isOn;
            IsBroken = isBroken;
            BreakProbability = breakProbability;
            this.CurrentMode = curMode;
        }
        public void TurnOff()
        {
            CurrentMode = Math.Max(CurrentMode - 1, 0);
            if (CurrentMode == 0)
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
            {
                Break();
                CurrentMode = 0;
            }
            else
            {
                IsOn = true;
                CurrentMode = Math.Min(CurrentMode + 1, 3);
            }
        }

        public void Break()
        {
            this.IsOn = false;
            this.IsBroken = true;
        }
    }
}
