using Newtonsoft.Json;

namespace DesafioTargetImpl.Desafio_3;

public class Desafio3 : IDesafio
{
    public const string JSON_FILE_NAME = "FaturamentosDistribuidora.json";

    public void Execute()
    {
        List<FaturamentoDistribuidora> faturamentoDistribuidoras = this.GetFaturamentos();
        
        Console.WriteLine("Digite um dia da semana: ");
        int diaSemana = int.Parse(Console.ReadLine());
        
        Console.WriteLine("O menor valor de faturamento ocorrido em um dia do mês: " 
                          + this.GetMenorFaturamento(faturamentoDistribuidoras, diaSemana));
        
        Console.WriteLine("O maior valor de faturamento ocorrido em um dia do mês: " 
                          + this.GetMaiorFaturamento(faturamentoDistribuidoras, diaSemana));
        
        Console.WriteLine("Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: " 
                          + this.GetNumeroDeDiasComFaturamentoMaiorQueAMendiaMensal(faturamentoDistribuidoras));
    }

    private List<FaturamentoDistribuidora> GetFaturamentos()
    {
        var distributorRevenues = JsonConvert.DeserializeObject<List<FaturamentoDistribuidora>>
            (this.GetJsonFile(JSON_FILE_NAME));
        return distributorRevenues ?? throw new Exception("Não foi possivel converter o arquivo JSON em um objeto");
    }

    private string GetJsonFile(string jsonFileName)
    {
        var basePath = AppDomain.CurrentDomain.BaseDirectory;
        var solutionDirectory = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\"));
        var jsonFilePath = Path.Combine(solutionDirectory, jsonFileName);
        if (!File.Exists(jsonFilePath))
        {
            throw new FileNotFoundException("Arquivo JSON não foi encontrado", jsonFilePath);
        }
        return  File.ReadAllText(jsonFilePath);
    }

    public int GetMenorFaturamento(List<FaturamentoDistribuidora> faturamentos, int dia)
    {
        return faturamentos
            .Where(x => x.Dia == dia)
            .Min(x => x.Faturamento);
    }

    public int GetMaiorFaturamento(List<FaturamentoDistribuidora> faturamentos, int dia)
    {
        return faturamentos
            .Where(x => x.Dia == dia)
            .Max(x => x.Faturamento);
    }

    public int GetNumeroDeDiasComFaturamentoMaiorQueAMendiaMensal(List<FaturamentoDistribuidora> faturamentos)
    {
        var mediaMensal = faturamentos
            .Where(x => x.Faturamento > 0)
            .Average(x => x.Faturamento);
    
        var diasAcimaDaMedia = faturamentos
            .GroupBy(x => x.Dia)
            .Where(g => g.Average(x => x.Faturamento) > mediaMensal)
            .Count();
    
        Console.WriteLine("Media mensal: " + Math.Round(mediaMensal));
        return diasAcimaDaMedia;
    }
}