using System.Collections;
using Microsoft.Xna.Framework.Input;

public class Input
{
    bool upReleased = true;
    public bool UPispressed()
    {      
        if (Keyboard.GetState().IsKeyDown(Keys.Up)&& upReleased)
        {            
            upReleased = false;           
            return true;
        }
        if (!upReleased && Keyboard.GetState().IsKeyUp(Keys.Up))
        {
            upReleased = true;
        }

        return false;
    }
    bool downReleased = true;
    public bool DOWNispressed()
    {      
        if (Keyboard.GetState().IsKeyDown(Keys.Down)&& downReleased)
        {            
            downReleased = false;           
            return true;
        }
        if (!downReleased && Keyboard.GetState().IsKeyUp(Keys.Down))
        {
            downReleased = true;
        }

        return false;
    }
    bool iReleased = true;
    public bool Iispressed()
    {      
        if (Keyboard.GetState().IsKeyDown(Keys.I)&& iReleased)
        {            
            iReleased = false;           
            return true;
        }
        if (!iReleased && Keyboard.GetState().IsKeyUp(Keys.I))
        {
            iReleased = true;
        }

        return false;
    }

    bool SpaceReleased = true;
    public bool Spaceispressed()
    {      
        if (Keyboard.GetState().IsKeyDown(Keys.Space)&& SpaceReleased)
        {
            SpaceReleased = false;           
            return true;
        }
        if (!SpaceReleased && Keyboard.GetState().IsKeyUp(Keys.Space))
        {
            SpaceReleased = true;
        }

        return false;
    }
}
