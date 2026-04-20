using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


    internal class Enemy
    {
        public string Name;
        public int CurrentHP;
        public int MaxHP;
        public int AttackPower;
        public Texture2D texture;
        public Vector2 position;
        public void Attack(Player player, Enemy enemy) { }
        public void DealDamage(Enemy enemy,Weapons weapons) {}

    }
    internal class Tomato : Enemy
    {
        public Tomato()
        {
            Name = "Tomato";
            CurrentHP = 50;
            MaxHP = 50;
            AttackPower = 5;

        }
        
    }
  




