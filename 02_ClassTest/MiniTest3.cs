using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest._02_ClassTest
{
    internal class MiniTest3
    {
        public static void main(string[] args)
        {

            string[] pokemonNames = { "リザードン", "カメックス", "フシギバナ",
                                  "ラプラス", "カビゴン", "ピカチュウ"};

            Console.WriteLine("手持ちのポケモンは");
            for (int i = 0; i < pokemonNames.Length; i++)
            {
                Console.WriteLine(pokemonNames[i]);
            }

            int get = 0;
            Random rm = new Random();
            get = rm.Next(pokemonNames.Length);

            Console.WriteLine("いけ ! " + pokemonNames[get] + " !");
        }
    }
}
