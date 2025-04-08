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
            //C#에서 문자열 서식화에 사용할 숫 있는 방법 두 가지
            //1. String.Format() 메서드
            //2. 문자열 보간
            Console.WriteLine("Total: {0}", 456);
            Console.WriteLine("Total: {0, -10:D}", 456);
            Console.WriteLine("Total: {0, 10:D}",456);
            Console.WriteLine("Total: {0,10:X}", 456);
            Console.WriteLine("Total: {0:N}", 456);
            Console.WriteLine("Total: {0:N0}", 456);
            Console.WriteLine("Total: {0:F}", 456.789);

        }
    }
}
