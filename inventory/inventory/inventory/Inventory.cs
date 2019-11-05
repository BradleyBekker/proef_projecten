using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Collections;

public class Inventory
{
    int selectedItem = 0;
   public List<Items> inventory = new List<Items>();
    
   public void AddItem(Items i)
    {
        if (GetInventory().Count >= 28)
        {
            return;
        }
        inventory.Add(i);
    }

  public List<Items> GetInventory()
    {
        return inventory;
    }

   public void DrawInventory(SpriteBatch sp, SpriteFont font)
    {
        for (int i = 0; i < inventory.Count; i++)
        {

            sp.DrawString(font, GetInventory()[i].name, new Vector2(50, 30 + 16 * i), Color.Black);
            if (i == selectedItem)
            {
                sp.DrawString(font, GetInventory()[i].name, new Vector2(50, 30 + 16 * i), Color.Red);
            }
        }
    }

    public void RemoveItem(Items i)
    {
        inventory.Remove(i);
    }

    public List<Items> SortByName(List<Items> items)
    {
        

        return items;
    }

    public void SortById()
    {

        inventory.Sort(Sortid);
        
    }
    public void SortByName()
    {

        inventory.Sort(sortstring);
        
    }
    
    private int Sortid(Items a,Items b)
    {
        if (a.id < b.id)
        {
            return 1;
        }
        else if (a.id > b.id)
        {
            return -1;
        }
        return 0;
    }
    private int sortstring(Items a,Items b)
    {
        
        return a.name.CompareTo(b.name);
    }

    public void SelectUp()
    {
        if (selectedItem < 0)
        {
            selectedItem = GetInventory().Count-1;
        }
        else
        {
            selectedItem--;
        }
    }
    public void SelectDown()
    {
        if (selectedItem >= GetInventory().Count)
        {
            selectedItem = 0;
        }
        else
        {
            selectedItem++;

        }
    }
    public void UseSelected(Meters meter)
    {
        GetInventory()[selectedItem].ItemFunction(GetInventory()[selectedItem].value,meter);
    }
    public Items GetSelected()
    {
        if (selectedItem >= GetInventory().Count)
        {
            SelectUp();
        }
        return GetInventory()[selectedItem];
    }
    public int GetSelectedInt()
    {
        return selectedItem;
    }
}
