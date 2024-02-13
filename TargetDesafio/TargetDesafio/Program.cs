using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System;
class Program
{

    static void Main()
    {
        QuestaoUm();
        QuestaoDois();
        QuestaoQuatro();
        QuestaoCinco();
    }

    private static bool VerificarFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        while (b < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == numero;
    }
    public static void QuestaoUm()
    {
        Console.WriteLine("********QUESTÃO 01********");
        int INDICE = 13;
        int SOMA = 0;
        int K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine(SOMA);
        Console.WriteLine();
    }
    public static void QuestaoDois()
    {
        Console.WriteLine("********QUESTÃO 02********");
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (VerificarFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
        Console.WriteLine();
    }
    public static void QuestaoQuatro()
    {

        Console.WriteLine("********QUESTÃO 04********");
        decimal faturamentoSP = 67836.43m;
        decimal faturamentoRJ = 36678.66m;
        decimal faturamentoMG = 29229.88m;
        decimal faturamentoES = 27165.48m;
        decimal faturamentoOutros = 19849.53m;

        decimal faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

        decimal percentualSP = (faturamentoSP / faturamentoTotal) * 100;
        decimal percentualRJ = (faturamentoRJ / faturamentoTotal) * 100;
        decimal percentualMG = (faturamentoMG / faturamentoTotal) * 100;
        decimal percentualES = (faturamentoES / faturamentoTotal) * 100;
        decimal percentualOutros = (faturamentoOutros / faturamentoTotal) * 100;

        Console.WriteLine($"Percentual de representação de SP: {percentualSP:F2}%");
        Console.WriteLine($"Percentual de representação de RJ: {percentualRJ:F2}%");
        Console.WriteLine($"Percentual de representação de MG: {percentualMG:F2}%");
        Console.WriteLine($"Percentual de representação de ES: {percentualES:F2}%");
        Console.WriteLine($"Percentual de representação de OUTROS: {percentualOutros:F2}%");

        Console.WriteLine();
    }
    public static void QuestaoCinco()
    {
        Console.WriteLine("********QUESTÃO 05********");

        Console.WriteLine("Digite uma string:");
        string inputString = Console.ReadLine();

        string reversedString = ReverterString(inputString);
        Console.WriteLine($"String original: {inputString}");
        Console.WriteLine($"String invertida: {reversedString}");

        Console.WriteLine();
    }
    private static string ReverterString(string input)
    {
        char[] charArray = input.ToCharArray();
        int leftIndex = 0;
        int rightIndex = input.Length - 1;

        while (leftIndex < rightIndex)
        {
            char temp = charArray[leftIndex];
            charArray[leftIndex] = charArray[rightIndex];
            charArray[rightIndex] = temp;

            leftIndex++;
            rightIndex--;
        }

        return new string(charArray);
    }
}


  


