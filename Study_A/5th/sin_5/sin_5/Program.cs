using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("이름 입력 : ");
            //String name = Console.ReadLine();

            //Console.WriteLine("나이 입력 : ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("5년 후의 나이는 "+(age + 5)+"살입니다");
            //Console.WriteLine("이름은 " + name + "이고 나이는 " + age + "살입니다");
            //Console.WriteLine("이름은 {0}이고 나이는 {1}살입니다", name, age);

            Console.WriteLine("원의 반지름 입력 : ");
            double radius = double.Parse(Console.ReadLine());
            double area = radius * radius * Math.PI;
            double circumference = 2 * radius * Math.PI;
            Console.WriteLine("원의 넓이는 " + area + "이고 원의 둘레는 " + circumference + "입니다");
            Console.WriteLine("원의 둘레 : {0}, 원의 넓이 : {1}", circumference, area);
            Console.WriteLine("원의 둘레 : "+(2 * radius * Math.PI) + ", 원의 넓이 : " + (radius * radius * Math.PI));


        }
    }
}
