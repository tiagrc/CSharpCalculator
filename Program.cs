using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual o tipo de conta você deseja realizar? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracação");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("9 - Sair");

            Console.WriteLine("----------------------");
            Console.Write("Selecione uma das opções acima: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 9: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            // Valor 1
            Console.Write("Primeiro valor a somar: ");
            double value1 = double.Parse(Console.ReadLine());
            // Valor 2
            Console.Write("Segundo valor a somar: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = value1 + value2;
            // Utilizar o $ antes da String se chama interpolação da String, 
            // deixando de forma clean e bonito. Não esqueça de passar a var nas chaves {}.
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor a subtrair: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor a subtrair: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double result = value1 - value2;
            Console.WriteLine($"Resultado: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor a dividir: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor a dividir: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double result = value1 / value2;
            Console.WriteLine($"O resultado é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor a multiplicar: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor a multiplicar: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.Write("");

            double result = value1 * value2;
            Console.WriteLine($"O resultado é: {result}");
            Console.ReadKey();
            Menu();
        }

    }
}



