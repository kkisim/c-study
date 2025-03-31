using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project_1
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
       
        static void Main()
        {
            System.Console.WriteLine(445);
            Console.WriteLine('a');
            Console.WriteLine("System");
            Console.WriteLine();
            Console.WriteLine(10 + 20 + 30);
            Console.WriteLine("10" + "20" + "30");


            //복합대입 연산자
            int input = 0;

            input += 52;

            //증감 연산자
            int num = 10;
            num++;
            Console.WriteLine(num); //11
            num--;
            Console.WriteLine(num); //10
            Console.WriteLine();

            Console.WriteLine(num++); //10 - 출력 후 증가
            Console.WriteLine(num++); //11 - 출력 후 증가
            Console.WriteLine(++num); //13 - 증가 후 출력
            Console.WriteLine(--num); //12 - 감소 후 출력
            Console.WriteLine();

            int _int = 273;
            long _long = 522731033265L;
            float _float = 52.273f;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";
            Console.WriteLine();

            Console.WriteLine(_int.GetType());
            Console.WriteLine("문자열".GetType());

        }
    }
}
