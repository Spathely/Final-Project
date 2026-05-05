using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


public interface IEnemy
{
    string Name {get;set;}
    int MaxHP {get;set;}
    int CurrentHP {get;set;}
    int AttackPower {get;set;}
    float Speed {get;set;}

    void DealDamage();
    void TakeDamage();
    void PushBack();
}
public class Enemy:Sprite, IEnemy
{
    public static Dictionary<int, Texture2D> textures= new Dictionary<int, Texture2D>();// texture ile ID leri bağladık

    public string Name {get;set;}
    public int MaxHP {get;set;}
    public int CurrentHP {get;set;}
    public int AttackPower {get;set;}
    public float Speed {get;set;}
    
    public Enemy(Texture2D texture,Vector2 position) :base(texture,position) {}

    public virtual void DealDamage(){}
    public virtual void TakeDamage(){}
    public virtual void PushBack(){}

    public virtual void Update(GameTime gameTime)
    {
        position.X-=Speed;
    }

    public static Enemy CreateEnemy(int ID, Vector2 position)
    {
        if(!textures.ContainsKey(ID))
        {
            return null;
        }
        Texture2D currentTexture= textures[ID];
        switch (ID)
        {
            case 0: return new Tomato(currentTexture,position);
            case 1: return new Lettuce(currentTexture,position);
            case 2: return new Lemon(currentTexture,position);
            case 3: return new Bread(currentTexture,position);
            default: return null;
           
            

        }
    }
   
}

