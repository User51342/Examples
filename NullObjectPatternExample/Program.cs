namespace NullObjectPatternExample
{
    class Program
    {
        /// <summary>
        /// See <see cref="https://app.pluralsight.com/player?course=patterns-library&author=david-starr&name=pattern-null-object&clip=8&mode=live">Pluralsight course</see>
        /// </summary>
        static void Main()
        {
            var repository = new HouseRepository();
            var house  = repository.Find("Empire Building"); // "Empire State Building" works, otherwise null object will returned.
            house.OpenDoor();
            house.CloseDoor();
        }
    }
}
