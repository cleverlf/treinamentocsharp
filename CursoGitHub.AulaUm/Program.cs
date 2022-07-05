using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.AulaUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int dia;
            

            Console.WriteLine("Aula 1 - GitHub");
            Console.WriteLine("Qual a sua idade?");
            
            idade = int.Parse(Console.ReadLine());
            if (idade <=15)
            {
                Console.WriteLine("GitHub Sesi");
            }
            else
            {
                Console.WriteLine("GitHub Senai");
                Console.WriteLine("Qual o melhor dia para uma aula presencial?");
                Console.WriteLine("1-Segunda, 2-Terça, 3-Quarta, 4-Quinta, 5-Sexta, 6-Sábado");
                dia = int.Parse(Console.ReadLine());
                switch (dia)
                {
                    
                    case 1: Console.WriteLine("Segunda".ToUpper());
                        break;
                    case 2:Console.WriteLine("Terça".ToUpper());
                        break;
                    case 3: Console.WriteLine("Quarta".ToUpper());
                        break;
                    case 4: Console.WriteLine("Quinta".ToUpper());
                        break;
                    case 5: Console.WriteLine("Sexta".ToUpper());
                        break;
                    case 6: Console.WriteLine("Sábado".ToUpper());
                        break;
                    default: Console.WriteLine("Não é um dia da semana".ToUpper());
                        break;
                }
                Console.WriteLine("Qual o seu nome completo?");
                string nome = Console.ReadLine();
                Console.WriteLine($"Tudo minusculo: {nome.ToLower()}");
                Console.WriteLine($"Tamanho da string: {nome.Length}");
                Console.WriteLine($"Tem R: {nome.Contains("R")}");
                Console.WriteLine(nome.Substring(1,nome.Length -1));
            }
            Console.ReadKey();
        }
    }
}
