//objeto específico para o tipo música
//estou puxando as informações do arquivo música
// como essas variáveis estão publicas no outro
// arquivo eu consigo acessar essa aba

//Console.WriteLine($"Nome: {musica1.nome}");
//Console.WriteLine($"Artista: {musica1.artista}");
// para exibir o que tem dentro do nome da classe música1
// 
//Console.WriteLine($"Nome: {musica2.nome}");
//Console.WriteLine($"Artista: {musica2.artista}");

//Musica musica1 = new Musica();
//musica1.Nome = "Sunflower";
//musica1.Artista = "Post Malone";
//musica1.Duracao = 158;
//musica1.Disponivel = true;


//Musica musica2 = new Musica();
//musica2.Nome = "Circles";
//musica2.Artista = "Post Malone";
//musica2.Duracao = 215;
//musica2.Disponivel = false;

//Console.WriteLine(musica1.DescricaoResumida);
//musica1.ExibirFixaTecnica();
//Console.WriteLine(musica2.DescricaoResumida);
//musica2.ExibirFixaTecnica();

/////código modificado para que fique melhor para leitura e funcionamento com boas práticas/////

Artista Post = new Artista("Post Malone");

Album albumDoPostMalone = new Album("Hollywood's Bleeding");

Musica musica1 = new Musica(Post, "A Thousand Bad Times")
{
    Duracao = 221,
    Disponivel = false,
};
albumDoPostMalone.AdicionarMusica(musica1);

Musica musica2 = new Musica(Post, "Circles")
{
    Duracao = 221,
    Disponivel = true,
};
albumDoPostMalone.AdicionarMusica(musica2);

Musica musica3 = new Musica(Post, "Staring At The Sun")
{
    Duracao = 168,
    Disponivel = false,
};
albumDoPostMalone.AdicionarMusica(musica3);

Musica musica4 = new Musica(Post, "Sunflower")
{
    Duracao = 158,
    Disponivel = true,
};
albumDoPostMalone.AdicionarMusica(musica4);

Musica musica5 = new Musica(Post, "Wow")
{
    Duracao = 150,
    Disponivel = true,
};
albumDoPostMalone.AdicionarMusica(musica5);
albumDoPostMalone.ExibirMusicasDoAlbum();

musica1.ExibirFixaTecnica();
musica2.ExibirFixaTecnica();
musica3.ExibirFixaTecnica();
musica4.ExibirFixaTecnica();
musica5.ExibirFixaTecnica();
Post.AdicionarAlbum(albumDoPostMalone);
Post.ExibirDiscografia();

class Musica
{
    //construtor não tem retorno
    public Musica(Artista artista, string nome)
    {
        Artista = artista;
        Nome = nome;
        //a propriedade Artista recebe o argumento do metodo construtor 
    }

    public string Nome { get; } // letras
    //public para que essa variável "nome" fique publica em outro arquivo
    public Artista Artista { get; } // letras
    public int Duracao { get; set; } // inteiro
    public bool Disponivel { get;set; }// verdadeiro ou falso
    //set e get funciona exatamente como a função abaixo
    //public void EscreveDisponivel(bool value)
    //{
    //    disponivel = value;
    //}
    //set = escreve / get = lê
    // deixo de forma mais clara na hora de escrever
    public string DescricaoResumida => 
        $"A música {Nome} pertence ao artista {Artista}";
    // a mesma coisa que esta escrita em cima
    //{ 
    //get{
    //    return $"A música {Nome} pertence ao artista {Artista}";
    //}

    //}
    // não existe operação de escrita

    public void ExibirFixaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        //precisamos colocar o .Nome pois Artista não é mais uma string 
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano\n");
        }
        else
        {
            Console.WriteLine("Adiquira o plano plus+\n");
        }
    }
} 

class Artista
{
    private List<Album> albums = new List<Album>();

    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add( album );   
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia do artista {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome}({album.DuracaoTotal})");
        }
    }
}

class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal =>
        musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nEsse álbum possui {DuracaoTotal} segundos de duração");
    }
}
