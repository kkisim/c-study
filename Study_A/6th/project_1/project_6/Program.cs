using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //별 피라미드 찍기

            for(int i = 0; i < 8; i++)
            {
                for (int j = 7; j >i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < 2 * i + 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
