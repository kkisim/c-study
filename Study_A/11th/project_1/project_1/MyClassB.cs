using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class MyClassB
    {
        private int myField; //필드 (변수)
        public int GetMyField() //프로퍼티 (속성)
        {
            return myField;
        }
        public void SetMyField(int Newvalue) //프로퍼티 (속성)
        {
            myField = Newvalue;
        }
    }
}
