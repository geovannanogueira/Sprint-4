using System;

namespace exercicioaluno
{
    class Programa
    {
        static void Main(string[] args)
        {
            //   1 - Cadastrar Aluno
            //   2 - Cadastrar Sala
            //   3 - Alocar Aluno
            //   4 - Remover Aluno
            //   5 - Verificar Salas
            //   6 - Verificar Alunos
            //   0 - Sair

            //   - Cadastre ao menos 4 alunos e 1 sala.
            //   - É preciso associar alunos à sala, para isso basta diminuir o número total de capacidade da sala e gravar o número dela no Objeto aluno.
            //   - É obrigatório que uma mensagem de sala cheia seja exibida, caso o número de ocupantes supere sua capacidade.
            //   - Na opção 5 deverão ser listadas todas as características da sala;
            //   - Na opção 6 deverão ser listados o nome e número da sala de todos os alunos.
            //   - Na opção 3 o usuário poderá digitar o Nome do Aluno e o Número da Sala pra onde ele vai.
            //   - Na opção 4 o usuário poderá digitar o Nome do Aluno e isso irá removê-lo da Sala.
            //   - Quem realiza a alocação/remoção é a classe Sala.


            bool querSair = false;
            Aluno[] alunos = new Aluno[4];
            int numAlunos = 0;

            Sala[] sala = new Sala [1];
            int numSala = 0;

        do{
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("");
            Console.WriteLine("1 - Cadastrar Aluno");
            Console.WriteLine("2 - Cadastrar Sala");
            Console.WriteLine("3 - Alocar Aluno");
            Console.WriteLine("4 - Remover Aluno");
            Console.WriteLine("5 - Verificar Salas");
            Console.WriteLine("6 - Verificar Alunos");
            Console.WriteLine("0 - Sair");

            int codigo = int.Parse(Console.ReadLine());

            switch(codigo){
                case 1: 

                break;
            }


        }while(querSair);
        }
    }
}
