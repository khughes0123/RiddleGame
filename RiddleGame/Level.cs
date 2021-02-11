using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{
    public class Level
    {
        public int LevelNum { get; set; }
        public string Name { get; }
        public string Intro { get; set; }
        public string Riddle { get; }
        public string Answer { get; set; }

        public List<string> NextLevel { get; }


        public Level() { }
        public Level(int levelNum, string name, string intro, string riddle, string answer, List<string> nextlevel)
        {
            LevelNum = levelNum;
            Name = name;
            Intro = intro;
            Riddle = riddle;
            Answer = answer;
            NextLevel = nextlevel;
        }
    }
}
