namespace UM007.DesignPatternTest.CommandPattern
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
