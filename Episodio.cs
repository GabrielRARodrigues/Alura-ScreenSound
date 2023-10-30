class Episodio
{
    public Episodio(string titulo, int ordem, int duracao) 
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    private List<string> convidados = new();

    public string Titulo { get; }
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"O episódio {Titulo} de número {Ordem} e duracação em minutos de {Duracao}, possui os seguintes convidados: {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}