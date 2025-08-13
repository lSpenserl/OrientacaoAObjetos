class PodCast
{
    public PodCast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public List<Episodio>? Episodios { get; set; } = new();
    private int TotalEpsodios => Episodios.Count;

    public void AdicionarEpsodios(Episodio epsodio)
    {
        Episodios.Add(epsodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"O nome do PodeCast é: { Nome}\n");
        Console.WriteLine($"O nome do Host é: { Host}\n");
        foreach (var item in Episodios.OrderBy(e=>e.Ordem))
        {
            Console.WriteLine($"Temos o episodio: {item.Titulo}\n");
            Console.WriteLine($"Resumo: {item.Resumo}\n");
        }
        Console.WriteLine($"Temos um total de: {TotalEpsodios} episodios.\n");

    }
}