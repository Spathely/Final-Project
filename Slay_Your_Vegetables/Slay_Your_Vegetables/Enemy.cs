using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


public interface IEnemy
{
    string Name { get; set; }
    int MaxHP { get; set; }
    int CurrentHP { get; set; }
    int AttackPower { get; set; }
    int Speed { get; set; }
    void Attack();
    void DealDamage();
}
internal class Enemy : Sprite, IEnemy
{
    public string Name { get; set; }
    public int MaxHP { get; set; }
    public int CurrentHP { get; set; }
    public int AttackPower { get; set; }
    public int Speed { get; set; }

    public Enemy(Texture2D texture, Vector2 position) : base(texture, position)
    {
        //write that this.name
    }
    public void Attack() { }
    public void DealDamage() { }

}






