using System;

namespace UM007.DesignPatternTest.CommandPattern
{
    public class CeilingFan
    {
        public const int HighSpeed = 3;
        public const int MediumSpeed = 2;
        public const int LowSpeed = 1;
        public const int OffSpeed = 0;
        private int _speed;
        private readonly string _description;

        public CeilingFan(string description)
        {
            this._description = description;
        }

        public void High()
        {
            _speed = CeilingFan.HighSpeed;
            Console.WriteLine("{0} is on, speed is {1}", this._description, this._speed);
        }
        public void Medium()
        {
            _speed = CeilingFan.MediumSpeed;
            Console.WriteLine("{0} is on, speed is {1}", this._description, this._speed);
        }
        public void Low()
        {
            _speed = CeilingFan.LowSpeed;
            Console.WriteLine("{0} is on, speed is {1}", this._description, this._speed);
        }

        public void Off()
        {
            _speed = CeilingFan.OffSpeed;
            Console.WriteLine("{0} is off", this._description);
        }

        public int GetSpeed()
        {
            return _speed;
        }

        public void AdjustSpeed(int fanSpeed)
        {
            switch (fanSpeed)
            {
                case CeilingFan.OffSpeed:
                    Off();
                    break;
                case CeilingFan.LowSpeed:
                    Low();
                    break;
                case CeilingFan.MediumSpeed:
                    Medium();
                    break;
                case CeilingFan.HighSpeed:
                    High();
                    break;
                default:
                    Off();
                    break;
            }
        }
    }
}
