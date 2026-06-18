public class Filme
{
    public string titulo;
    public string genero;
    public int anoLancamento;
    public int classificacaoIndicativa;

    public void ExibirInformarcoes()
    {
        Console.WriteLine("\n === Cadastro Filme ===");
        Console.WriteLine($"Nome: {titulo}");
        Console.WriteLine($"Genero: {genero}");
        Console.WriteLine($"Ano de lançamento: {anoLancamento}");
        Console.WriteLine($"Classificação: {ObterClassificacao()}");
    }

    public string ObterClassificacao()
    {
        if (classificacaoIndicativa <=0)
        {
            return "Livre";
        }
        return classificacaoIndicativa + "anos";
    }
}