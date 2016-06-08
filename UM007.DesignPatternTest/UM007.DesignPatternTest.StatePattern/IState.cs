namespace UM007.DesignPatternTest.StatePattern
{
    public interface IState
    {
        void InsertQuarter();

        void EjectQuarter();

        void TurnCrank();

        void Dispense();
    }
}
