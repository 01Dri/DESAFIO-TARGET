namespace DesafioTargetImpl.Desafio_1;

public class Desafio1 : IDesafio
{
    public void Execute()
    {
        int indice = 13;
        int soma = 0;
        int k = 0;
        
        while (k < indice)
        {
            k += 1;
            soma = soma + k;
        }
        
        Console.WriteLine ("Resultado DESAFIO 1: " + soma);
    }
}