using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("월을 입력하세요 ");
            int month = int.Parse(Console.ReadLine());
            if (month >= 3 && month <= 5)
            {
                Console.WriteLine(" 봄입니다.");
            }
            else if (month >= 6 && month <= 8)
            {
                Console.WriteLine(" 여름입니다.");
            }
            else if (month >= 9 && month <= 11)
            {
                Console.WriteLine(" 가을입니다.");
            }
            else if (month == 12 || month >= 1 )
            {
                Console.WriteLine(" 겨울입니다.");
            }
            else
            {
                Console.WriteLine(" 잘못된 입력입니다.");
            }
        }
    }
}
