using System;

namespace Analise_Credito
{
    class Program
    {
        static void Main(string[] args)
        {
            int parcelas;
            decimal valor, valorParcela, valorMaximoParcela, rendaMensal;
            bool valorValido, parcelasValido, rendaMensalValido;

            Console.Write("Digite o Valor Desejado: ");
            valorValido = Decimal.TryParse(Console.ReadLine(), out valor);
            
            if (!valorValido)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Você digitou um valor invalido");
                Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                Console.ReadKey();
                Console.ResetColor();
                Environment.Exit(-1);
            }

            Console.Write("Digite a Quantidade de Parcelas Desejada: ");
            parcelasValido = int.TryParse(Console.ReadLine(), out parcelas);

            if (!parcelasValido)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Você digitou um valor invalido");
                Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                Console.ReadKey();
                Console.ResetColor();
                Environment.Exit(-1);
            }

            Console.Write("Digite a Sua Renda Mensal: ");
            rendaMensalValido = Decimal.TryParse(Console.ReadLine(), out rendaMensal);
            Console.WriteLine();

            if (!rendaMensalValido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você digitou um valor inválido");
                Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                Console.ReadKey();
                Console.ResetColor();
                Environment.Exit(-1);
            }

             valorParcela = valor / parcelas;
             valorMaximoParcela = rendaMensal * 0.3m;

             Console.WriteLine($"O valor de cada parcela será: {valorParcela:C}");
             Console.WriteLine($"Valor por Parcela Máximo aprovado: {valorMaximoParcela:C}");

             if (valorParcela <= valorMaximoParcela)
             {
                  Console.WriteLine();
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.WriteLine("Parabéns, seu credito foi aprovado! ");
             }
             else
             {
                  Console.WriteLine();
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("Desculpe, seu crédito não foi aprovado! ");
             }

            
        }
    }
}
