using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


    internal class Enemy:Sprite, Icharacter
    {
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int AttackPower{ get; set; }

        public Enemy(Texture2D texture, Vector2 position) : base(texture, position)
        {
            Name = "Enemy";
            MaxHP = 50;
            CurrentHP = MaxHP;
            AttackPower = 10;
        }
        public void Attack() { }
        public void DealDamage() {}

    }
    
  




