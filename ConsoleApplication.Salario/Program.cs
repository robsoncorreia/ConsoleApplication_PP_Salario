using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario = 0;
            float salarioLiquido = 0;
            float desconto = 0;
            int imposto = 0;

            while (salario <= 0)
            {
                Console.WriteLine("Digite seu salário");
                salario = float.Parse(Console.ReadLine());

                if (salario <= 0)
                {
                    Console.WriteLine("Valor do salário não pode ser menor ou igual a zero.");
                }
            }
            while (imposto < 1 || imposto >= 100)
            {
                Console.WriteLine("Qual o valor do imposto");
                imposto = int.Parse(Console.ReadLine());

                if (imposto < 1 || imposto >= 100)
                {
                    Console.WriteLine("Valor do imposto não pode ser menor que 1 ou maior que  100.");
                }
            }
            desconto = (imposto * 0.01f) * salario;
            salarioLiquido = salario - desconto;

            Console.WriteLine("Salário liquido é {0:C}", salarioLiquido);

            Console.ReadKey();
        }
    }
}
