using System;

namespace Light
{
    public class FloorLamp : ILightingDevice
    {
        public bool IsOn { get; set; }
        public bool IsBroken { get; set; }
        public double BreakProbability { get; set; }
        public bool IsConnectedToNetwork { get; set; }

        public FloorLamp() { }

        public FloorLamp(
            bool isOn,
            double breakProbability,
            bool isBroken,
            bool isConnectedToNetwork
        ) 
        {
            IsOn = isOn;
            IsBroken = isBroken;
            BreakProbability = breakProbability;
            this.IsConnectedToNetwork = isConnectedToNetwork;
        }
        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            if (IsBroken || !IsConnectedToNetwork)
                return;
            Random rnd = new Random();
            int randNum = rnd.Next(100);
            Console.WriteLine(randNum);
            if (randNum < BreakProbability * 100)
                Break();
            else
                IsOn = true;
        }

        public void ConnectToNetwork()
        {
            this.IsConnectedToNetwork = true;
        }

        public void DisconnectFromNetwork()
        {
            this.IsConnectedToNetwork = false;
            this.IsOn = false;
        }

        public void Break()
        {
            this.IsOn = false;
            this.IsBroken = true;
        }
    }
}
