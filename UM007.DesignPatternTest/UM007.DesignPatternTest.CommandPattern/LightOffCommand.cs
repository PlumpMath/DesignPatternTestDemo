namespace UM007.DesignPatternTest.CommandPattern
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            this._light.LightOff();
        }

        public void Undo()
        {
            this._light.LightOn();
        }
    }
}
