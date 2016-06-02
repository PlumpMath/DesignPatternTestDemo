namespace UM007.DesignPatternTest.CommandPattern
{
    public class FanOnCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private readonly int _fanSpeed;
        private int _prevSpeed;

        public FanOnCommand(CeilingFan ceilingFan, int fanSpeed)
        {
            this._ceilingFan = ceilingFan;
            this._fanSpeed = fanSpeed;
        }

        public void Execute()
        {
            this._prevSpeed = _ceilingFan.GetSpeed();
            this._ceilingFan.AdjustSpeed(this._fanSpeed);
        }

        public void Undo()
        {
            this._ceilingFan.AdjustSpeed(this._prevSpeed);
        }
    }
}
