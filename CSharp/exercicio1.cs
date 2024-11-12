Epsodio ep1 = new Epsodio(0, "IGÃO E MÍTICO", 5100);

Epsodio ep2 = new Epsodio(1, "PODEROSÍSSIMO NINJA", 6060);
ep2.AdicionarConvidado("Ninja");
;

Epsodio ep3 = new Epsodio(2, "NEW YORK TRETA", 9840);
ep3.AdicionarConvidado("Matheus Verçosa");
ep3.AdicionarConvidado("Daniel Verçosa");

Podcast podcast = new("Podpah", "Igão e Mítico");
podcast.AdicionarEpsodio(ep1);
podcast.AdicionarEpsodio(ep2);
podcast.AdicionarEpsodio(ep3);
podcast.ExibirDetalhes();

class Podcast
{
    private List<Epsodio> epsodios = new List<Epsodio>();

    public Podcast(string nomeDoPodcast, string host)
    {
        NomeDoPodcast = nomeDoPodcast;
        Host = host;
    }

    public string NomeDoPodcast { get; }
    public string Host { get; }
    public int TotalEpsodios => epsodios.Count;

    public void AdicionarEpsodio(Epsodio epsodio)
    {
        epsodios.Add(epsodio);
    }

    public int DuracaoTotalDoPodcast =>
        epsodios.Sum(e => e.Duracao);

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {NomeDoPodcast} apresentado por {Host}\n");
        foreach (Epsodio epsodio in epsodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(epsodio.Resumo);
        }
        Console.WriteLine($"Total de epsodios: {TotalEpsodios}");
    }

}

class Epsodio
{
    private List<string> convidados = new();

    public Epsodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo =>
        $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}