using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.LastTest
{
    internal class LTest03
    {
        public static void main(string[] args)
        {

            //① ポケモンNoとポケモン名をそれぞれの配列へ格納
            int[] pnums = { 25, 196, 908 };
            string[] pNames = { "ピカチュウ", "エーフィ", "マスカーニャ" };

            //② ポケモンListを生成
            List<PokemonInfo> pokemonList = new List<PokemonInfo>();

            //③ ①と②を用いて、For文内でPokemonのインスタンスを
            // コンストラクタを用いて生成し、Listへ格納
            for (int i = 0; i < pNames.Length; i++)
            {
                pokemonList.Add(new PokemonInfo(pnums[i], pNames[i]));
            }

            //④ foreach文を用いて,Listに格納したポケモンの情報を
            //生成したインスタンスのメソッドを使って出力
            foreach (PokemonInfo pokemon in pokemonList)
            {
                pokemon.infoOutput();
            }
        }
    }
}
