using System;


class Program
{
    static void Main()
    {
        Livro livro = new Livro();
        bool executando=true;

        while(executando)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("         Library Hub         ");
            Console.WriteLine("=============================");

            Console.WriteLine("1 - Livros");
            Console.WriteLine("0 - sair");

            Console.WriteLine("=============================");

            Console.WriteLine("Escolha uma das opções acima:");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if(opcao != 0 && opcao != 1)
            {
                Console.WriteLine("\nOpção inválida.\n");
            } 
            else if(opcao == 1)
            {
                Console.WriteLine("\nCadastro automatico ativado:\n");
                livro.Titulo = "Oroborus";
                livro.Autor = "Bocadinhas";
                livro.Editora = "Books & Books";
                livro.ISBN = "666-66-333-0006-3";
                livro.Paginas = 66;
                livro.Ano = 1997;
                livro.Disponivel = false;

                Console.WriteLine("\n** Primeiro livro cadastrado **\n");
                Console.WriteLine($"Titulo: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
                Console.WriteLine($"Editora: {livro.Editora}");
                Console.WriteLine($"ISBN: {livro.ISBN}");
                Console.WriteLine($"Paginas: {livro.Paginas}");
                Console.WriteLine($"Ano: {livro.Ano}");
                Console.WriteLine($"Disponivel: {livro.Disponivel}");
            }
            else
            {
                Console.WriteLine("Volte sempre!");
                executando = false;
            }
        }

    }
}
