using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicasis = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach (var genero in todosOsGenerosMusicasis)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void ExibirListaDeArtistasOrdenados(List<Musica>musicas)
    {
        var musicasOrdenadasDesc = musicas.OrderByDescending(o=>o.Artista)
                                           .Select(s => s.Artista)
                                           .Distinct()
                                           .ToList();

        var musicasOrdenadasAsc = musicas.OrderBy(o=>o.Artista)
                                           .Select(s => s.Artista)
                                           .Distinct()
                                           .ToList();

        Console.WriteLine($"Artistas ordenadas desc.\n");
        foreach (var musica in musicasOrdenadasDesc)
        {
            Console.WriteLine($"- {musica}");
        }

        Console.WriteLine($"\nMúsicas ordenadas asc.");

        foreach (var musica in musicasOrdenadasAsc)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusica(List<Musica> musicas,string genero)
    {
        var artistasPorGeneroMusical = musicas
          .Where(m => m.Genero?.Contains(genero) == true)
          .Select(s => s.Artista)
          .Distinct()
          .ToList();


        Console.WriteLine($"Artistas filtrados pelo genero {genero}\n");
        foreach (var musica in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicaPorArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas
          .Where(m => m.Artista?.Equals(artista) == true)// é igual ao contains, porem mais rapido
          .Select(s => s.Nome)
          .Distinct()
          .ToList();


        Console.WriteLine($"Músicas do artista: {artista}\n");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void ExibirFichaPorLista(List<Musica> musicas)
    {
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Artista: {musica.Artista}");
            Console.WriteLine($"Música: {musica.Nome}");
            Console.WriteLine($"Duração em segundos: {musica.Duracao / 1000}");
            Console.WriteLine($"Gênero musical: {musica.Genero}");
            Console.WriteLine($"Esse é o Ton: {musica.Ton}");
            Console.WriteLine($"Esse é o Ton: {musica.Key}\n");

        }
    }

    internal static void FiltarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmSSharp = musicas
                        .Where(m => m.Ton?.Equals("C#") == true)
                        .Select(m => new { m.Nome, m.Ton})
                        .ToList();

        Console.WriteLine("Músicas em C#: ");

        foreach (var musica in musicasEmSSharp)
        {
            Console.WriteLine($"- {musica.Nome}");
            Console.WriteLine($"- {musica.Ton}\n");
        }
    }
}
