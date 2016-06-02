namespace UM007.DesignPatternTest.CommandPattern
{
    public class RemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        private ICommand _prevCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < _onCommands.Length; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommond(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _prevCommand = _onCommands[slot];
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _prevCommand = _offCommands[slot];
            _offCommands[slot].Execute();
        }

        public void UndoButtonWasPushed()
        {
            this._prevCommand.Undo();
        }
    }
}
