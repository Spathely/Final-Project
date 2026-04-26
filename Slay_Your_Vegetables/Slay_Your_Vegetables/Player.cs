using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


    internal class Player:Sprite
    {
         private int Speed;
        public  Rectangle Rect
    {
        get
        {
            return new Rectangle(35,50,90,90);
        }
    }
        
        public Player(Texture2D texture,Vector2 position) : base(texture,position)
        {
            
        }
       
        
        
    }
    
