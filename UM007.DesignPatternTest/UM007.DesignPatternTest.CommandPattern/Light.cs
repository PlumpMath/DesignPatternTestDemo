using System;

namespace UM007.DesignPatternTest.CommandPattern
{
    public class Light
    {
        private readonly string _description;

        public Light(string description)
        {
            this._description = description;
        }

        public void LightOn()
        {
            Console.WriteLine("{0} is on", this._description);
        }

        public void LightOff()
        {
            Console.WriteLine("{0} is off", this._description);
        }
    }
}
