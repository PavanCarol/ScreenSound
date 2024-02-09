//Screen Sound

using System.Xml;

string boasVindas = "Boas vinda ai ";
//List<string> listaDasBandas = new List<string> { "Metallica", "AC/DC", "Iron Maiden", "Guns N' Roses", "Led Zeppelin" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Beatles", new List<int>());

void exibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(boasVindas);
}

void exibirOpcoes()
{
    exibirLogo();
    Console.WriteLine("\n Digite 1 para registrar uma banda  ");
    Console.WriteLine("\n Digite 2 para mostrar todas as bandas");
    Console.WriteLine("\n Digite 3 para avaliar uma banda");
    Console.WriteLine("\n Digite 4 para exibir a média de uma banda");
    Console.WriteLine("\n Digite -1 para sair");

    Console.Write("\n Digite a sua Opção:");
    string opcaoEscolhida=  Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

   
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;

        case 2: ExibirBandas();
            break;

        case 3:
            AvaliarBanda();
            break;

        case 4:
            ExibirMedia();
            break;

        case -1:
            Console.WriteLine("Tchau tchau");
            break;

        default: Console.WriteLine("Opção Invalida");
            break;

    }
}

void RegistrarBandas()
{
    Console.Clear();
    exibirTituloDasOpcoes("Registros das Bandas");
    Console.Write("Digite o nom da banda que deseja registrar: ");

    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda,new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirOpcoes();
}

void ExibirBandas()
{
    Console.Clear();
    exibirTituloDasOpcoes("Visualização das Bandas");

    //for (int i=0;i<listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda:{listaDasBandas[i]}");
    //}
    foreach (string banda in  bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda {banda}");
    }

    Console.WriteLine("\n Digite uma tela para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    exibirOpcoes();
}

void exibirTituloDasOpcoes( string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    //digite qual banda deseja avaliar
    //se a banda existir no dicionario >> atribuir uma nota
    //enão,volta para o menu principal
    Console.Clear();
    exibirTituloDasOpcoes("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar:");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso !!");
        Thread.Sleep(2000);
        Console.Clear();
        exibirOpcoes();
    }
    else
    {
        Console.WriteLine($"\n A Banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoes();
    }
    Console.Clear();
    exibirOpcoes();
}

void ExibirMedia()
{
    Console.Clear();
    exibirTituloDasOpcoes("Média das Bandas");
    Console.Write("Digite o nome da banda que você quer ver a média da avaliação:");
    string avaliacaoDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(avaliacaoDaBanda))
    {
        //Criar uma lista
        List<int> notaDasBandas = bandasRegistradas[avaliacaoDaBanda];
        Console.WriteLine($"A média da Banda {avaliacaoDaBanda} é :{notaDasBandas.Average()}");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoes();
    }
    else
    {
        Console.WriteLine($"\n A Banda {avaliacaoDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoes();
    }
}
exibirOpcoes();