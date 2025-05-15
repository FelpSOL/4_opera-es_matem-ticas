using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULAS
{
    internal class Aula05

    {

        public void Test()
        {
            Console.WriteLine("Teste Instância");
        }


        public void ParOUImpar()
        {
            int n1;

            Console.WriteLine("Digite um número :");
            n1 = int.Parse(Console.ReadLine());// int com minuscula subistitui e facilita o Int32
         //ou   //n1 = Int32.Parse(Console.ReadLine());//
         //ou   //n1 = Convert.ToInt32(Console.ReadLine());//

            if ((n1 % 2) == 0) // if = SE   // % = Resto
            {
                Console.WriteLine("Este número é Par");
            }
            else // else = SENÃO
            {
                Console.WriteLine("Este número é Impar");
            }
        }
    }
}
