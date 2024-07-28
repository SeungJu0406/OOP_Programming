using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    /// <summary>
    /// 유틸
    /// 랜덤
    /// </summary>
    public static class Util
    {
        private static Random random = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
