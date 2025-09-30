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
        {MyClassA objA = new MyClassA();
            objA.myField = 10; //필드에 직접 접근
            Console.WriteLine(objA.myField); //10
            MyClassB objB = new MyClassB();
            objB.SetMyField(20); //SetMyField 메서드를 통해 필드에 값 설정
            Console.WriteLine(objB.GetMyField()); //20
            MyClassC objC = new MyClassC();
            objC.MyField = 30; //프로퍼티를 통해 필드에 값 설정
            Console.WriteLine(objC.MyField); //30
            MyClassD objD = new MyClassD();
            objD.MyField = 40; //자동 구현 프로퍼티를 통해 필드에 값 설정
            Console.WriteLine(objD.MyField); //40
        }
        
    }
}
