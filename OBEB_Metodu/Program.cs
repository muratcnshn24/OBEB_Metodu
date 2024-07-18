using System;

namespace OBEB_Metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("OBEB({0},{1})= {2}", s1, s2, Matematik.OBEB(s1, s2));
        }
    }
}
