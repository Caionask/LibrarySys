using System;


class Program
{
    static void Main()
    {
        Livro livro = new Livro();
        bool executando = true;
        bool disponibilidade;
        string opcao;

        while(executando)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("         Library Hub         ");
            Console.WriteLine("=============================");

            Console.WriteLine("1 - Livros");
            Console.WriteLine("0 - sair");

            Console.WriteLine("=============================");

            Console.WriteLine("Escolha uma das opções acima:");
            int menu1 = Convert.ToInt32(Console.ReadLine());

            if(menu1 != 0 && menu1 != 1)
            {
                Console.WriteLine("\nOpção inválida.\n");
            } 
            else if(menu1 == 1)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("            Livros           ");
                Console.WriteLine("=============================\n");

                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Consultar");

                Console.WriteLine("=============================\n");

                Console.WriteLine("Escolha uma das opções acima:");
                int menu2 = Convert.ToInt32(Console.ReadLine());

                if(menu2 != 2 && menu2 != 1)
                {
                    Console.WriteLine("\nOpção inválida.\n");                        
                }
                    else if (menu2 == 1)
                {
                    Console.WriteLine("\nAdicione um Titulo:\n");
                    livro.Titulo = Console.ReadLine();  
                    Console.WriteLine("\nAdicione um Autor:\n");
                    livro.Autor = Console.ReadLine();
                    Console.WriteLine("\nAdicione uma Editora:\n");
                    livro.Editora = Console.ReadLine();
                    Console.WriteLine("\nAdicione um ISBN (***-**-***-****-*):\n");
                    livro.ISBN = Console.ReadLine();
                    Console.WriteLine("\nAdicione um numero de paginas:\n");
                    livro.Paginas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nAdicione um Ano:\n");
                    livro.Ano = Convert.ToInt32(Console.ReadLine());
                    disponibilidade = false;
                    Console.WriteLine("\nO livro está disponivel? Sim/Nao\n");
                    while (disponibilidade == false)
                    {
                        opcao = Console.ReadLine();
                    if(opcao != "Sim" && opcao != "Nao")
                        {
                            Console.WriteLine("Opcao invalida. Digite exatamente 'Sim' ou 'Nao'");
                        }
                        else if (opcao == "Sim")
                        {
                            livro.Disponivel = true;
                            disponibilidade = true;
                        }
                        else
                        {
                            livro.Disponivel = false;
                            disponibilidade = true;
                        }
                    }
                    Console.WriteLine("\nLivro adicionado com sucesso.\n");
                }
                else
                {
                    Console.WriteLine("\n** Livros cadastrados: **\n");
                    Console.WriteLine($"Titulo: {livro.Titulo}");
                    Console.WriteLine($"Autor: {livro.Autor}");
                    Console.WriteLine($"Editora: {livro.Editora}");
                    Console.WriteLine($"ISBN: {livro.ISBN}");
                    Console.WriteLine($"Paginas: {livro.Paginas}");
                    Console.WriteLine($"Ano: {livro.Ano}");
                    if (livro.Disponivel)
                        Console.WriteLine("Disponivel: Sim");
                    else
                        Console.WriteLine("Disponivel: Nao");
                }             
            }
            else
            {
                Console.WriteLine("Volte sempre!");
                executando = false;
                return;
            }
        }
    }
}

