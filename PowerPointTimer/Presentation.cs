using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPointTimer
{
    public class Presentation
    {
        public string Path { set; get; }
        public int Hour { set; get; }
        public int Minute { set; get; }
        public int Second { set; get; }

        public Presentation()
        {
            Minute = 5;
        }

        public Presentation(string path, int hour, int minute, int second)
        {
            Path = path;
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Length()
        {
            return Hour * 3600 + Minute * 60 + Second;
        }
    }
}
