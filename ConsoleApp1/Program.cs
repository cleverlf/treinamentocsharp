using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int cont = 1;

            string c = "git init";
            while (cont <= 20)
            {
                if (cont>10)
                {
                    c = "git status";
                }
                Console.WriteLine(c);
                cont++;

            }
            Console.ReadKey();  
        }
    }
}
