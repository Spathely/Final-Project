using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Slay_Your_Vegetables
{
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
        public int DealDamage(Tomato tomato, Knife knife)
        {
            if (knife.IsKnife)
            {
                tomato.CurrentHP -= knife.AttackPower;
                System.Console.WriteLine("-" + knife.AttackPower);
                if (tomato.CurrentHP <= 0)
                {
                    tomato.CurrentHP=0;
                    //dead animation
                }
                return tomato.CurrentHP;
            }
            else
            {
                System.Console.WriteLine("0");
                return tomato.CurrentHP;
            }

        }
    }
  




}