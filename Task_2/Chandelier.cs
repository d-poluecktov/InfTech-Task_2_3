using System;

namespace Light
{
    public class Chandelier : LightingDevice
    {
        public int CurrentMode { get; set; }

        public Chandelier(
            bool isOn, 
            double breakProbability, 
            bool isBroken,
            int curMode
        ) : base(isOn, breakProbability, isBroken)
        {
            this.CurrentMode = curMode;
        }
        public override void TurnOff()
        {
            CurrentMode = Math.Max(CurrentMode - 1, 0);
            if (CurrentMode == 0)
                IsOn = false;
        }

        public override void TurnOn()
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

    }
}
