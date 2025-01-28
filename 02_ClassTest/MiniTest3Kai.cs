using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest._02_ClassTest
{
    internal class MiniTest3Kai
    {

        public static void main(string[] args)
        {

            //配列を定義、最初に配列の個数を変数に定義
            string[] pokemonNames = { "リザードン", "カメックス", "フシギバナ",
                                  "ラプラス", "カビゴン", "ピカチュウ"};
            int pNamesNum = pokemonNames.Length;

            //配列の中身がなかったときは処理を省く
            if (pNamesNum != 0)
            {
                Console.WriteLine("手持ちのポケモンは");

                //foreach = 配列の中身をすべて使う場合の便利な書き方 
                foreach (string name in pokemonNames)
                {
                    //空文字が入っていた時のスキップ処理
                    if (name.Equals(""))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(name);
                    }
                }

                int get = 0;

                //Randomクラスのインスタンス生成
                Random rm = new Random();
                get = rm.Next(pNamesNum);
                Console.WriteLine("いけ ! " + pokemonNames[get] + " !");
            }
        }
    }
}
