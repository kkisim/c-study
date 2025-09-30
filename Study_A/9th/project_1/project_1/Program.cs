using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{   //클래스위치 세가지
    //1 하나의 파일에 여러개의 클래스생성
    class Product
    {
        public string name; //필드(변수)
        public int price;
    }
    class Cat
    {
        public string Name; //필드(변수)
        public string Color;
        public Cat (string name, string color) //생성자
        {
            this.Name = name;
            this.Color = color;
        }
        public void Meow() //메서드(함수)
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
