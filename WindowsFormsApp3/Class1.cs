using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp3
{
    class Class1
    {
        public String SaySomething()
        {
            int numReturn = CalcSomething(20);
            return "You look nice today\r\n" + numReturn.ToString();
        }

        private int CalcSomething(int num)
        {
            return num * 2;
        }

        public int CalcReturn(int num)
        {
            return CalcSomething(num);
        }
    }
}
