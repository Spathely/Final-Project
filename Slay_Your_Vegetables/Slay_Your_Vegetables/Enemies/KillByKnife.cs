using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

//Tomato, Lettuce, Lemon, Bread, Mushroom, Banana, Biscuit
//high hp (300-500), low speed


public class Tomato: Enemy
{
    public Tomato(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Tomato";
        MaxHP= 250;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 2.0f;
    }

    public new void DealDamage(){}
    public new void TakeDamage(){}
    public new void PushBack(){}
    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }

}
public class Lettuce:Enemy
{
    public Lettuce(Texture2D texture, Vector2 position): base(texture,position)
    {
        Name="Tomato";
        MaxHP= 250;
        CurrentHP= MaxHP;
        AttackPower= 10;
        Speed= 5f;
    }
}
public class Lemon:Enemy
{
    public Lemon(Texture2D texture, Vector2 position): base(texture,position){}
}
public class Bread:Enemy
{
    public Bread(Texture2D texture, Vector2 position): base(texture,position){}
}
public class Mushroom:Enemy
{
    public Mushroom(Texture2D texture, Vector2 position): base(texture,position){}
}