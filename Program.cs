using System;

class Program
{
    static void Main()
    {
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
                Console.WriteLine("\nBiblioteca de livros ainda em desenvolvimento...\n");    
            }
            else
            {
                Console.WriteLine("Volte sempre!");
                executando = false;
            }
        }

    }
}
