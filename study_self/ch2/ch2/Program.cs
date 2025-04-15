using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //표현식
            //273
            //10+20+30*2
            //c#도 코드 문장 마지막에 종결의 의미로 세미콜론을 붙인다.
            //statement :프로그래밍에서 실행할 수 있는 최소 단위 코드
            //키워드 : 예약어
            //식별자   : 변수, 메서드, 클래스, 네임스페이스, 열거형, 구조체 등 이름을 붙일 수 있는 것들
            //c#에서 식별자 뒤에 괄호가 있으면 이 식별자를 메서드라고 부른다
            //메서드 : 특정한 기능을 수행하는 코드의 집합

            Console.WriteLine("Hello World!");

            //정수 덧셈 연산자
            Console.WriteLine(10 + 20); //30

            //연산자 우선순위
            //곱셈 연산자 > 덧셈 연산자
            Console.WriteLine(5+3* 2); //11

            //음수와 나머지 연산자
            //나머지 연산자의 부호는 왼쪽 피연산자의 부호를 따름

            //이스케이프 문자
            //\t : tab 
            //\n : 줄바꿈
            // \\ : \
            // \" : "

            //문자열 연결 연산자
            // + : 문자열 연결 연산자
            Console.WriteLine("안녕하세요" + " " + "반갑습니다"); //안녕하세요 반갑습니다
            //문자열 보간
            // $ : 문자열 보간 연산자
            Console.WriteLine($"안녕하세요 {10 + 20}"); //안녕하세요 30

            //불은 참과 거짓을 표현 할 때 사용

            //c#에서 char은 2바이트
            //String 은 클래스다.
            //GETType() : 타입을 확인하는 메서드
            //ToString() : 문자열로 변환하는 메서드
            //var : 타입을 컴파일러가 자동으로 추론하는 키워드

            //입력
            //Console.ReadLine() : 콘솔에서 입력을 받는 메서드


            //숫자와 문자열 덧셈
            //int num = 10;
            //string str = "20";
            //Console.WriteLine(num + str); //10 + 20 = 1020
            //Console.WriteLine(num + int.Parse(str)); //10 + 20 = 30

            Console.Write("나이를 입력하세요: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 19)
            {
                Console.WriteLine("성인");
            }
            else
            {
                Console.WriteLine("미성년자");
            }
            Console.Write("숫자를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0)
            {
                Console.WriteLine("3의 배수입니다.");
            }
            else
            {
                Console.WriteLine("3의 배수가 아닙니다.");
            }
            Console.Write("현재 월을 입력하세요: ");
            int month = int.Parse(Console.ReadLine());

            if (month >= 3 && month <= 5)
            {
                Console.WriteLine("봄");
            }
            else if (month >= 6 && month <= 8)
            {
                Console.WriteLine("여름");
            }
            else if (month >= 9 && month <= 11)
            {
                Console.WriteLine("가을");
            }
            else
            {
                Console.WriteLine("겨울");
            }
            int x = int.Parse(Console.ReadLine());
            string result = (x % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine(result);
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            int i = 1;
            do
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
                i++;
            } while (i <= 10);

        }
    }
}
