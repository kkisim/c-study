using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            //product.name = "사과";
            //product.price = 1000;

            Product product1 = new Product() { name = "사과", price = 1000 }; //초깃값 할당 가능
            Product product2 = new Product() { name = "토마토", price = 2000 };
            Product product3 = new Product();
            Product product4 = new Product();

            int[] intArrary = new int[3] { 1, 2, 3 };

            Console.WriteLine(product1.name + " :" + product1.price + "원");
            Console.WriteLine(product2.name + " :" + product2.price + "원");
            Console.WriteLine($"{product1.name} : {product1.price}원");
            Console.WriteLine("{0} :{1}원",product1.name,product1.price);

            Cat Kitty = new Cat("키티", "흰색");
            Kitty.Meow();
            Console.WriteLine("{0} : {1}", Kitty.Name, Kitty.Color);
            Console.WriteLine($"{Kitty.Name} : {Kitty.Color}");

            Cat nero = new Cat("네로", "검정색");
            nero.Meow();
            Console.WriteLine("{0} : {1}", nero.Name, nero.Color);
            Console.WriteLine($"{nero.Name} : {nero.Color}");

        }
    }
}
