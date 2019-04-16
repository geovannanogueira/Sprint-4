using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            Console.WriteLine("Digite sua senha");
            usuario.setSenha(Console.ReadLine());
            string senha = usuario.getSenha();
            Console.WriteLine("Sua senha é:" + senha);
        }
    }
}
