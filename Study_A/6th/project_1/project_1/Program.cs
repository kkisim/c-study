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
            //배열 : 같은 데이터 타입을 가진 데이터들의 집합(고정)
            int[] alpha = new int[3] { 11, 22,  33 };
            //int [] alpha = new int[] {11,22, 33 };
            //int [] alpha = {11,22, 33 };

            foreach (int i in alpha)
            {
                Console.WriteLine(i);
            }
            //리스트   : 같은 데이터 타입을 가진 데이터들의 집합(가변)
            //List<int> beta = new List<int>();//<> 일반화 하다 자바는 Integer 사용
            //beta.Add(11);
            //beta.Add(22);
            //beta.Add(33);
            List<int> beta = new List<int>() { 11, 22, 33 };
            beta.Add(44);
            beta.Add(55);
            //추가 가능
            foreach (int i in beta)
            {
                Console.WriteLine(i);
            }
            beta.Remove(11);
            beta.RemoveAt(2); //인덱스 2에 있는 데이터 삭제
            beta.Insert(0, 99); //인덱스 0에 99 삽입

            //List<int> beta = new List<int>(new int[] { 11, 22, 33 });


        }
    }
}
