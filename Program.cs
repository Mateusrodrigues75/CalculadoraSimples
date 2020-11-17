using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, resultado;
            resultado = 0;
            Console.WriteLine("Digite a operação que deseja fazer \nSoma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º número:  ");
            num1 = float.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Digite o 2º número:  ");
            num2 = float.Parse(Console.ReadLine());

            switch(operacao){
                case "Soma":
                    resultado = num1+num2;
                break;
                case "Subtracao":
                    resultado = num1-num2;
                break;
                case "Multiplicação":
                    resultado = num1*num2;
                break;
                case "Divisão":
                    resultado = num1/num2;
                break;
                default:
                Console.WriteLine("operação Inválida");
                break;
            }

            Console.WriteLine($"Calculo: {num1} e {num2} = Resultado: {resultado}");
            
        }
    }
}
