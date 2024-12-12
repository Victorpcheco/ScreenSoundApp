using System.Diagnostics;
using System.Runtime.CompilerServices;

string mensagemBoasVindas = "\nBoas Vindas ao Screen Sound!";
List<string> listaDasBandas = new List<string>();

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
        case 2: Console.WriteLine("Você escolheu a opção 2"); break;
        case 3: Console.WriteLine("Você escolheu a opção 3"); break;
        case 4: Console.WriteLine("Você escolheu a opção 4"); break;
        case -1: Console.WriteLine("Encerrando..."); break;

        default: Console.WriteLine("Opção Inválida"); break;

    }

    void RegistrarBanda() {

        Console.Clear();
        Console.WriteLine("REGISTRO DE BANDAS");
        Console.Write("\nDigite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        listaDasBandas.Add(nomeDaBanda);

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesMenu();
    }

    void ListarBandas(){

        Console.Clear();
        Console.WriteLine("TODAS AS BANDAS >>>>");


    }
        
    

}


ExibirOpcoesMenu();