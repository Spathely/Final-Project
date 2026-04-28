using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

//Tomato, Lettuce, Lemon, Bread, Mushroom, Banana, Biscuit
//high hp, low speed
public class Tomato:Enemy
{
    public Tomato(Texture2D texture, Vector2 position) : base(texture, position)
    {
        Name="Tomato";
<<<<<<< Updated upstream
        texture=this.texture;
        position= this.position;
=======
        MaxHP=250;
        CurrentHP=MaxHP;
        AttackPower=10;
        Speed= 1f; // try the speed in game
        this.Texture = texture;
        this.Position= position;
>>>>>>> Stashed changes
    }
     public void TakeDamage(float amount) { }
    public void PushBack(float force) { }

    public void Attack() { }
    public void DealDamage() { }
}