using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin_12
{
    internal class Program

    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            //값 복사(value copy)와 참조 복사(reference copy)
            //값 복사와 참조 복사는 메모리와 동작 방식에서 중요한 차이를 보이며, 프로그램의 동작과 성능에 큰 영향을 미친다.


            //① 값 타입 복사
            //값 타입 : int, float, double, char struct 등
            // 서로 독립적인 값을 가지게 된다.
            int x = 10;
            int y = 10;
            y = 20; // y의 값을 변경해도 x는 영향을 받지 않는다.
            Console.WriteLine($"x: {x}, y: {y}"); // x: 10, y: 20

            //② 참조 타입 복사
            //참조 타입 : class, array, string 등
            Person person1 = new Person();
            person1.Name = "Alice";
            Person person2 = person1; // person2는 person1을 참조
            Console.WriteLine(person1.Name); // Alice
            Console.WriteLine(person2.Name); // Alice

            //메서드 오버로딩

            //메서드 오버로딩은 같은 이름의 메서드를 매개변수의 타입이나 개수에 따라 다르게 정의하는 것이다.
            //예를 들어, 두 개의 정수를 더하는 메서드와 두 개의 문자열을 연결하는 메서드를 같은 이름으로 정의할 수 있다.
            int Add(int a, int b)
            {
                return a + b;
            }
            string Add(string a, string b)
            {
                return a + b;
            }
            //메서드 오버로딩을 사용하면 코드의 가독성을 높이고, 같은 기능을 수행하는 메서드를 명확하게 구분할 수 있다.

        }
    }
}
