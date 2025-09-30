using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Dog
    {

        public Dog() { }
        public int Age { get; set; }
        public string Color { get; set; }
        public dog() { this.Age = 0; this.Color = "white"; }
        public void Eat ()
        {
            Console.WriteLine("먹는다");
        }
        public void Bark()
        {
            Console.WriteLine("짖는다");
        }
        public void Sleep()
        {
            Console.WriteLine("잔다");
        }
    }
}
