using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        delegate int MyDelegate(int x, int y);
        class Calculator
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Subtract(int x, int y)
            {
                return x - y;
            }
        }
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate Callback; //델리게이트(대리자) 인스턴스

            Callback = new MyDelegate(calc.Add); //Add 메서드를 대리자에 할당
            int result = Callback(10, 20); //대리자를 호출

            Console.WriteLine("Add Result: " + result); //결과 출력
            Callback = new MyDelegate(calc.Subtract); //Subtract 메서드를 대리자에 할당
            result = Callback(20, 10); //대리자를 호출
            Console.WriteLine("Subtract Result: " + result); //결과 출력
            // 대리자를 람다식으로 할당
            Callback = (x, y) => x * y; //곱셈을 수행하는 람다식
            result = Callback(10, 20); //대리자를 호출
            Console.WriteLine("Multiply Result: " + result); //결과 출력
            // 대리자를 익명 메서드로 할당
            Callback = delegate (int x, int y) { return x / y; }; //나눗셈을 수행하는 익명 메서드
            result = Callback(20, 10); //대리자를 호출
            Console.WriteLine("Divide Result: " + result); //결과 출력


        }
    }
}
