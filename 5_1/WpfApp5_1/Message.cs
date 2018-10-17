using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5_1
{
    class Message
    {
        private string name;
        private string basic_msg;
        private string other_msg;
        public string Name { get => name; set => name = value; }
        public string Basic_msg { get => basic_msg; set => basic_msg = value; }
        public string Other_msg { get => other_msg; set => other_msg = value; }
    }
}
