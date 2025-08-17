﻿namespace ScreenSound_API.Modelos
{
    using System.Text.Json.Serialization;

    internal class Musica
    {
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string? Ton
        {
            get
            {
                return tonalidades[Key];
            }
        }


        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
            Console.WriteLine($"Gênero musical: {Genero}");
            Console.WriteLine($"Esse é o Ton: {Ton}");
        }
    }
}
