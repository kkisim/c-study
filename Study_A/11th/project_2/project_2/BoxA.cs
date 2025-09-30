using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class BoxA

    {   //캡슐화
        //클래스 내부에서 만 접근이 가능
        private int width;
        private int height;

        public int Area()
        {
            return this.width * this.height;
        }

        public BoxA(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
