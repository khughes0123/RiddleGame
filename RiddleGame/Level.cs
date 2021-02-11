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
        
        public string Clue { get; set; }
        public string Outro { get; set; }
        public List<string> NextLevel { get; }

       

        
        public Level() { }
        public Level(int levelNum,string name, string intro, string riddle, string answer, string clue, string outro, List<string> nextlevel)
        {
            LevelNum = levelNum;
            
            Name = name;
            Intro = intro;
            Riddle = riddle;
            Answer = answer;
            Clue = clue;
            Outro = outro;
            NextLevel = nextlevel;
            
        }
    }
}
