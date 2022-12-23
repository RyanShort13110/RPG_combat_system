using System;

namespace TextBasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 100;
            int enemyHealth = 100;
            int healthPotion = 1;
            Console.WriteLine("What is the name of our hero today?");
            string playerName = Console.ReadLine();
            Console.WriteLine("\n");


            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine($"{playerName} has {playerHealth} health points.");
                Console.WriteLine($"The balrog has {enemyHealth} health points.");
                Console.WriteLine($"You have {healthPotion} health potion(s)!");
                Console.WriteLine("\n");
                Console.WriteLine($"Type 'attack' to attack the enemy, or type 'block' to block their attack! Type 'potion' to heal 20 points of health, but you only get one so use it wisely! Press enter after typing your choice.");

                string choice = Console.ReadLine();

                int enemyDamage = new Random().Next(15, 41);
                int playerDamage = new Random().Next(15, 31);

                // set player actions
                if (choice == "potion" && healthPotion >= 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"{playerName} has used their only health potion!");
                    Console.Write("\n");
                    healthPotion -= 1;
                    playerHealth += 20;
                }
                if (choice == "attack")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"You attack your enemy dealing {playerDamage} damage points!");
                    enemyHealth -= playerDamage;
                    Console.WriteLine($"The balrog attacks you dealing {enemyDamage} damage points!");
                    Console.WriteLine("\n");
                    playerHealth -= enemyDamage;
                }
                if (choice == "block")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("You blocked the attack!");
                    Console.WriteLine($"The balrog would've dealt {enemyDamage} damage points this turn!");
                    Console.WriteLine("\n");
                }

                // check outcome conditions
                if (playerHealth <= 0 && enemyHealth <= 0)
                {
                    Console.WriteLine("Huh... Somehow you both died, even though you had access to a health potion. Well, game over I guess.");
                }else if (playerHealth <= 0)
                {
                    Console.WriteLine($"Oh no! You have no health points left! You've been killed and your foe is currently teabagging your corpse!");
                }else if (enemyHealth <= 0)
                {
                    Console.WriteLine($"Your enemy has no health points left! You've vanquished the balrog. Well done! You had {playerHealth} health points remaining.");
                }
            }
        }
    }
}