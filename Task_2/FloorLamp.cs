using System;

namespace Light
{
    public class FloorLamp : LightingDevice
    {
        public bool IsConnectedToNetwork { get; set; }

        public FloorLamp(
            bool isOn,
            double breakProbability,
            bool isBroken,
            bool isConnectedToNetwork
        ) : base(isOn, breakProbability, isBroken)
        {
            this.IsConnectedToNetwork = isConnectedToNetwork;
        }
        public override void TurnOff()
        {
            IsOn = false;
        }

        public override void TurnOn()
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
    }
}
