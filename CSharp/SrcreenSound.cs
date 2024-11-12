// Scream Sound
// C# é extremamente tipada (precisa sempre declarar uma variável)

//string mensagemDeBoasVindas = "Boas Vindas ao Scream Sound"; //string serve declarar para colocar frases
// Padrão camel case (1 palavra letra minuscula e o resto com letra maiuscula)
//List<string> ListaDeBandas = new List<string>{"Post Malone", "One Direction", "Cold Play"}; 
// Declarando uma lista e depois demos um nome a ela e logo após 
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
//Criei um dicionario de strings com uma lista de inteiros dentro dela
bandasRegistradas.Add("Post Malone", new List<int>{10, 9, 10});
bandasRegistradas.Add("Imagine Dragons", new List<int>());

void ExibirMensagemBemVindo()
// void quer dizer que uma função não retorna nada para a função main
// estamos utilizando o estilo Pascalcase para padronizar nossas funções(toda primeira letra das palavras letra maiuscula)
{
    Console.WriteLine(@"
 ██████╗ █████╗ ██████╗ ███████╗███████╗███╗  ██╗   ██████╗ █████╗ ██╗   ██╗███╗  ██╗██████╗ 
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗ ██║  ██╔════╝██╔══██╗██║   ██║████╗ ██║██╔══██╗
╚█████╗ ██║  ╚═╝██████╔╝█████╗  █████╗  ██╔██╗██║  ╚█████╗ ██║  ██║██║   ██║██╔██╗██║██║  ██║
 ╚═══██╗██║  ██╗██╔══██╗██╔══╝  ██╔══╝  ██║╚████║   ╚═══██╗██║  ██║██║   ██║██║╚████║██║  ██║
██████╔╝╚█████╔╝██║  ██║███████╗███████╗██║ ╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║ ╚███║██████╔╝
╚═════╝  ╚════╝ ╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚══╝  ╚═════╝  ╚════╝  ╚═════╝ ╚═╝  ╚══╝╚═════╝ 
"); // "@" = Verbatim literal = colocar a string exatamente como ela vai aparecer
    Console.WriteLine("Boas Vindas ao Screen Sound");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda"); // "\n" serve para pular uma linha no console
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir uma média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; 
    // "!" no final do Console.ReadLine() quer dizer que nós não queremos que retorne valores nulos
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); 
    //para transformar a opcaoEscolhida em inteiro (".parse" pega um texto e tenta converter para inteiro)

    switch (opcaoEscolhidaNumerica)//mesma coisa que o if else porem mais compacto
    {
        case 1: RegistrarBanda(); //chamando a função
            break; //Sempre usar o break;
        case 2: ExibirBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirAvaliacoesDaBanda();
            break;
        case -1:
            Console.Clear();
            Console.WriteLine("Tchau Tchau!");
            break;
        default:
            Console.WriteLine("Digite uma opção válida");
            Console.Clear();
            ExibirOpcoesDoMenu();
            break;
    }
}

void RegistrarBanda()
{
    ExibirTituloDaPagina("Registrando Bandas");
    Console.Write("Digite o nome da banda que deseja registra: "); // Consegue deixar escrever logo em seguida da frase
    String nomeDaBanda = Console.ReadLine()!;
    //ListaDeBandas.Add(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso"); 
    //O uso de "$" antes das aspas faz com que consigamos colocar ($"letras e {variaveis}")
    Console.WriteLine("\nDigite uma tecla para voltar para o menu principal");
    Console.ReadKey(); //para que o usuario clique em qualquer tecla do mouse para executar o próximo passo
    Thread.Sleep(2000); //esperar 2000 milisegundos para poder executar o próximo passo
    Console.Clear(); //Limbar o console
    ExibirOpcoesDoMenu();
}
void ExibirBandasRegistradas()
{
    ExibirTituloDaPagina("Exibindo as bandas registradas");
    //for (int i =0; i < ListaDeBandas.Count; i++)
    ////para i = contador inteiro = 0,
    ////i menor que a quantidade de itens (ListaDeBandas.Count) que tem no lista de bandas,
    ////(i = i+1) == i++;
    //{
    //    Console.WriteLine($"Banda: {ListaDeBandas[i]}");
    //}
    foreach(string banda in bandasRegistradas.Keys)
    //para cada (banda na minha lista de bandas) {fazer isso}
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaPagina(string titulo) // recebo uma string de outra função quando essa fuñção é chamada
{
    Console.Clear(); // para limpar o console
    int quantidadeDeCaracteres = titulo.Length; 
    // colocar em uma variavel int a quantidade de caracteres que possui o titulo
    string asteriscos = string.Empty.PadLeft(quantidadeDeCaracteres, '*');
    // Colocar em uma variavel uma variável onde se inicia vazia  .Padleft(quantoscaracteres, 'qual caractere')
    // para criar um looping apenas com um caractere
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}

void AvaliarUmaBanda()
{
    ExibirTituloDaPagina("Avaliar uma banda");
    //digitar qual banda deseja avaliar
    //se a banda existir no dicionário >> atribuir nota
    //se não existir exibir mensagem e voltar ao menu
    Console.Write("Digite o nome da banda que deseja atribuir uma nota: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Digite qual a nota que você da a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota); 
        // quando eu chamo o dicionário[parte do dicionário que eu quero abrir].Adicionar na lista(notas)
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Console.WriteLine("\nDigite uma tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi registrada\n");
        Console.WriteLine($"Digite 1 para Registrar {nomeDaBanda}");
        Console.WriteLine("Digite 2 para tentar outra banda");
        Console.WriteLine("Digite -1 para voltar ao menu principal");
        string opcaoEscolhidaDentroDeAvaliarBanda = Console.ReadLine()!;
        int opcaoEscolhidaDentroDeAvaliarBandaNumerica = int.Parse(opcaoEscolhidaDentroDeAvaliarBanda);
        switch (opcaoEscolhidaDentroDeAvaliarBandaNumerica)
        {
            case 1: Console.Clear();
                RegistrarBanda();
                break;
            case 2: Console.Clear();
                AvaliarUmaBanda();
                break;
            case -1: Console.Clear();
                ExibirOpcoesDoMenu();
                break;
        }
    }
}
void ExibirAvaliacoesDaBanda(){
    ExibirTituloDaPagina("Exibir a média de uma banda");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    //se a na biblioteca bandasRegistradas conter nas chaves o nomeDaBanda executar isso
    {
        List<int> listaComAvaliacoes = bandasRegistradas[nomeDaBanda]; 
        // colocando todos os números contidos na biblioteca bandasRegistradas dentro chave nomeDaBanda
        Console.WriteLine($"A média das avaliações da banda {nomeDaBanda} é de {listaComAvaliacoes.Average()}\n");

        Console.WriteLine("Digite 1 para escolher outra banda");
        Console.WriteLine("Digite 2 para avaliar uma banda");
        Console.WriteLine("Digite -1 para voltar ao menu");
        int opcaoEscolhida = int.Parse(Console.ReadLine()!);
        switch (opcaoEscolhida)
        {
            case 1:
                Console.Clear();
                ExibirAvaliacoesDaBanda();
                break;
            case 2:
                Console.Clear();
                AvaliarUmaBanda();
                break;
            case -1:
                Console.Clear();
                ExibirOpcoesDoMenu();
                break;
        }
    }
    else 
    {
        Console.WriteLine($"A banda {nomeDaBanda} não está registrada!\n");
        Console.WriteLine("Digite 1 para Registrar banda");
        Console.WriteLine("Digite 2 para exibir a média de outra banda");
        Console.WriteLine("Digite -1 para retornar para o menu principal");
        int opcaoEscolhida = int.Parse(Console.ReadLine()!);
        switch (opcaoEscolhida)
        {
            case 1:
                Console.Clear();
                RegistrarBanda();
                break;
            case 2:
                Console.Clear();
                ExibirAvaliacoesDaBanda();
                break;
            case -1:
                Console.Clear();
                ExibirOpcoesDoMenu();
                break;
        }
    }
}


ExibirMensagemBemVindo();
ExibirOpcoesDoMenu();