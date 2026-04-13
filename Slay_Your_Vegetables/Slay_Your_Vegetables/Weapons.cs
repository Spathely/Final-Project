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
        public bool IsKnife;
        

    }
    internal class Knife:Weapons
    {
        public Knife()
        {
            Name= "Knife";
            AttackPower= 25;
            IsKnife= true;
        }
        
    }
}