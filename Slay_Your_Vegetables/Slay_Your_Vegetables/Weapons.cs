using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Slay_Your_Vegetables

{
    internal class Weapons
    {
        public string Name;
        public int AttackPower;
        public Texture2D texture;
        public Vector2 position;
        public void Attack(){}
        public void Ulti(){}
        
        

    }
    internal class Knife:Weapons
    {
        public Knife()
        {
            Name= "Knife";
            AttackPower= 25;
            
        }
        
        public int Attack(Knife knife,Enemy enemy)
        {
            enemy.CurrentHP-=knife.AttackPower;
            return enemy.CurrentHP;

        }
    }
    internal class Torch: Weapons
    {
        
    }
    internal class Blender:Weapons
    {
        
    }

}