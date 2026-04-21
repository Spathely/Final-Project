using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



    internal class Torch:Weapons
    {
        public Torch()
        {
            Name= "Torch";
            AttackPower= 30;
            
        }
        
        public int Attack(Torch torch,Enemy enemy)
        {
            enemy.CurrentHP-=torch.AttackPower;
            return enemy.CurrentHP;
        }
    }
      