namespace PrototypePatternExample
{
    class Program
    {
        /// <summary>
        /// See <see cref="https://app.pluralsight.com/player?course=patterns-library&author=john-sonmez&name=design-patterns-prototype&clip=7&mode=live">Webcast</see>
        /// </summary>
        /// <param name="args"></param>
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
