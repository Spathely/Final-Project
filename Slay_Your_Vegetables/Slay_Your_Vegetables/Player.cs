using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


    internal class Player
    {
        public string Name;
        public int MaxHP;
        public int CurrentHP;
        public Texture2D texture;
        public Vector2 position;
        public void Attack(Enemy enemy){}
        public void DealDamage(Enemy enemy){}
        public void UseUlt(Weapons weapons){}
        
        public Player(string name)
        {
            Name= name;
            MaxHP= 100;
            CurrentHP=100;
            
        }
    }
    
