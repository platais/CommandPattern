namespace CommandPattern
{
    public class TurnRadioOff : ICommand
    {
        private IDevice _radio;
        public TurnRadioOff(IDevice radio)
        {
            _radio = radio;
        }

        public void Execute()
        {
            _radio.Off();
        }

        public void Unexecute()
        {
            _radio.On();
        }
    }
}
