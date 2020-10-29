using System;
using System.Collections.Generic;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice newDevice = Remote.GetDevice();

            //pogam varam pieskirt funkcionalitati
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
            //var uztaisit vel radioaparatus
            Radio someRadio = new Radio();
            Radio someAnotherRadio = new Radio();

            //var ari sataisit,lai visas iekartas varetu piem izslēgt reizee
            List<IDevice> allDevices = new List<IDevice>();

            allDevices.Add(someRadio);
            allDevices.Add(someAnotherRadio);

            TurnOffAllDevices turnOffDevices = new TurnOffAllDevices(allDevices);
            DeviceButton TurnAllOffButton = new DeviceButton(turnOffDevices);

            TurnAllOffButton.Press();
            TurnAllOffButton.Unpress();
        }
    }
}
