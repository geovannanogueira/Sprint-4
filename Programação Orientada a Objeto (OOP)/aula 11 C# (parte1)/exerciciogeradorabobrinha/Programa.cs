using System;

namespace exerciciogeradorabobrinha
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve uma palavra aí, meu consagrado");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 5;

            string[] palavrasUsuario = new string[5];

            for (int i = 0; maxPalavrasUsuario > 0; i++)
            {
                palavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario != 0)
                {
                    Console.WriteLine("Faltam " + maxPalavrasUsuario + ". Digite mais uma!");
                }
                else
                {
                    Console.WriteLine("Valeu, meu bom! Agora deixa comigo!");
                }
            }
            string[,] matrizPalavras = {
                {"Tiagado", "desce" , "vai"    , ""      , "vamos"},
                {"gosta"  , "sobe"  , "rebola" , ""      , "vamos"},
                {""       , "empina", "pro"    , "somos" , "meu"  },
                {"da"     , "e"     , "pai"    , "todos" , ""     },
                {"Momo"   , "rebola", ""       , "cornos", "Timão"},
            };

            for (int i = 0; i < matrizPalavras.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPalavras.GetLength(0); j++)
                {
                    if ("".Equals(matrizPalavras[i, j]))
                    {
                        matrizPalavras[i, j] = palavrasUsuario[j];
                    }
                }
            }

            string frase = "";
            Random r = new Random();
            for (int i = 0; i < maxPalavrasFrase; i++)
            {
                frase += matrizPalavras[i //i
                                        ,
                                        r.Next(matrizPalavras.GetLength(0))] + " "; //j
            }

            Console.WriteLine("Minha frase é: \n" + frase);

        }
    }
}
