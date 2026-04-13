using System;
using Slay_Your_Vegetables;

using var game = new Slay_Your_Vegetables.Game1();
game.Run();

System.Console.WriteLine("What's your name?");
string NameInput= Console.ReadLine();



Tomato tomato= new Tomato();
Player player= new Player(NameInput);
Knife knife= new Knife();
tomato.DealDamage(tomato, knife);
