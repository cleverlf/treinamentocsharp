using System;

namespace CursoGitHub.InterfaceConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string comando ;
            
            string resposta = "git remote add origin";

            Console.WriteLine("Qual o comando para adicionar um repositorio remoto?");
            comando = Console.ReadLine();

            string[] subcomando = comando.Split();

            //Console.WriteLine(subcomando.Length);


            /*foreach manual
            for (int i = 0; i < subcomando.Length; i++)
            {
                Console.WriteLine(subcomando[i]);
            }*/

            /*foreach (var i in subcomando)
            {
                Console.WriteLine(i);
            }*/


            if (subcomando.Length == 2)
            {
                if (subcomando[0].Equals("git") && subcomando[1].Equals("remote"))
                {
                    Console.WriteLine("Acertou 50%!");
                }
            }
            else if (subcomando.Length == 4)
            {
                if (subcomando[0].Equals("git") && subcomando[1].Equals("remote") && subcomando[2].Equals("add") && subcomando[3].Equals("origin"))
                {
                    Console.WriteLine("Acertou 100%!");
                }
            }
            else
            {
                Console.WriteLine("errou");
            }

            Console.WriteLine($"A resposta é {resposta}.");


            Console.ReadKey();
        }
    }
}
