using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.LastTest
{
    internal class LTest01
    {

        public static void main(string[] args)
        {
            int south = 2;
            int central = 100;

            fourSymbols(south);
            fourSymbols(central);
        }

        static void fourSymbols(int num)
        {
            string hougaku;
            string symbol;

            switch (num)
            {

                case 0:
                    hougaku = "東";
                    symbol = "青龍";
                    break;

                case 1:
                    hougaku = "西";
                    symbol = "白虎";
                    break;

                case 2:
                    hougaku = "南";
                    symbol = "朱雀";
                    break;

                case 3:
                    hougaku = "北";
                    symbol = "玄武";
                    break;

                default:
                    hougaku = "中央";
                    symbol = "麒麟";
                    break;
            }
            Console.WriteLine(num + "は" + hougaku + "/" + symbol);
        }
    }
}
