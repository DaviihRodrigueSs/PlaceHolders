using System.Globalization;

namespace PlaceHolders
{
    class program
    {
        static void Main(string[] args)
        {

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //nome desse metodo e chamado de placeholders.

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} e tem saldo igual a {saldo:F2} reais ");

            //Concatenação

            Console.WriteLine(nome + " tem " + idade + " e tem saldo igual a " + saldo + " reais ");


            Console.ReadLine();

        }
    }
}