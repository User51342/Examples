using System;

namespace NullObjectPatternExample
{
    public class EmpireStateBuilding : HouseBase
    {
        public override Guid Id => Guid.Parse("91ED1500-C36C-4B70-BA41-3C0FBD3A8796");

        public override string Name => "Empire State Building";

        public override void CloseDoor()
        {
            Console.WriteLine($"{Name} doors are open.");
        }

        public override void OpenDoor()
        {
            Console.WriteLine($"{Name} doors are close.");
        }
    }
}
