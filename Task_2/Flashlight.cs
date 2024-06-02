using System;

namespace Light
{
    public class Flashlight : LightingDevice
    {
        public Flashlight(
            bool isOn, double breakProbability, bool isBroken
            ) : base(isOn, breakProbability, isBroken)
        {
            
        }
        public override void TurnOff()
        {
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
                Break();
            else
                IsOn = true;
        }
    }
}
