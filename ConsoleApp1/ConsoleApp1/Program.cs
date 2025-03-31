// See https://aka.ms/new-console-template for more information

using System; //네임 스페이스 불러오기

namespace ConsoleApp1 //네임스페이스
{
    class Program  //클래스 선언ㅌ
    {
        static void Main(string[] args) //main 메서드 
        {
            //Console.WriteLine("Hello World");
            //bool boolVariable = true;
            //int intVariable = 10;
            //float floatVariable = 3.4F;
            //char charVariable = 'a';

            //Console.WriteLine(boolVariable); //줄바꿈
            //Console.WriteLine(intVariable);
            //Console.WriteLine(floatVariable);
            //Console.WriteLine(charVariable);

            //int num = 0;

            //if (num > 0)
            //{
            //    Console.WriteLine("양수");
            //}
            //else if (num < 0)
            //{
            //    Console.WriteLine("음수");
            //}
            //else
            //{
            //    Console.WriteLine("영");
            //}

            int result, num1, num2;
            result = 3 + 1;
            Console.WriteLine(result);
            result = 3 - 1;
            Console.WriteLine(result);
            num1 = 2;
            result = 5 * num1;
            Console.WriteLine(result);
            num2 = 10;
            result = num2 / 3;
            Console.WriteLine(result);
            result = 10 % 2;
            Console.WriteLine(result);
        }
    }
}
// A == B A와 B가 같다
// A != B A와 B가 같지 않다.
// A > B A가 B보다 크다
// A >= B A가 B보다 크거나 같다
// A < B A가 B보다 작다
// A <= B A가 B보다 작거나 같다.

