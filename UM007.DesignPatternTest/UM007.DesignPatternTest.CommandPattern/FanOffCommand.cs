namespace UM007.DesignPatternTest.CommandPattern
{
    public class FanOffCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private int _prevSpeed;

        public FanOffCommand(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            this._prevSpeed = _ceilingFan.GetSpeed();
            this._ceilingFan.Low();
        }

        public void Undo()
        {
            this._ceilingFan.AdjustSpeed(this._prevSpeed);
        }
    }
}
