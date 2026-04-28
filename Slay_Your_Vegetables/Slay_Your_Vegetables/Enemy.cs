using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


public interface IEnemy
{
    string Name { get; set; }
    int MaxHP { get; set; }
    int CurrentHP { get; set; }
    int AttackPower { get; set; }
    float Speed { get; set; }
    void Attack();
    void DealDamage();
}
internal class Enemy : Sprite, IEnemy
{
    public string Name { get; set; }
    public int MaxHP { get; set; }
    public int CurrentHP { get; set; }
    public int AttackPower { get; set; }
    public float Speed { get; set; }

    public Enemy(Texture2D texture, Vector2 position) : base(texture, position)
    {
<<<<<<< Updated upstream
        //write that this.name
=======
      this.Texture=texture;
      this.Position=position;

>>>>>>> Stashed changes
    }
    public void Attack() { }
    public void DealDamage() { }

}






