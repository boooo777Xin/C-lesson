using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest._02_ClassTest
{
     class MiniTest2
    {

        public static void main(string[] args)
        {

            midarezukiBot(0);
            midarezukiBot(5);
        }

        public static void midarezukiBot(int dosu)
        {
            if ((dosu == 0) || (dosu >= 6))
            {
                Console.WriteLine("うまく 決まらなかった!!");
            }
            else
            {
                for (int i = 1; i <= dosu; i++)
                {
                    Console.Write("ツン ");
                }
                Console.WriteLine("\n" + dosu + "回 当たった !!");
            }
        }
    }
}
