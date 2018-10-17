using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDesktopApp_3_1
{
    public static class GlobalNums
    {
        private static int counter = 0;

        public static int Counter { get => counter; set => counter = value; }
    }
}
