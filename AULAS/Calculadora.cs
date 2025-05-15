using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULAS
{
    internal class Calculadora
    {
        public int Soma(int n1, int n2) //chamando uma instancia 
        {
            int resultado;//variavel 

            resultado = n1 + n2;

            Console.WriteLine("O resultado dos números em Soma é : " + resultado);

            return resultado;
        }

        public int Subitracao(int primeiroNumero, int segundoNumero)
        { 
             
            int resultado2;
            resultado2 = primeiroNumero - segundoNumero;
            Console.WriteLine("O resultado dos números em Subtração é : " + resultado2);
            return resultado2; 

        }

        public int Multiplicacao(int primeiroNumero, int segundoNumero)
        {

            int resultado3;
            resultado3 = primeiroNumero * segundoNumero;
            Console.WriteLine("O resultado dos números em Multiplicação é : " + resultado3);
            return resultado3;

        }

        public int Divisao(int primeiroNumero, int segundoNumero)
        {

            int resultado4;
            resultado4 = primeiroNumero / segundoNumero;
            Console.WriteLine("O resultado dos números em Divisão é : " + resultado4);
            return resultado4;

        }

        public int Porcentagem(int primeiroNumero, int segundoNumero)
        {
           
            int resultado5;
            resultado5 = ((primeiroNumero / segundoNumero) * 100);
            Console.WriteLine("O resultado dos números em Porcentagem é : " + resultado5);
            return resultado5;

        }


    }
}
