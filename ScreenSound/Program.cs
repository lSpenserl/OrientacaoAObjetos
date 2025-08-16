using ScreenSound.Menus;
using ScreenSound.Modelos;

Banda ira = new Banda("Ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));

Banda beatles = new Banda("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuAvaliarBanda());
opcoes.Add(4, new MenuAvaliarAlbum());
opcoes.Add(5, new MenuExibirBandasRegistradas());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());


void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para avaliar um álbum");
    Console.WriteLine("Digite 5 para mostrar todas as bandas");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if(opcaoEscolhidaNumerica>0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}
ExibirOpcoesDoMenu();



//switch (opcaoEscolhidaNumerica)
//{
//    case 1:
//        MenuRegistrarBanda menuRegistrar = new();
//        menuRegistrar.Executar(bandasRegistradas);
//        ExibirOpcoesDoMenu();
//        break;
//    case 2:
//        MenuRegistrarAlbum menuRegistrarAlbum = new();
//        menuRegistrarAlbum.Executar(bandasRegistradas);
//        ExibirOpcoesDoMenu();
//        break;
//    case 3:
//        MenuExibirBandasRegistradas menuBandaRegistradas = new();
//        menuBandaRegistradas.Executar(bandasRegistradas);
//        ExibirOpcoesDoMenu();
//        break;
//    case 4:
//        MenuAvaliarBanda menuAvaliar = new();
//        menuAvaliar.Executar(bandasRegistradas);
//        ExibirOpcoesDoMenu();
//        break;
//    case 5:
//        MenuExibirDetalhes menuDetalhes = new();
//        menuDetalhes.Executar(bandasRegistradas);
//        ExibirOpcoesDoMenu();
//        break;
//    case -1:
//        Console.WriteLine("Tchau tchau :)");
//        break;
//    default:
//        Console.WriteLine("Opção inválida");
//        break;
//}

//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};


//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false,
//};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();




