using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections;

public class Meters
{
   private string name;
   private int value;
    public Meters(int Value, string Name)
    {
        name = Name;
        value = Value;
    }
    public void SetMeter(int setValue)
    {
        value = setValue;
    }
    public int GetMeter()
    {
        return value;
    }
    public void AddMeter(int addValue)
    {
        value += addValue;
    }
    public void DrawMeter(SpriteBatch sp, SpriteFont font,Vector2 pos,Color color)
    {
        sp.DrawString(font,name + ":" + GetMeter(),pos,color);
    }


}
