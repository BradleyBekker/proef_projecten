using System.Collections;

public class consumable : Items
{
    public consumable(string Name, int Id, Type Type,int value) : base(Name, Id, Type,value)
    {

    }
    public override void ItemFunction(int amount,Meters meter)
    {
        meter.AddMeter(amount);
    }
}
