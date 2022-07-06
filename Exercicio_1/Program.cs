using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma, t1, p1, p2;
            string nome;

            Console.WriteLine("Digite o nome do Aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a nota do trabalho: ");
            t1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da primeira prova: ");
            p1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova: ");
            p2 = int.Parse(Console.ReadLine());

            soma = (t1 + p1 + p2)/3;

            if (soma >= 8.5){

                Console.WriteLine("Seu conceito é A" );
            }
            else if (soma >= 7){

                Console.WriteLine("Seu conceito é B");
            }

            else if (soma >= 6) {

                Console.WriteLine("Seu conceito é C");
            }

            else if (soma >= 0.1){

                Console.WriteLine("Seu conceito é D");
            }

            else if (soma >= 0){

                Console.WriteLine("Seu conceito é E");
            }

            Console.ReadLine();
        }
    }
}
