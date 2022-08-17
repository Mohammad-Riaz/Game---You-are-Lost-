
using System;
using System.Collections.Generic;

namespace YouAreLostPt1 // this game works on .NET console 
{
    //ABOUT GAME: this is a text based RPG , gameplay: you walk in to a tavern , get in trouble
    // get in fight with random opponents, you can name your own attack and luckily deal a lot of damage
    // opponents also deal you random amounts of damage // if you die you lose // if opponents dies you WIN


class MainClass // This game was created in 2021 in the beginning of the programming journey
                // I learned from and was inspired by Brakeys youtube channel and learned basics of C# from him
                // From all the things I learned(methods, getters and setters, while, if, classes, enum, inheritance etc.. )
                // I created this text based rpg game   
                // comment were added in 2022 // Now iam making actual games and have improved significantlly
{
    class game
    {   // static variables used in the whole program
        static public bool edied = true; 
        static public bool died = true;
        static public Random numberGen = new Random();
        static public int n = numberGen.Next(4, 10);
        static private int _ehp = n;
        static public string ename = "Babar Azam and Undertaker";
        
        static private int _hp = 4;
        static public int hp
    {
        get // getters and setters for your health
        { 
            return _hp; 
        }
        set
        {
            if (_hp < 0)
            {
                _hp = 0;
                died = false;
                
            }
            if (_hp > 10)
            {
                _hp = 10;
                died = true;
            }
        
        }
    }
    
        static public int ehp
    {
        get //getters and setters for enemy health
        {
            return _ehp; 
        }
        set
        {
            
            if (_ehp < 0)
            {
                _ehp = 0;
                edied = false;
                
            }
            if (_ehp > 10)
            {
                _ehp = 10;
                edied = true;
            }
        
        }

    }
    
        public game()
        {                // characters you will face in this game at random
            int result;
            List<string> enames = new List<string>();
            enames.Add("Tom and Jerry");
            enames.Add("Devil Jin and John Cena");
            enames.Add("Kira and CJ");
            enames.Add("SpiderMan and Thanos");
            enames.Add("Gol.D.Roger and Imran Khan");
            Random enumber = new Random();
            result =  enumber.Next(enames.Count);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You are facing " + enames[result] + " !!");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Your Hp is " + game.hp);
            Thread.Sleep(2000);
            ename = enames[result];
            Console.WriteLine( ename + " Hp is " + game.ehp);
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(2000);
            Console.WriteLine("Your turn first");
            Thread.Sleep(2000);
            Console.WriteLine("Name your special abilities and, Use them against your opponent.");
            Thread.Sleep(2700);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Press any Key to start the fight");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            enames.RemoveAt(result);
        }
    
        public void attack()
        {                   // Method for dealing damage to enemy 
            if (game._ehp > 0)
            {
                string? attack;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("You used your Special Ability called: ");
                attack = Console.ReadLine();
                Random numberGen = new Random();
                int move = numberGen.Next(1, 5);
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(1300);
                Console.WriteLine("Your attack \"" + attack + "\" dealt " + move + " damage.");
                Thread.Sleep(800);
                game._ehp -= move;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Enemy lost " + move + " Hp" );
                Thread.Sleep(800);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Enemy Hp is " + game._ehp);
                Thread.Sleep(800);
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                edied = false;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Enemy defeated.");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    
        public void damage()
        {                       // Method for the enemy to deal damage
            if (game._hp > 0)
            {
            int spell;
            List<string> eattack = new List<string>();
            eattack.Add("Rubber Hammer Smash!");
            eattack.Add("The Leg Spin!!");
            eattack.Add("Super Man Punch!!!");
            eattack.Add("R.K.O!!!!");
            eattack.Add("Red Hawk!!!!!");
            eattack.Add("Thunder Bagua!!!!!!");
            eattack.Add("Divine Departure!!!!!!!");
            Random number = new Random();
            spell =  number.Next(eattack.Count);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(900);
            Console.WriteLine(ename + " used their special ability \"" + eattack[spell] + "\"");
            Thread.Sleep(800);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("You lost " + spell + " Hp");
            Thread.Sleep(800);
            game._hp -= spell;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Your Hp is " + game._hp);
            Thread.Sleep(800);
            Console.ForegroundColor = ConsoleColor.Green;
            eattack.RemoveAt(spell);
            }
            else
            {
                died = false;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You died.");
                Thread.Sleep(800);
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }


public static void Main (string[] args) // The Main Method for the game
{
bool restart = true;
do  //Drama before the actual game // read the strings to understand whats going on
{
Console.Title = "'Your are lost' THE GAME ";
Console.ForegroundColor = ConsoleColor.Green;

// Game Start
Console.WriteLine("*POV* You are Traveller, And your lost.");
Thread.Sleep(3000);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("*You walk into a Tavern*");
Thread.Sleep(3600);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Stranger: Hey traveller, What's your name?");
Thread.Sleep(2000);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Your Brain: Say Your Name:" );

Console.ForegroundColor = ConsoleColor.Green;

String? userName = Console.ReadLine();

Thread.Sleep(500);

Console.WriteLine("Stranger: So Mr." + userName + ", Who are you?? Never seen you here before.");
Thread.Sleep(1500);

Console.WriteLine("Stranger: What do you seek here?");
Console.ForegroundColor = ConsoleColor.Magenta;
Thread.Sleep(2000);

Console.WriteLine("Your Brain: Say something Cool" );
Thread.Sleep(2000);

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Ahm....");

string? goal = Console.ReadLine();

Thread.Sleep(500);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("*Everyone laughs*");

Console.ForegroundColor = ConsoleColor.Green;
Thread.Sleep(1000);

Console.WriteLine("Stranger: LOL, Good luck with that.");
Thread.Sleep(1800);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("*You get triggered*");

    bool knownKeyPressed = false; //The two options for peace and fight in this do while loop.


        do
        {
            bool victory = true;
            Thread.Sleep(2000); //prompt user to choose between the two options
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Press \'A\' to beat up the Stranger.\nPress \'D\' to choose peace.");

            ConsoleKeyInfo keyReaded = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;

            switch (keyReaded.Key) //check which key was pressed.
            {
                case ConsoleKey.D: //D Key // peace option
                    Console.WriteLine("-You choose being Nice.");
                    Thread.Sleep(2000);
                    Console.WriteLine("I," + userName + ", will choose to ignore YOU");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("*You Ignore everyone, Buy some Food and Drinks and leave.*");
                    knownKeyPressed = true;
                    victory = true;
                    break;

                case ConsoleKey.A: //A Key // Violent option
                    Console.WriteLine("-You choose Violence!!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Stranger: looks like this '" + userName + "' guy is getting angry.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Stranger: Hey why are approaching me? :(");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("*You beat up the Stranger.*");
                    Thread.Sleep(2500);
                    Console.WriteLine("*You challenge everyone in the Tavern for a Duel.*");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(2500);
                    Console.WriteLine("Two people Ominiously stand up and Say \"We accept your challenge!!");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("*everyone in the Tavern starts chanthing \"FIGHT!! , FIGHT !! , FIGHT!! , FIGHT!!\"*");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Your Brain: Get Ready to Fight !!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    
                    game enemy = new game();
            while (game.died && game.edied) // attacks and checking who won in fight
            {
                enemy.attack();

                if (game.edied) //if enemy alive then damaga enemy
                {
                    enemy.damage();
                }
                if(!game.edied) //if enemy died then YOU WIN 
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Thread.Sleep(250);
                    Console.WriteLine("YOU WIN");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    victory = true;
                }
                if (!game.died) //if you died(LMAOOO) then you lost
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Thread.Sleep(250);
                    Console.WriteLine("YOU LOST");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    victory = false; 
                }
        
        }
        if (victory) // if you won this code will work
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(2000);
            Console.WriteLine("You defeated " + game.ename + " and they were strongest in whole Tavern. Everyone is SHOCKED.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(2000);

            Console.WriteLine("*You buy some food and drinks from the and leave*");
            Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You see one of your crew member in the crowd.");
            Thread.Sleep(2000);

            Console.Write("His name is....");

            string? member1 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Congratulations you completed part-1 of \'you are lost\'.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(2500);

            Console.WriteLine("TO BE COUNTINUED");
            restart = false;
        }
        if (!victory) // if you lost (lol loser) this code will work
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(2000);
            Console.WriteLine("*You were deeply humiliated and laugh at, After your were defeated by " + game.ename + "*");
            Thread.Sleep(2100);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(game.ename + "Both grabbed you and kicked you out of the Tavern.");
            Thread.Sleep(2100);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You lost the part-1 of \'you are lost'.\nPlease try again.");
            Thread.Sleep(2500);

            restart = true;
        }
                    knownKeyPressed = true;
                    break;

                default: //Not known key pressed
                    Console.WriteLine("-Wrong key, please try again.");
                    knownKeyPressed = false;
                    break;
            }
        } while(!knownKeyPressed); // between the two options if wrong key is pressed this will replay the code above
} while (restart); // restarts if you lost 

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.BackgroundColor = ConsoleColor.Black;

Thread.Sleep(1700);
Console.WriteLine("Press any key to Exit"); //EXIT 
Console.ReadKey(); //BYEE 
}
}
}
 

