using ScreenSound_API.Modelos;
using System.Text.Json;
using ScreenSound_API.Filtros;

try
{
    using (HttpClient client = new HttpClient())
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.ExibirFichaPorLista(musicas);
        LinqFilter.FiltarMusicasEmCSharp(musicas);

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarMusicaPorArtista(musicas, "Years & Years");
        //LinqFilter.FiltrarArtistaPorGeneroMusica(musicas,"rock");
        //LinqFilter.FiltrarMusicaPorArtisata(musicas, "U2");

        //var musicasPreferidasDoLeandro = new MusicasPreferidas("Leandro");
        //musicasPreferidasDoLeandro.AdicionarMusicasFaboritas(musicas[0]);
        //musicasPreferidasDoLeandro.AdicionarMusicasFaboritas(musicas[344]);
        //musicasPreferidasDoLeandro.AdicionarMusicasFaboritas(musicas[45]);
        //musicasPreferidasDoLeandro.AdicionarMusicasFaboritas(musicas[85]);
        //musicasPreferidasDoLeandro.AdicionarMusicasFaboritas(musicas[1469]);

        //musicasPreferidasDoLeandro.ExibirMusicasFavoritas();
        //musicasPreferidasDoLeandro.GerarArqiovoJson();
        //musicasPreferidasDoLeandro.GerarDocumentoTXTComAsMusicasFavoritas();
    }

}
catch (Exception ex)
{

    Console.WriteLine($"Temos um problema: {ex.Message}");
}