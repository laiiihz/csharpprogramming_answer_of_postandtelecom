using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDesktopApp4_1
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string phone { get; set; }
        public string Print()
        {
            string result = name +"\t\t"+ age +"\t\t"+ phone;
            return result;
        }
    }
}
