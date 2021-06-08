using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios3Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();

            string textoLido = "1+ (5 +3 - (8-5)*4 - ((3+7)*(3-1)))";

            char[] chars = textoLido.ToCharArray();

            foreach (char c in chars)
            {
                if (c == '(')
                {
                    pilha.Push(0);
                }
                if (c == ')')
                {
                    if (pilha.Count > 0)
                    {
                        pilha.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Os parênteses não estão dispostos de forma correta. :c");
                        Console.ReadLine();
                        return;
                    }
                }
            }

            if (pilha.Count == 0)
            {
                Console.WriteLine("Os parênteses estão dispostos de forma correta!");
            }
            else
            {
                Console.WriteLine("Os parênteses não estão dispostos de forma correta. :c");
            }

            Console.ReadLine();

        }

       


    }
}

