namespace NullObjectPatternExample
{
    public class HouseRepository
    {
        public HouseBase Find(string name)
        {
            if(name == "Empire State Building")
            {
                return new EmpireStateBuilding();
            }
            return HouseBase.NULL;
        }
    }
}
