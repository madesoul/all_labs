namespace Task6_ClassLibrary
{
    public class Model : SiemensMobile
    {
        public string ModelSpec { get; set; }
        public string Storage { get; set; }

        public override string TurnOn()
        {
            return "Turning on...";
        }

        public override string SwitchOff()
        {
            return "Switching off...";
        }

        public string UseStorage()
        {
            return "Using storage...";
        }
    }
}
