using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("나이 입력 : ");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 18)
            //{
            //    Console.WriteLine("성인입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("미성년자입니다.");
            //}
            //Console.WriteLine("숫자입력 : ");
            //int input = int.Parse(Console.ReadLine());
            //if(input % 2 == 0)
            //{
            //    Console.WriteLine("짝수입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("홀수입니다.");
            //}
            String input = Console.ReadLine();
            int num = int.Parse(input);

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? true : false);
            Console.WriteLine(number % 2 == 0 ? "짝수입니다." : "홀수입니다.");
        }
    }
}
