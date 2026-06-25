List<Filme> listaFilmes = new List<Filme>();
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
            Filme novoFilme = new Filme();
            Console.Write("Título: ");
            novoFilme.titulo = Console.ReadLine();
            Console.Write("Genero: ");
            novoFilme.genero = Console.ReadLine();
            Console.Write("Ano lançamento: ");
            novoFilme.anoLancamento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Classificação Indicativa:");
            novoFilme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());
            listaFilmes.Add(novoFilme);
            Console.WriteLine("\n filme cadastrado com sucesso!");
            break;

        case 2:
            if (listaFilmes.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
            }
            else
            {
                foreach (var filme in listaFilmes)
                {
                    filme.ExibirInformarcoes();
                }
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