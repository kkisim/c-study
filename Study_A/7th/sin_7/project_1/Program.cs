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
            //출생 연도에 따른 띠 알아보기
            //띠 : 12시간에 따라 계산하면 된다.
            //"쥐" , "소", "호랑이", "토끼", "용", "뱀", "말", "양", "원숭이", "닭", "개", "돼지"
            //12자간 배열(기준년도 : 2008년 쥐띠, 2008 % 12 = 4)

            //int a = 2008;
            //int b = 12;
            //int remainder = a% b;
            //Console.WriteLine(remainder);//4

            String[] zodiac = {
                "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양", "원숭이", "닭", "개", "돼지"
            };
            Console.WriteLine("출생 연도를 입력하세요");
            String input = Console.ReadLine();

            if (int.TryParse(input, out int year))
            {
                int baseYear = 2008;
                int index = (year - baseYear) % 12;
                if (index < 0)
                {
                    index += 12; // 음수인 경우 12를 더해줌
                }
                //Console.WriteLine("{0}년은 {1}입니다.",year,zodiac[index]);
                Console.WriteLine($"{year}년은 {zodiac[index]}띠입니다.");
            }
            else
            {
                Console.WriteLine("숫자로 입력하세요");
            }
            if (int.TryParse(input, out year))
            {
                Console.WriteLine($"변환 성공! year = {year}");
            }
            else
            {
                Console.WriteLine("변환 실패!");


            }
        }
    }
}
