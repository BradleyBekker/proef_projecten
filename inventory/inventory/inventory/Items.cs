using System.Collections;

public  class Items
{
    public enum Type {consumable, weapon}
    public string name;
    public int id;
    public Type type;
    public int value;
    public Items(string Name, int Id, Type Type,int Value)
    {
        type = Type;
        name = Name;
        id = Id;
        value = Value;

    }
    public virtual void ItemFunction(int amount,Meters meter)
    {

    }

       
}


