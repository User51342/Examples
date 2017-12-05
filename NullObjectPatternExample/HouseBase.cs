using System;

namespace NullObjectPatternExample
{
    public abstract class HouseBase
    {
        public abstract Guid Id { get; }
        public abstract string Name { get; }
        public abstract void OpenDoor();
        public abstract void CloseDoor();

        private static HouseBase _Null;
        public static HouseBase NULL
        {
            get
            {
                if (_Null == null)
                {
                    _Null = new MyNull();
                }
                return _Null;
            }
        }

        private class MyNull : HouseBase
        {
            public override Guid Id => Guid.Empty;

            public override string Name => string.Empty;

            public override void CloseDoor()
            { }

            public override void OpenDoor()
            { }
        }
    }
}
