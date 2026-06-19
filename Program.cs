Filme filme = new Filme();

int opcao;

do
{
    Console.WriteLine("\n====CATÁLOGO DE FILMES====");
    Console.WriteLine("1 - Cadastrar Filme");
    Console.WriteLine("2 - Exibir Filme");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Título: ");
            filme.titulo = Console.ReadLine();
            Console.Write("Genero: ");
            filme.genero = Console.ReadLine();
            Console.Write("Ano lançamento: ");
            filme.anoLancamento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Classificação Indicativa:");
            filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n filme cadastrado com sucesso!");
            break;

        case 2:
            if (string.IsNullOrEmpty(filme.titulo))
            {
                Console.WriteLine("Nenhum filme cadastrado.");
            }
            else
            {
                filme.ExibirInformarcoes();
            }
            break;

        case 0:
            Console.WriteLine("\nPrograma encerrado.");
            break;

        default:
            Console.WriteLine("\nOpção inválida");
            break;



    }

} while (opcao != 0);




filme.ExibirInformarcoes();

