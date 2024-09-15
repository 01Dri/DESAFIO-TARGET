namespace DesafioTargetImpl.Desafio_5;

public class Desafio5 : IDesafio
{
    public void Execute()
    {
        Console.WriteLine("Digite uma string");
        string stringParaConverter = Console.ReadLine();
        Console.WriteLine($"String '{stringParaConverter}' invertida para '{this.InverterString(stringParaConverter)}'");
        
    }

    private string? InverterString(string baseString)
    {
        char[] stringChar = baseString.ToCharArray();
        List<char> stringInvertida = new List<char>();
        for (int i = stringChar.Length - 1; i >= 0; i--)
        {
            stringInvertida.Add(stringChar[i]);
        }

        return new string(stringInvertida.ToArray());
    }
}