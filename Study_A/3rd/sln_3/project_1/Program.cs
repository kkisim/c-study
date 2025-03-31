//네임 스페이스 영역
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(273.125.GetType());

            //var 키워드 : 변수의 자료형을 자동으로 지정
            //var 키워드 사용 조건
            //1. 지역변수 : 메서드 내부에 선언되어 있는 변수
            //2. 변수 선언과 동시에 초기화 수행

            //var num1 = 100; //int 자료형
            //var num2 = 100.0; //double 자료형
            //var num3 = 100.0f; //float 자료형
            //var num4 = 100L; //long 자료형

            ////입력
            //String input1 = Console.ReadLine(); //입력받기
            //Console.WriteLine(input1 + input1);
            //Console.WriteLine("input1 :" + input1); //문자열 연결 연산자
            //Console.WriteLine("input1 : {}",input1); //String 형식의 format 문자열
            //Console.WriteLine($"input1 : {input1}"); //문자열 보간

            //자료형 변환
            // 1. 강제 자료형 변환
            //var a1 = 10.5;
            //var a2 = (int)a1; //실수형을 정수형으로 변환
            //var a3 = (double)a2; //정수형을 실수형으로 변환

            //Console.WriteLine(a1);
            //Console.WriteLine(a2);
            //Console.WriteLine(a3);

            ////2. 문자열을 숫자로 변환
            //String numstring = "82273";
            //int num = int.Parse(numstring);

            //Console.WriteLine(int.Parse("52"));
            //Console.WriteLine(float.Parse("52.273")); //실행 오류

            //Console.WriteLine(int.Parse("52").GetType()); 

            //3. 기본 자료형을 문자열로 변환
            //Console.WriteLine((52).ToString());
            //Console.WriteLine((52.273).ToString());
            //13번 문제
            String input =  Console.ReadLine();
            Console.WriteLine(double.Parse(input)*2.54);

            Console.WriteLine(52 +273); 
            Console.WriteLine("52" + 273);  //문자연결 연산자
            Console.WriteLine("52" + "273"); //문자연결 연산자

            //소숫점 제거
            double
        }
    }
}
