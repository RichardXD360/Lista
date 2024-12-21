using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> ListaToDo = new List<string>(); // Adição da lista para CheckList
        List<string> NotePad = new List<string>();
        List<string> NotePadTitle = new List<string>();
        string comando = "";

        while (comando != "SAIR")
        {
            Console.WriteLine("O que deseja realizar?");
            Console.WriteLine("Ler, Escrever, Sair"); //As funções ADD, VER e REMOVER foram excluidas
            comando = Console.ReadLine().ToUpper();

            switch (comando)
            {
                case "ADD":
                    AddItem(ListaToDo);
                    break;

                case "VER":
                    VerItem(ListaToDo);
                    break;

                case "REMOVER":
                    RemoverItem(ListaToDo);
                    break;

                case "LER":
                    if (NotePad.Count <= 0)
                    {
                        Console.WriteLine("Não há Blocos de notas disponiveis, crie um novo com o método ESCREVER");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Abaixo estão os Notepads feitos por você");
                        for(int i = 0; i < NotePad.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}-{NotePadTitle[i]}");
                        }
                        Console.Write("Qual deseja visualizar: ");
                        string user_command = Console.ReadLine();
                        int user_intcommand = int.Parse(user_command);
                        Leitor leitor_txt = new Leitor();
                        leitor_txt.Ler(NotePadTitle[user_intcommand - 1]+".txt");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;

                case "ESCREVER":
                    Console.Clear() ;
                    Console.Write("Insira o titulo do documento: ");
                    string titulo = Console.ReadLine();
                    Console.WriteLine("Insira as informações que deseja colocar no texto");
                    string texto = Console.ReadLine();
                    NotePad.Add(texto);
                    NotePadTitle.Add(titulo);
                    Escrever escrever = new Escrever();
                    escrever.Escreva($"{titulo}.txt", texto);
                    break;

                case "SAIR":
                    Console.WriteLine("Saindo...");
                    break;
            }
        }
    }

    static void AddItem(List<string> ListaToDo)
    {
        Console.Clear();
        Console.WriteLine("Adicione itens aqui:");
        string item = Console.ReadLine();
        ListaToDo.Add(item);
        Console.WriteLine("Item adicionado.");
        Thread.Sleep(2000);
        Console.Clear();
    }

    static void VerItem(List<string> ListaToDo)
    {
        if (ListaToDo.Count > 0)
        {
            Console.WriteLine("Segue itens da sua lista:");
            for (int i = 0; i < ListaToDo.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {ListaToDo[i]}");
            }
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Não há itens na lista, adicione-os primeiro");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }

    static void RemoverItem(List<string> ListaToDo)
    {
        Console.WriteLine("Segue itens da Lista:");
        for (int i = 0; i < ListaToDo.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {ListaToDo[i]}");
        }
        Console.WriteLine("Cite o número do item que deseja remover:");
        string item_remove = Console.ReadLine();
        bool correto = int.TryParse(item_remove, out int item_removido);
        if (correto && item_removido > 0 && item_removido <= ListaToDo.Count)
        {
            ListaToDo.RemoveAt(item_removido - 1);
            Console.WriteLine("Item removido.");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Item inválido.");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
