
using System.Collections;

public class Weapons : Items
{

    public Weapons(string Name, int Id, Type Type, int value) : base(Name, Id, Type,value)
    {

    }
    public override void ItemFunction(int amount, Meters meter)
    {
        meter.SetMeter(amount);
    }
}
