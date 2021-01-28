using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Class1 cls1 = new Class1();
        private int numPriate = 12;
        public int numPublic = 12;
        // enumの定義
        private enum Days
        {
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat = 11,
            Sun
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Days day = Days.Wed;
            string arg_day;
            string dayName = day.ToString();

            switch (day)
            {
                case Days.Mon:
                case Days.Tue:
                case Days.Wed:
                case Days.Thu:
                case Days.Fri:
                    arg_day= dayName;
                    Console.WriteLine("平日です");
                    break;
                case Days.Sat:
                case Days.Sun:
                    arg_day = "休日です";

                    Console.WriteLine("休日です");
                    break;
                default:
                    arg_day = "不正です";

                    Console.WriteLine("不正です");
                    break;
            }



            String num = Count(numPriate);
            label1.Text = num;
            String arg = cls1.SaySomething();
            label2.Text = arg + arg_day;
        }
        public String Count(int max)
        { // Control Flow Example
            int max2 = cls1.CalcReturn(max);
            String numbers = "";
            if (max2 < 1) return numbers;
            for (int loop = 1; loop <= max2; loop++)
            {
                numbers = numbers + loop + " ";
                if ((loop % 10) == 0)
                    numbers = numbers + "\r\n";
            }
            return numbers;
        }
    }
    
}

