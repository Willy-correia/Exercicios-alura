using System;

Console.WriteLine("\n\n#### Segundo exercício ####\n");
//Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
int notaMedia = 5;
if (notaMedia <= 5)
{
    Console.WriteLine("Nota suficiente para aprovação\n");
}
//Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
List<string> listas = ["C#", "Java", "JavaScript"];

//Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
foreach (string lista in listas)
{
    Console.Write(lista + " \n");
}

//Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
string posicaoEscolhida = Console.ReadLine()!;// "!" serve para você não aceitar valores nulos e ele é colocado logo após o "ReadLine()" e antes do ";"
int posicaoEscolhidaNumerica = int.Parse(posicaoEscolhida);
switch (posicaoEscolhidaNumerica)
{
    case 1:
        Console.WriteLine(listas[posicaoEscolhidaNumerica - 1]);
        break;
    case 2:
        Console.WriteLine(listas[posicaoEscolhidaNumerica - 1]);
        break;
    case 3:
        Console.WriteLine(listas[posicaoEscolhidaNumerica - 1]);
        break;
    default:
        Console.WriteLine("Numero escolhido fora do intervalo!");
        break;
}