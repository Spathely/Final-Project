using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class SpawnManage
{
    private List<Enemy> enemies;
    private Vector2[] spawnPoints;
    private Random random;
    private float spawnTime;
    public LevelManage lvl;

    private Dictionary<int, Texture2D> textures;
    
    public SpawnManage(LevelManage level,Dictionary<int,Texture2D> textures)
    {
        this.lvl= level;
        this.textures= textures;
        enemies = new List<Enemy>();
        random = new Random();
        
        spawnPoints = new Vector2[]
        {
            new Vector2(800,45),
            new Vector2(800,138),
            new Vector2(800,231),
            new Vector2(800,324)
        };
    }
    // add update and draw like Game1.cs

    public void Update(GameTime gameTime)
    {
        if (lvl.CurrentLevel==null){return;} // seviye ayarı 
        
         spawnTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
        if (spawnTime>= lvl.CurrentLevel.spawnPeriod)
        {
            Spawn();
            spawnTime=0;
        }
        for(int i= enemies.Count -1; i>=0; i--)
        {
            enemies[i].Update(gameTime);
            if(enemies[i].CurrentHP<=0)
            {
                enemies.RemoveAt(i);
            }
        }

        
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        foreach (var enemy in enemies)
        {
            enemy.Draw(spriteBatch);
        }
    }
     private int CountEnemy(int ID)
    {
        int count=0;
        foreach(var e in enemies)
        {
            switch(ID)
            {
                case 0: if(e is Tomato) count++; break;
                case 1: if(e is Lettuce) count++; break;
                case 2: if(e is Lemon) count++; break;
                case 3: if(e is Bread) count++; break;
                default: break;
                
            }
        } 
        return count;
    }
    private void Spawn() //for spawnning the spawnpoints
    {
      var pool= lvl.CurrentLevel.SpawnPool;
      if (pool== null || pool.Count ==0){return;}

      int selectedID= pool[random.Next(0,pool.Count)];
      
      if (CountEnemy(selectedID)<3)
        {
            Vector2 position= spawnPoints[random.Next(0,spawnPoints.Length)];
            Enemy n_enemy= Enemy.CreateEnemy(selectedID,position);

            if (n_enemy != null)
            {
                enemies.Add(n_enemy);
            }

        }

      

    }
    
    }
    
     