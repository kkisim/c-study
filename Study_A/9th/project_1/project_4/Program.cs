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
            Random random = new Random();
            Console.WriteLine(random.Next());

            Console.WriteLine(random.Next(1, 10)); // 1~9까지의 랜덤한 수
            Console.WriteLine(random.NextDouble()); // 0.0~1.0까지의 랜덤한 수
            Console.WriteLine(random.Next(1, 10) + random.NextDouble()); // 1.0~9.99999까지의 랜덤한 수


            //list 클래스
            List<int> list = new List<int>() { 52, 85, 273, 64 };
            list.Add(100); //리스트에 100 추가
            list.Remove(100); //리스트에서 100 삭제
            list.RemoveAt(0); //리스트에서 0번째 인덱스 삭제

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            //Math 클래스
            Console.WriteLine(Math.Abs(-10)); //절대값
            Console.WriteLine(Math.Ceiling(1.2)); //올림
            Console.WriteLine(Math.Floor(1.2)); //내림
            Console.WriteLine(Math.Round(1.2)); //반올림
            Console.WriteLine(Math.Max(1, 2)); //최대값
            Console.WriteLine(Math.Min(1, 2)); //최소값
            Console.WriteLine(Math.Pow(2, 3)); //2의 3제곱
            Console.WriteLine(Math.Sqrt(4)); //제곱근
            Console.WriteLine(Math.PI); //파이값

        }
    }
}
