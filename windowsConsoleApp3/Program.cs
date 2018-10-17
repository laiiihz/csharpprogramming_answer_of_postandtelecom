using System;

namespace windowsConsoleApp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string get_string;
            Console.Write("请输入一个大于100的数：");
            get_string=Console.ReadLine();
            Console.WriteLine($"该整数共有{get_string}个数");
            long get_int=Convert.ToInt32(get_string);
            if(get_int<100)return ;
            char[] get_chars=get_string.ToCharArray();
            Console.WriteLine("实现1：");
            for(int i=0;i<get_string.Length;i++){
                Console.Write(get_chars[i]);
            }
            int[] get_ints=new int[get_string.Length];
            for(int i=0;i<get_string.Length;i++){
                get_ints[i]=(Int32)(get_int%10);
                get_int=get_int/10;
            }
            Console.WriteLine(" ");
            Console.WriteLine("实现2");
            int size= get_string.Length-1;
            for (int i =size; i >=0; i--)
            {
                Console.Write(get_ints[i]);
            }
            Console.WriteLine(" ");
            int sum1=0;
            int sum2=0;
            for (int q = 0; q <get_string.Length; q++)
            {
                sum1+=int.Parse(get_chars[q].ToString());
                sum2+=get_ints[q];
            }
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);


        }
    }
}
