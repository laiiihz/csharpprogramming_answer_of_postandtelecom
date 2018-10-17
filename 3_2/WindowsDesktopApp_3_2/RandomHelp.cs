using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDesktopApp_3_2
{
    
    class RandomHelp
    {
        public static int GetIntRandomNumber(int minNum,int maxNum)
        {
            long time=DateTime.Now.Ticks;
            Random random = new Random((int)time);
            return random.Next(minNum,maxNum);
        }
        public static double GetDoubleRandomNumber(int minNum,int maxNum)
        {
            long time = DateTime.Now.Ticks;
            Random random = new Random((int)time);
            maxNum = maxNum * 1000;
            double randomNum = random.Next(minNum, maxNum);
            return randomNum / 1000;
        }
    }
}
