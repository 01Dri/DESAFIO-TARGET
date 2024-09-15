namespace DesafioTargetImpl.Desafio_2;

public class Desafio2 : IDesafio
{
    public void Execute()
    {
        Console.WriteLine("Informe um número:");
        int number = int.Parse(Console.ReadLine());
        if (EstaNoFibonnaci(number))
        {
            Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {number} não pertence à sequência de Fibonacci.");
        }
    }

    private bool EstaNoFibonnaci(int n)
    {
        if (n == 0 || n == 1)
            return true;

        int a = 0;
        int b = 1;
        int sum = 0;

        while (sum < n)
        {
            sum = a + b;
            a = b;
            b = sum;
        }

        return sum == n;
    }
}