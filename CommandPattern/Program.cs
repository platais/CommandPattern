using System;
using System.Collections.Generic;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice newDevice = Remote.GetDevice();

            TurnRadioOn onCommand = new TurnRadioOn(newDevice);
            DeviceButton onPress = new DeviceButton(onCommand);
            onPress.Press();

            TurnRadioOff offCommand = new TurnRadioOff(newDevice);
            onPress = new DeviceButton(offCommand);
            onPress.Press();

            TurnRadioVolUp volUpCommand = new TurnRadioVolUp(newDevice);
            onPress = new DeviceButton(volUpCommand);
            onPress.Press();
            onPress.Press();
            onPress.Press();
            onPress.Press();

            TurnRadioVolDown volDownCommand = new TurnRadioVolDown(newDevice);
            onPress = new DeviceButton(volDownCommand);
            onPress.Press();

            TV someTvSet = new TV();
            Radio someRadio = new Radio();
            TV someAnotherTvSet = new TV();
            Radio someAnotherRadio = new Radio();

            List<IDevice> allDevices = new List<IDevice>();

            allDevices.Add(someTvSet);
            allDevices.Add(someRadio);
            allDevices.Add(someAnotherTvSet);
            allDevices.Add(someAnotherRadio);

            TurnOffAllDevices turnOffDevices = new TurnOffAllDevices(allDevices);
            //kā pievienot jaunu pogu pultij
            DeviceButton TurnAllOffButton = new DeviceButton(turnOffDevices);

            TurnAllOffButton.Press();
            TurnAllOffButton.Unpress();
        }
    }
}
