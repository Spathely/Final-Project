using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public interface Icharacter
{
    string Name { get; set; }
    int MaxHP { get; set; }
    int CurrentHP { get; set; }
    int AttackPower { get; set; }
    void Attack();
    void DealDamage();
}