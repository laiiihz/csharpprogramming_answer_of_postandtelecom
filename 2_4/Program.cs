using System;

namespace windowsConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入带逗号的5个数：");
            string get_string=Console.ReadLine();
            string[] get_string_parse=get_string.Split(',');
            int[] get_int=new int[5];
            for(int i=0;i<5;i++){
                get_int[i]=int.Parse(get_string_parse[i]);
            }
            Array.Sort(get_int);
            Console.Write("正序：");
            for (int i = 0; i <5; i++)
            {
                if(i!=4)
                Console.Write($"{get_int[i]},");
                else Console.Write($"{get_int[i]}");
            }
            int max_num=get_int[4];
            Console.WriteLine(" ");
            Array.Reverse(get_int);
            for (int i = 0; i <5; i++)
            {
                if(i!=4)
                Console.Write($"{get_int[i]},");
                else Console.Write($"{get_int[i]}");
            }
            double average=0;
            foreach (int a in get_int)
            {
                average+=a;
            }
            average/=5;
            Console.WriteLine(" ");
            Console.WriteLine($"average:{average}");
            Console.WriteLine($"max:{max_num}");
        }
    }
}
