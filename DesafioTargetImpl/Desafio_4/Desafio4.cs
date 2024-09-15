namespace DesafioTargetImpl.Desafio_4;

public class Desafio4 : IDesafio
{
    private Dictionary<string, double> faturamentoPorEstado = new Dictionary<string, double>
    {
        { "SP", 67836.43 },
        { "RJ", 36678.66 },
        { "MG", 29229.88 },
        { "ES", 27165.48 },
        { "Outros", 19849.53 }
    };


    public void Execute()
    {
        
        var valorTotal = faturamentoPorEstado.Values.Sum();

        foreach (var estado in faturamentoPorEstado)
        {
            var percentual = (estado.Value / valorTotal) * 100;
            Console.WriteLine($"Estado: {estado.Key}, Faturamento: R${estado.Value:F2}, Percentual: {percentual:F2}%");
        }
    }
}