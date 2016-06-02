namespace UM007.DesignPatternTest.CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light bedroomLight = new Light("卧室灯");
            Light kitchenLight = new Light("厨房灯");
            CeilingFan ceilingFan = new CeilingFan("吊扇");

            LightOnCommand bedroomLightOnCommand = new LightOnCommand(bedroomLight);
            LightOffCommand bedroomLightOffCommand = new LightOffCommand(bedroomLight);

            LightOffCommand kitchenLightOffCommand = new LightOffCommand(kitchenLight);
            LightOnCommand kitchenLightOnCommand = new LightOnCommand(kitchenLight);

            FanOnCommand ceilingFanHighCommand = new FanOnCommand(ceilingFan, CeilingFan.HighSpeed);
            FanOnCommand ceilingFanMediumCommand = new FanOnCommand(ceilingFan, CeilingFan.MediumSpeed);
            FanOnCommand ceilingFanLowCommand = new FanOnCommand(ceilingFan, CeilingFan.LowSpeed);
            FanOffCommand ceilingFanOffCommand = new FanOffCommand(ceilingFan);

            remoteControl.SetCommond(0, bedroomLightOnCommand, bedroomLightOffCommand);
            remoteControl.SetCommond(1, kitchenLightOnCommand, kitchenLightOffCommand);
            remoteControl.SetCommond(2, ceilingFanHighCommand, ceilingFanOffCommand);
            remoteControl.SetCommond(3, ceilingFanMediumCommand, ceilingFanOffCommand);
            remoteControl.SetCommond(4, ceilingFanLowCommand, bedroomLightOnCommand);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(4);
        }
    }
}
