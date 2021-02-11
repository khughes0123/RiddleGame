using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{

    public class ProgramUI
    {
/*        Dictionary<string, string> Levels = new Dictionary<string, string>
        {
            { "forest", "What is black and white and 'red' all over?"  },
            { "river", "What gets wet while drying?" },
            {"cave", "What five letter word becomes shorter when you add two letters to it?" },
            {"afterlife", "the jig is up" }
        };*/


        // List<Level> levels = new List<Level>();


        public static Level forest = new Level(0, "Forest", "you are in the forest, the gopher has a question for you?\n", "What's black and white and \"red\" all over", "newspaper", "not quite, try again!", "Nice job! You're on your way to the river", new List<string> { "newspaper" });

        public static Level river = new Level(1, "River", "you have reached the river, congratulations, the scorpion will take you across if you can answer him a question\n", "What gets wet while drying?", "towel", "man, I feel like a shower...", "You're on a roll! Dry off and make your way to the cave", new List<string> { "towel" });

        public static Level cave = new Level(2,"Cave", "You have crossed the river and entered the cave.  The badger has your next test.\n", "What five letter word becomes shorter when you add two letters to it?", "short", "you must look within to find the answers", "Correctamundo! Now see what awaits you in the jungle...", new List<string> { "short" });

        public static Level jungle = new Level(3, "Jungle", "Welcome to the jungle, baby!! The panther will guide you through, but proceed with caution.\n", "What has to be broken before you can use it?", "egg", "You're close to 'cracking' the case.", "Right you are! Make your way out of the jungle and onto the beach.", new List<string> { "egg" });

        public static Level beach = new Level(4,"Beach", "Life's a beach, a friendly crab will lead you to safety if you can answer his question.\n", "I speak without a mouth and hear without ears. I have no body, but I come alive with wind.", "echo", "I speak without a mouth and hear without ears. I have no body, but I come alive with wind.", " Woo hoo! You did it!! You have made it to the legendary......",new List<string> { "echo" });
        
        public static Level finish = new Level(5, "Finish Land", "\n\nLAND OF FINISHERS!\n\n\n", "....You are free to roam as you please BUT TOUCH NOTHING BUT THE LAMP!! jk", "", "","", new List<string> { "" });

        List<Level> ListOfLevels = new List<Level> { forest, river, cave, jungle, beach, finish };

        
        public void Run()
        {
            
            Level currentLevel = ListOfLevels[0];
            

            Console.WriteLine("You have entered the land or riddles! \n" +
                "You must answer 5 riddles to succesfully navigate into the forest, over the river, out of the cave, through the jungle, and off of the beach. \n "+
                "But beware you only have two tries to successfully answer each riddle or you stay forever!");
            Console.ReadKey();
            Console.Clear();
            

            bool alive = true;
            while (alive)

            {
                
                Console.WriteLine(currentLevel.Intro);
                Console.WriteLine(currentLevel.Riddle);

                string answer = Console.ReadLine().ToLower();


                if (answer.Contains(currentLevel.Answer))
                {
                    Console.WriteLine(currentLevel.Outro);
                    Console.ReadKey();
                    currentLevel = ListOfLevels[currentLevel.LevelNum + 1];
                    Console.WriteLine(currentLevel.Intro);
                    Console.WriteLine(currentLevel.Riddle);
                    Console.Clear();

                }
                else 

                {


                    Console.WriteLine(currentLevel.Clue);
                    answer = Console.ReadLine().ToLower();
                    




                    if (answer.Contains(currentLevel.Answer))
                    {
                        Console.WriteLine(currentLevel.Outro);
                        Console.ReadKey();
                        currentLevel = ListOfLevels[currentLevel.LevelNum + 1];
                        Console.WriteLine(currentLevel.Intro);
                        Console.WriteLine(currentLevel.Riddle);
                        Console.Clear();
                    }



                    else
                    {
                        alive = false;
                        Console.WriteLine("YOU... SHALL NOT...... PAASSSSSSS!!!! ");
                        Console.ReadKey();
                        break;
                    }


                }
            }
        }
    }

}





//    Console.WriteLine("You have failed.  Enjoy the afterlife!");

//}


//while (alive)
//{

//    Console.WriteLine(currentLevel.Intro);
//    Console.WriteLine(currentLevel.Riddle);

//    string answer = Console.ReadLine().ToLower();

//    if (answer.Contains("towel"))
//    {
//        Console.WriteLine("Correct!  I will take you across the river!  You must now enter the cave.");
//        currentLevel = cave;
//        Console.ReadKey();
//        Console.Clear();


//    }
//    else if (answer != ("towel"))
//    {
//        Console.WriteLine("you are incorrect, you have one more attempt");
//        Console.ReadLine().ToLower();
//        lives--;
//    }
//    else
//    {

//        Console.WriteLine("You have failed.  Enjoy the afterlife!");
//        break;
//    }
//}

//while (alive)
//{
//    Console.WriteLine(currentLevel.Intro);
//    Console.WriteLine(currentLevel.Riddle);

//    string answer = Console.ReadLine().ToLower();



//    if (answer.Contains("short"))
//    {
//        Console.WriteLine("Correct!  You have reached Finish Land!  You are free to travel where you like!");
//        currentLevel = finishland;
//        Console.ReadKey();
//        break;

//    }


//    else if (answer != ("short"))
//    {
//        Console.WriteLine("you are incorrect, you have one more attempt");
//        currentLevel = secondchance;
//        alive = true;

//    }
//    else
//    {

//        Console.WriteLine("You have failed.  Enjoy the afterlife!");
//        break;
//    }
//}
//            }
//        }
//    }
//}







