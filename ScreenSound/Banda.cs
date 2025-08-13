class Banda
{
    private List<Album> Albuns = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album Album)
    {
        Albuns.Add(Album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"discografia da banda {Nome}");
        foreach (Album Album in Albuns)
        {
            Console.WriteLine($"Álbum: {Album.Nome} ({Album.DuracaoTotal})");
        }
    }
}