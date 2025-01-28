using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest._02_ClassTest
{
    class MiniTest1
    {

        public static void main(string[] args)
        {
            int hito = 2;
            int other = 99;

            sentakuIf(hito);
            sentakuIf(other);
        }

        //解答1
        public static void sentakuIf(int num)
        {
            Console.Write(num + "は");
            if (num == 1)
            {
                Console.WriteLine("フシギダネ");
            }
            else if (num == 2)
            {
                Console.WriteLine("ヒトカゲ");
            }
            else if (num == 3)
            {
                Console.WriteLine("ゼニガメ");
            }
            else
            {
                Console.WriteLine("ピカチュウ");
            }
        }

        //解答2
        public static void sentakuSwitch(int num)
        {

            Console.Write(num + "は");
            switch (num)
            {
                case 1:
                    Console.WriteLine("フシギダネ");
                    break;
                case 2:
                    Console.WriteLine("ヒトカゲ");
                    break;
                case 3:
                    Console.WriteLine("ゼニガメ");
                    break;
                default:
                    Console.WriteLine("ピカチュウ");
                    break;
            }
        }
    }
}
