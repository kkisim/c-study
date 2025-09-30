using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class MyClassC

    {   
        //일반적인 속성 생성 방법
        private int myField; //필드 (변수)
        public int MyField //프로퍼티 (속성)
        {
            get { return myField; }
            set { myField = value; } //value는 set 접근자의 암묵적 매개변수로 간주

        }
    }
}
