using static System.Int32;
using static System.Console;
using System.Collections.Generic;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace Questao1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Alvo();
        }
        static void Alvo()
        {
            var listTemp = new List<int>();
            var result = new List<int>();

            Write("Alvo: ");
            var target = Parse(ReadLine());

            var nums = new List<int>();
            WriteLine("Digite o tamanho do array: ");
            var total = Parse(ReadLine());

            WriteLine("Digite os números: ");
            for (var i = 0; i < total; i++)
            {
                var number = Parse(ReadLine());
                listTemp.Add(number);
            }
            listTemp.Sort();

            for (int i = 0; i < listTemp.Count; i++)
            {
                if (listTemp[i] + listTemp[i + 1] == target)
                {
                    result.Add(i);
                    result.Add(i + 1);
                    Write($"[{i},{i + 1}]");
                    break;
                }
            }
        }


    }
}
