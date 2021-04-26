namespace Task6_ClassLibrary
{
    public interface IMobile
    {
        string Name { get; set; }

        string TurnOn();

        string SwitchOff();
    }
}
