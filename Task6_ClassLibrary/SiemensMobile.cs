namespace Task6_ClassLibrary
{
    public abstract class SiemensMobile : IMobile
    {
        public string Name { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }

        public abstract string TurnOn();

        public abstract string SwitchOff();

        public string Call()
        {
            return "Calling...";
        }
    }
}
