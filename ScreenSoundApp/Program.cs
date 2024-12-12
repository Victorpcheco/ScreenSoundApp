﻿using System.Diagnostics;
using System.Runtime.CompilerServices;

string mensagemBoasVindas = "\nBoas Vindas ao Screen Sound!";
//List<string> listaDasBandas = new List<string>{"Charlie Brown Junior", "The Beatles"};
Dictionary<string, List<int>> DicionarioBandas = new Dictionary<string, List<int>>();



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
        
    

}


ExibirOpcoesMenu();