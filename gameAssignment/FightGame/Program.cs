namespace FighterGame{
    class Program
    {

        static void Main(string[] args)
        {
            bool running = true;
            while (running){
            int score = 0;
            int health = 2000;
            monsters monster = new monsters ();

            Console.WriteLine("Welcome to Monster Fighter: A console Monster Fighting Dungeon Game! Have fun!");
            Console.Write("First things first. Please enter a character name: ");
            string charName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Welcome to the dungeon {charName}! You will now fight a series of monsters. Each monster will award points and will chip away at your health until it reaches 0.");
            Console.WriteLine("Once your health reaches 0, the game will be over and your score will be based on how many monsters you killed and the strength of the monster.");
            Console.WriteLine("You may choose to skip any monster you like, however that will cost you 150 points!\n");
            Console.WriteLine("Press enter to proceed into the dungeon.");
            Console.ReadLine();
            Console.Clear();
            do {
                string randomMonster = monster.chooseRandomMonster();
                Console.WriteLine($"While walking through the dungeon you run into a: {randomMonster}. Would you like to engage it? yes/no: ");
                string fightIt = Console.ReadLine();
                if (fightIt == "no"){
                    Console.WriteLine("You lose 150 points and you continue walking.");
                    score = score - 150;
                }
                else if (fightIt == "yes"){
                    if (randomMonster == "Zombie"){
                        health = health - 50;
                        score = score + 25;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 50 points! However, the zombie damaged you for 50 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Baby Zombie"){
                        health = health - 25;
                        score = score + 15;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 25 points! However, it damaged you for 25 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Wolf"){
                        health = health - 75;
                        score = score + 45;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 45 points! However, it damaged you for 50 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Angry Chicken"){
                        health = health - 100;
                        score = score + 25;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 25 points! However, it damaged you for 100 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Deerbra"){
                        health = health - 125;
                        score = score + 75;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 75 points! However, it damaged you for 125 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Raptor"){
                        health = health - 150;
                        score = score + 100;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 100 points! However, it damaged you for 150 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Wyvern"){
                        health = health - 175;
                        score = score + 125;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 125 points! However, it damaged you for 175 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Centaur"){
                        health = health - 200;
                        score = score + 175;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 175 points! However, it damaged you for 175 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Elemental"){
                        health = health - 225;
                        score = score + 200;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 200 points! However, it damaged you for 200 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Lizardman"){
                        health = health - 250;
                        score = score + 250;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 250 points! However, it damaged you for 250 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Dragon"){
                        health = health - 500;
                        score = score + 750;
                        Console.WriteLine($"You defeated the {randomMonster}! You gain 750 points! However, it damaged you for 750 life points. You now have {health} remaining.");
                    }
                    if (randomMonster == "Healing Potion"){
                        health = health + 250;
                        Console.WriteLine($"You found a {randomMonster}! You gain 250 life points! You now have {health} remaining.");
                    }
                }
                else { 
                    Console.WriteLine("You entered an invalid answer. Please try again.");
                }
            }
            while (health > 0 );
            Console.WriteLine($"Oh no! Your character {charName} has fallen. Your final score was {score}. Would you like to play again? y/n");
            string playAgain = Console.ReadLine();
            if (playAgain == "y"){
                Console.WriteLine("Good luck!");
                Console.Clear();
            }
            else if (playAgain == "n"){
                running = false;
                Console.WriteLine("Thank you for playing!");
            }
            else {
                Console.Clear();
                Console.WriteLine("I'm sorry you appeared to enter an invalid response. We will take you back to the beginning of the game!");
            }
            }
        }
            class monsters {
            Random _random = new Random();
            public string chooseRandomMonster()
            {
                string[] monsterType = new string[] {"Zombie", "Baby Zombie", "Wolf", "Angry Chicken", "Deerbra", "Raptor", "Wyvern", "Centaur", "Elemental", "Lizardman","Dragon", "Healing Potion"};
                int randomNumber = _random.Next(0, monsterType.Length);
                string randomType = monsterType.ElementAt(randomNumber);
                // Console.WriteLine(randomType);
                return randomType;
            }
        }
        
    }
}
