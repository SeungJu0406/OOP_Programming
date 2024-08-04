using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest6
{
    public static class Util
    {
        static Random random = new Random();
        public static int Random(int a, int b)
        {
            return random.Next(a, b + 1);
        }
    }
}
