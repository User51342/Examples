namespace PrototypePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var status1 = new StatusSwitcher();
            status1.DisplayStatus();
            status1.SwitchStatusTo(2);
            status1.DisplayStatus();
            var status2 = status1.Clone() as StatusSwitcher;
            status2.DisplayStatus();
            status2.SwitchStatusTo(3);
            status1.DisplayStatus();
            status2.DisplayStatus();
        }
    }
}
