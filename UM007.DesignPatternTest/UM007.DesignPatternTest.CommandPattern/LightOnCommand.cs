namespace UM007.DesignPatternTest.CommandPattern
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            this._light.LightOn();
        }

        public void Undo()
        {
            this._light.LightOff();
        }
    }
}
