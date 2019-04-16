using System;

namespace TsukaAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool querSair = false;
            Passageiro[] passageiros = new Passageiro[2];
            int numPassageiros = 0;
            Console.WriteLine("Seja bem-vindo(a) à Tsukamoto Airlines");

            do {

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Registrar Passageiro");
                Console.WriteLine("2 - Exibir passageiros");
                Console.WriteLine("0 - Sair");

                int codigo = int.Parse(Console.ReadLine());

                switch(codigo){
                    case 1:
                        Passageiro p = new Passageiro();
                        Console.WriteLine("Digite o seu nome:");
                        p.setNome(Console.ReadLine());
                        passageiros[numPassageiros] = p;
                        numPassageiros++;
                        Console.WriteLine("Cadatro concluído!");
                    break;
                    case 2:
                    Console.WriteLine("Todos os passageiros cadastrados:");
                        foreach (var passageiro in passageiros){
                            if(passageiro != null){
                                Console.WriteLine(passageiro.getNome());
                            }
                        }
                    break;
                }

            } while (!querSair);
        }
    }
}
