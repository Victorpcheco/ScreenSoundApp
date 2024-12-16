using System.Diagnostics;
using System.Runtime.CompilerServices;

string mensagemBoasVindas = "\nBoas Vindas ao Screen Sound!";
//List<string> listaDasBandas = new List<string>{"Charlie Brown Junior", "The Beatles"};
Dictionary<string, List<int>> DicionarioBandas = new Dictionary<string, List<int>>();

// Registrando dados ao dicionário
DicionarioBandas.Add("Linkin Park", new List<int>{10, 8, 6});
DicionarioBandas.Add("Charlie Brown Junior", new List<int>{10, 9, 10});
DicionarioBandas.Add("The Beatles", new List<int>());



void ExibirLogo() {

    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesMenu() {

    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para listar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite -1 para sair >>>");


    Console.Write("\nDigite uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) {

        case 1: RegistrarBanda(); break;
        case 2: ListarBandas(); break;
        case 3: AvaliarBanda(); break;
        case 4: Mediabandas(); break;
        case -1: Console.WriteLine("Encerrando..."); break;

        default: Console.WriteLine("Opção Inválida"); break;

    }

    void RegistrarBanda() {

        Console.Clear();

        Console.WriteLine("REGISTRO DE BANDAS");
        Console.Write("\nDigite o nome da banda: ");

        string nomeDaBanda = Console.ReadLine()!;
        //listaDasBandas.Add(nomeDaBanda);
        DicionarioBandas.Add(nomeDaBanda, new List<int>());


        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    }

    void ListarBandas(){

        Console.Clear();
        Console.WriteLine("LISTANDO TODAS AS BANDAS >>>>");
        Thread.Sleep(2000);

        // for (int i = 0; i < listaDasBandas.Count; i++) {
        //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
        // }

        foreach (string banda in DicionarioBandas.Keys) {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey(); 
        Console.Clear();
        ExibirOpcoesMenu();

    }

    void AvaliarBanda() {

        Console.Clear();
        Console.WriteLine("AVALIAR BANDA >>>>");
        Console.Write("Qual banda vai ser avaliada? ");
        string nomeDaBanda = Console.ReadLine()!;

        if(DicionarioBandas.ContainsKey(nomeDaBanda)){

            Console.Write($"Qual nota a banda {nomeDaBanda} você deseja atribuir? ");
            int nota = int.Parse(Console.ReadLine()!);

            DicionarioBandas[nomeDaBanda].Add(nota);
            Console.WriteLine($"A nota: {nota}, foi registrada com sucesso para a banda!");
            Thread.Sleep(3000);
            Console.Clear();
            ExibirOpcoesMenu();

        } else {

            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
            Console.ReadKey(); 
            Console.Clear();
            ExibirOpcoesMenu();
        }



    }

    void Mediabandas() {
        Console.Clear();
        Console.WriteLine("MÉDIA POR BANDAS >>>>\n");
        Console.Write("Qual banda você gostaria de ver a média?  ");
        string bandaSelecionada = Console.ReadLine()!;

        if (DicionarioBandas.ContainsKey(bandaSelecionada)){

            List<int> notasDaBanda = DicionarioBandas[bandaSelecionada];
            Console.WriteLine($"\nA média da banda: {bandaSelecionada} é {notasDaBanda.Average()}.");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
            Console.ReadKey(); 
            Console.Clear();
            ExibirOpcoesMenu();
            
        } else {

            Console.WriteLine($"\nA banda {bandaSelecionada} não foi encontrada!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
            Console.ReadKey(); 
            Console.Clear();
            ExibirOpcoesMenu();
        }

    }
        
}


ExibirOpcoesMenu();