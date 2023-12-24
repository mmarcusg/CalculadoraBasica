using System;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a operação: (+ - x /)");
            char operador = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (Char.ToLower(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;

                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                    }
                    break;

                case 'x':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

            Console.ReadKey();
        }
    }
}
