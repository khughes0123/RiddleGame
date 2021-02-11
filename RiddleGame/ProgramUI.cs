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


        public static Level forest = new Level(0, "Forest", "you are in the forest, the gopher has a question for you?", "What's black and white and \"red\" all over", "newspaper", new List<string> { "newspaper" });

        public static Level river = new Level(1, "River", "you have reached the river, congratulations, the scorpion will take you across if you can answer him a question", "What gets wet while drying?", "towel", new List<string> { "towel" });

        public static Level cave = new Level(2, "Cave", "You have crossed the river and entered the cave.  The badger has your final test, answer carefully", "What five letter word becomes shorter when you add two letters to it?", "short", new List<string> { "short" });
        public static Level finish = new Level(3, "Finish Land", "You have reached Finish Land!", "You are free to roam as you please but touch nothing but the lamp!! (jk)", "", new List<string> { "" });

        List<Level> ListOfLevels = new List<Level> { forest, river, cave, finish };



        public void Run()
        {
            Level currentLevel = ListOfLevels[0];
            Console.Clear();
            Console.WriteLine("You have entered the land or riddles!  You must answer 3 riddles to succesfully navigate through the forest, over the river, and out of the cave!  But beware you only get two tries or you die!");


            bool alive = true;
            while (alive)

            {
                Console.WriteLine(currentLevel.Intro);
                Console.WriteLine(currentLevel.Riddle);

                string answer = Console.ReadLine().ToLower();


                if (answer.Contains(currentLevel.Answer))
                {
                    currentLevel = ListOfLevels[currentLevel.LevelNum + 1];
                    Console.WriteLine(currentLevel.Intro);
                    Console.WriteLine(currentLevel.Riddle);
                    Console.Clear();

                }
                else 

                {


                    Console.WriteLine("you are incorrect, you have one more attempt");
                    answer = Console.ReadLine().ToLower();
                    

                    

                    if (answer.Contains(currentLevel.Answer))
                    {
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







