List<Filme> listaFilmes = new List<Filme>();
int opcao;

do
{
    Console.WriteLine("\n====CATÁLOGO DE FILMES====");
    Console.WriteLine("1 - Cadastrar Filme");
    Console.WriteLine("2 - Exibir Filme");
    Console.WriteLine("3 - Procurar Filme");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());
    int ano;
    switch (opcao)
    {
        case 1:
            Filme novoFilme = new Filme();
            Console.Write("Título: ");
            novoFilme.titulo = Console.ReadLine();
            Console.Write("Genero: ");
            novoFilme.genero = Console.ReadLine();
            do
            {
                Console.Write("Ano lançamento(1888 até 2026): ");
                ano = Convert.ToInt32(Console.ReadLine());

                if (ano < 1888 || ano > 2026)
                {
                    Console.WriteLine("Ano inválido! Digite um ano real entre 1888 e 2026.");
                }
            } while (ano < 1888 || ano > 2026);
            novoFilme.anoLancamento = ano;

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

        case 3:
            Console.Write("Digite o título para buscar: ");
            string termoBusca = Console.ReadLine();
            bool encontrado = false;

            foreach(var filme in listaFilmes)
            {
                if (filme.titulo.ToLower().Contains(termoBusca.ToLower()))
                {
                    filme.ExibirInformarcoes();
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("\n Nenhum filme encontrado com esse termo.");
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