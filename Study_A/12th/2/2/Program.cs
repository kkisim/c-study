using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //메서드 오버로딩
            //오버로딩은 같은 이름의 메서드를 여러 개 정의하는 것
            //이름과 매개변수를 가지고 프로토타입을 구분함

            //int
            Console.WriteLine(Mymath.Abs(-10));
            //double
            Console.WriteLine(Mymath.Abs(-10.5));
            //long
            Console.WriteLine(Mymath.Abs(-10000000000L));

            Console.WriteLine(MainApp.Plus(10, 20));
            Console.WriteLine(MainApp.Plus(10.5, 20.5));
        }
    }
}
