using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Cat
    {
        public string Name; //필드(변수)
        public string Color;
        public Cat(string name, string color) //생성자
        {
            this.Name = name;
            this.Color = color;
        }
        public void Meow() //메서드(함수)
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
}
