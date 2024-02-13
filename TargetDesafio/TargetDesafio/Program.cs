using System;
class Program
{

    static void Main()
    {
        QuestaoUm();
        QuestaoDois();
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
        Console.WriteLine(  );
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
        Console.WriteLine(  );
    }
}

