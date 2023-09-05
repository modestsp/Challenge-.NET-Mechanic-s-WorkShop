namespace Challenge_.NET_Mechanic_s_WorkShop.Models;


public enum AutomobileType
{
    Compact,
    Sedan,
    Minivan,
    Utility,
    Luxury
}

public class Automobile : Vehicle
{
    private AutomobileType _automobileType;
    public Automobile(AutomobileType automobileType)
    {
        _automobileType = automobileType;
    }

}