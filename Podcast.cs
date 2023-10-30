class Podcast
{   
    private List<Episodio> episodios = new();

    public Podcast(string nome, string host) 
    { 
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast '{Nome}' apresentado por {Host}\n");

        foreach (var episodio in episodios.OrderBy(ep => ep.Ordem))
        {
            Console.WriteLine($"Episodio {episodio.Ordem}: {episodio.Titulo} ({episodio.Duracao} min)");
        }

        Console.WriteLine($"\n\nEste podcast possui até o momento {TotalEpisodios} episodios");
    }
}