using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.LastTest
{
    internal class PokemonInfo
    {
        //①ポケモン名とポケモンNoのメンバ変数
        public int pNum;
        public string pName;

        //②ポケモンクラスのインスタンスを生成するためのコンストラクタ
        public PokemonInfo(int num, string name)
        {
            this.pNum = num;
            this.pName = name;
        }

        //③ポケモン情報出力用のメソッドを作成
        public void infoOutput()
        {
            Console.WriteLine("ポケモンNo : " + this.pNum + " / ポケモン名 : " + this.pName);
        }
    }
}
