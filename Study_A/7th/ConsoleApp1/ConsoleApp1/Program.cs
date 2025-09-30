using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int cm = int.Parse(Console.ReadLine());
            //double inch = cm * 2.54;
            //Console.WriteLine(inch);
            //Console.WriteLine("이름를 입력하세요 : ");
            //String name = Console.ReadLine();
            //Console.WriteLine("나이을 입력하세요 : ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{name}님의 나이는 {age+5}입니다.");

            //Console.WriteLine("반지름을 입력하세요 ");
            //int r = int.Parse(Console.ReadLine());
            //Console.WriteLine($"원의 넓이는 {Math.PI * r * r}이고  원의 둘레는 {2 * Math.PI}");

            //Console.WriteLine("나이를 입력하세요");
            //int age = int.Parse(Console.ReadLine());

            //if(age > 19)
            //{
            //    Console.WriteLine("성인");
            //}
            //else
            //{
            //    Console.WriteLine("미성년자");
            //}

            //Console.WriteLine("정수를 입력하세요");
            //int num = int.Parse(Console.ReadLine());
            //if(num % 3 == 0)
            //{
            //    Console.WriteLine("3의 배수입니다");
            //}else
            //{
            //    Console.WriteLine("3의 배수가 아닙니다");
            //}
            //Console.WriteLine("정수를 입력하세요");
            //int year = int.Parse(Console.ReadLine());
            //switch (year % 12)
            //{
            //    case 0:
            //        Console.WriteLine("원숭이띠");
            //        break;
            //    case 1:
            //        Console.WriteLine("닭띠");
            //        break;
            //    case 2:
            //        Console.WriteLine("개띠");
            //        break;
            //    case 3:
            //        Console.WriteLine("돼지띠");
            //        break;
            //    case 4:
            //        Console.WriteLine("쥐띠");
            //        break;
            //    case 5:
            //        Console.WriteLine("소띠");
            //        break;
            //    case 6:
            //        Console.WriteLine("호랑이띠");
            //        break;
            //    case 7:
            //        Console.WriteLine("토끼띠");
            //        break;
            //    case 8:
            //        Console.WriteLine("용띠");
            //        break;
            //    case 9:
            //        Console.WriteLine("뱀띠");
            //        break;
            //    case 10:
            //        Console.WriteLine("말띠");
            //        break;
            //    case 11:
            //        Console.WriteLine("양띠");
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 입력입니다.");
            //        break;


            //}
            //Console.WriteLine("정수를 입력하세요");
            //int month = int.Parse(Console.ReadLine());
            //if(month > 2  && month <4) {
            //    Console.WriteLine("봄입니다");
            //}
            //else if (month > 5 && month < 8)
            //{
            //    Console.WriteLine("여름입니다");
            //}
            //else if (month > 8 && month < 11)
            //{
            //    Console.WriteLine("가을입니다");
            //}
            //else if (month == 12 || month == 1 || month == 2)
            //{
            //    Console.WriteLine("겨울입니다");
            //}
            //else
            //{
            //    Console.WriteLine("잘못된 입력입니다.");
            //}
            //int milk = 0;
            //bool egg = true;

            //if (egg)
            //{
            //    milk = 6;
            //    Console.WriteLine(milk);
            //}
            //else
            //{
            //    milk = 1;
            //    Console.WriteLine(milk);
            //}
            //int i = 0;
            //while(i < 10)
            //{   
            //    Console.Write(i);
            //    i++;
            //}
            //int sum = 0;
            //for(int i = 1; i <= 100; i++)
            //{
            //    sum += i;

            //}
            //Console.Write(sum);
            //int i = 0;
            //do
            //{
            //    if(i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //} while(i < 10);

            //for(int i = 0; i <8; i++)
            //{
            //    for (int j = 0; j < 8-i; j++)
            //    {
            //        Console.Write(" ");

            //    }
            //    for(int k = 0; k < i * 2 + 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////다음과 같이 5개의 수를 입력받아, 가장 작은 수고  가장 큰 수를 출력하는 프로그램을 작성하시오.
            //int[] arr = new int[5];
            //int max = int.MinValue;
            //int min = int.MaxValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("숫자를 입력해주세요 :");
            //    arr[i] = int.Parse(Console.ReadLine());

            //}
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"최대값 : {max}");
            //Console.WriteLine($"최소값 : {min}");

            //읽고말하기수열 규칙 만들고 20번째 숫자를 찾기
            //int[] arr = new int[20];
            //int num = 1;
            //int count = 1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        arr[i] = num;
            //    }
            //    else
            //    {
            //        if (arr[i - 1] == num)
            //        {
            //            count++;
            //        }
            //        else
            //        {
            //            arr[i] = count;
            //            num = arr[i - 1];
            //            count = 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            int[] numbers = { 47, 87, 26, 65, 12, 98, 34, 56, 77, 19 };

            //Min() Max() SUM() Average() 등의 함수를 사용할수 있다 이함수들을 직접 활용해서 사용자로 부터 5개의 숫자를 
            //입력받고 가장작은수와 큰수를 포함해 합계와 평균을 출력하는 코드를 작성해라
            int[] arr = new int[5];
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("숫자를 입력해주세요 :");
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            avg = (double)sum / arr.Length;
            Console.WriteLine($"최대값 : {max}");
            Console.WriteLine($"최소값 : {min}");
            Console.WriteLine($"합계 : {sum}");




        }
    }
}