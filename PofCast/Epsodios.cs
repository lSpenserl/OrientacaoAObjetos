class Episodio
{

    public Episodio(string titulo)
    {
        Titulo = titulo;
    }

    public string Titulo { get;  }
    public int Duracao { get; set; }
    public int Ordem { get; set; }
    public string Resumo => $"{Ordem} . {Titulo}({Duracao} min) - {string.Join(", ", Convidados)}";
    public List<string> Convidados { get; set; } = new();

    public void AdicionarConvidados (string convidados)
    {
        Convidados.Add (convidados);
    }

}