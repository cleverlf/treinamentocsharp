using System;

namespace CursoGitHub.InterfaceConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pergunta ;
            string resposta = "git init";

            Console.WriteLine("Qual o comando para iniciar o git?");
            pergunta = Console.ReadLine();
            
            if (pergunta.Equals(resposta))
            {
                Console.WriteLine("Acertou!");
            }
            else
            {
                Console.WriteLine("Errou!");
            }
            
            Console.WriteLine($"A resposta é {resposta}.");
          
           
            
        }
    }
}
