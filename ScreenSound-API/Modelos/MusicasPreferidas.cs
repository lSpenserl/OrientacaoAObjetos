using System.Text.Json;

namespace ScreenSound_API.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
           Nome = nome;
           ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFaboritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas de {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"\n - {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArqiovoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musica = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo,json);
        Console.WriteLine($"O arquivo JSON foi criado com sucesso!{Path.GetFullPath(nomeDoArquivo)}");
    }

    public void GerarDocumentoTXTComAsMusicasFavoritas()
    {
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
        {
            arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                arquivo.WriteLine($"- {musica.Nome}");
            }
        }
        Console.WriteLine("txt gerado com sucesso!");
    }

}
