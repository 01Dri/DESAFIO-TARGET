namespace DesafioTargetImpl;

public class DesafioHandler
{
    private List<IDesafio> _desafios;
    public DesafioHandler(List<IDesafio> desafios)
    {
        _desafios = desafios;
    }

    public void Run()
    {
        _desafios.ForEach(x =>
        {
            Console.Clear();
            Console.WriteLine($"{x.GetType().Name} rodando...");
            x.Execute();
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        });
    }
}