using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULAS
{
    internal class Menus
    {

        public void MenuCalculadora()
        {
            //variaveis:
            string escolha;
            Console.WriteLine("CALCULADORA");

            int n1, n2;

            Calculadora objetoDaInstancia = new Calculadora();// quando dado um nome ao objeto da instancia para chamalo em seguida deve utilizar o nome dele pois não é um objeto fixo

            Console.WriteLine("Digite o Primeiro número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Primeiro número : ");
            n2 = int.Parse(Console.ReadLine());

//--------------------------------------------------------------------------
           
            Console.WriteLine("______MENU___________");
            Console.WriteLine("1-____SOMA___________");
            Console.WriteLine("4-____DIVISÃO________");
            Console.WriteLine("2-____SUBTRAÇÃO_   __");
            Console.WriteLine("3-____MULTIPLICAÇÃO__");
            Console.WriteLine("ESCOLHA UM NÚMERO :  ");
            
            escolha = Console.ReadLine();  //a variavel recebe a entrada

            if (escolha == "1" || escolha == "soma")
            {

                Console.WriteLine(objetoDaInstancia.Soma(n1, n2));

            }
            else if (escolha == "2" || escolha == "divisão") //senão se - else if 
            { 
            
            }

        }
    }
}
