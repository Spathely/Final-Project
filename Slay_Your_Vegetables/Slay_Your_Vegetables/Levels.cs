using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public interface ILevel
{
    Dictionary<int,int> Goals{get;}
    List<int> SpawnPool {get;}
    float spawnPeriod{get;}
}
public class LevelManage
{
    public ILevel CurrentLevel{get;private set;}
    public void LoadLevel(int lvlNumber)
    {
        switch (lvlNumber)
        {
            case 1: CurrentLevel= new Level1(); break;

            default: CurrentLevel=null; break;
            
        }
    }
    
}

public class Level1: ILevel // g for "goal"
{
     public Dictionary<int,int> Goals => new Dictionary<int, int> // look at the enemies ID in enemy.cs
     {
         {0,3},{1,4},{2,5}
     };
     public List<int> SpawnPool => new List<int> {0,0,1,1,1,2}; // The requirement (enemy ID's)
     public float spawnPeriod=> 2.0f;
     public void Draw(SpriteBatch spriteBatch)
    {
        
    }

}
public class Level2
{

}
public class Level3
{
   
}
public class Level4
{
    
}
public class Level5
{
    
}


