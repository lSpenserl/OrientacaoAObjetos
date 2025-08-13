Episodio orientacaoObjetos = new Episodio("Orientação a objetos")
{
    Duracao = 213,
    Ordem = 2,
    // Resumo = "Descreve e ensina como trabalhar com orientação a objetos",
};

orientacaoObjetos.AdicionarConvidados("João Carlos");
orientacaoObjetos.AdicionarConvidados("Leticia");
orientacaoObjetos.AdicionarConvidados("Bia");

Episodio cypress = new Episodio("Falando sobre cypress")
{
    Duracao = 514,
    Ordem = 1,
    //Resumo = "Descreve e ensina como trabalhar com cypres",
};

cypress.AdicionarConvidados("Leandro");
cypress.AdicionarConvidados("Barbara");
cypress.AdicionarConvidados("Lindaura");

PodCast podCastDoZe = new PodCast("PodCas do Zé", "Spotify");

podCastDoZe.AdicionarEpsodios(orientacaoObjetos);
podCastDoZe.AdicionarEpsodios(cypress);

podCastDoZe.ExibirDetalhes();