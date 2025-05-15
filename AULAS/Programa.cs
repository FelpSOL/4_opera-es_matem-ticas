namespace AULAS
{
    internal class Programa
    {
        static void Main(string[] args)
        {


            Console.WriteLine("CALCULADORA");

            int n1, n2;

            Calculadora objetoDaInstancia = new Calculadora();

            Console.WriteLine("Digite o Primeiro número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Primeiro número : ");
            n2 = int.Parse(Console.ReadLine());



            objetoDaInstancia.Soma(n1, n2);

            objetoDaInstancia.Subitracao(n1, n2);

            objetoDaInstancia.Multiplicacao(n1, n2);

            objetoDaInstancia.Divisao(n1, n2);


            //Aula05 poi = new Aula05();s
            //poi.ParOUImpar();



        }



    }
}
