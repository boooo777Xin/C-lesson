using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.LastTest
{
    internal class LTest02
    {
        public static void main(string[] args)
        {
            Console.WriteLine("今からサイコロを5回振ります。");

            //①Randomクラスのインスタンスを生成後,サイコロのListを作成
            List<int> saikoroList = new List<int>();
            Random rm = new Random();

            //②サイコロを5回振って、リストに格納し、並び替え前を出力
            string output = "";
            for (int i = 0; i < 5; i++)
            {
                saikoroList.Add(rm.Next(1, 7));
                output = output + saikoroList[i] + " ";
            }
            Console.WriteLine("並び替え前は、" + output);

            //③格納したリストをLinQのメソッドを使って昇順に並び替え、出力
            var afterSaikoros = saikoroList.OrderBy(e => e);
            output = "";
            foreach (int saikoro in afterSaikoros)
            {
                output = output + saikoro + " ";
            }
            Console.WriteLine("並び替え後は、" + output);
        }
    }
}
