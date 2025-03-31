namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {   //기본 출력
            Console.WriteLine("Hello, World!");
            Console.WriteLine((5+3)*2);
            Console.WriteLine(7 % 3);
            Console.WriteLine(2 % 3);
            // 나머지 연산자의 부호는 왼쪽 피연산자의 부호를 따르기 때문에 오른쪽 피연산자 부호는 상관이 없다.
            Console.WriteLine(0); //정수
            Console.WriteLine(0.0); //실수
            Console.WriteLine(5.0 % 2.2);
            // 5.0 - (2.2 *2) = 0.6;
            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);
            Console.WriteLine(1.0 / 2.0);

            Console.WriteLine('A');
            Console.WriteLine('가');

            Console.WriteLine("힌빛 \t 아카데미");
            Console.WriteLine("\"\"\"\"");

            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[3]);

            int a = 273;
            int b = 52;
        }
    }
}
