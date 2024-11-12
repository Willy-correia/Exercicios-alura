//Crie um programa que utilize o console.log para exibir uma mensagem de boas-vindas.
console.log("Bem vindo ao programa!");
//questão1

//Crie uma variável chamada "nome" e atribua a ela o seu nome. 
//Em seguida, utilize o console.log para exibir a mensagem "Olá, [seu nome]!" 
//no console do navegador.
let nome2 = "Willy";
console.log(`Olá, ${nome2}`);
//questão2

//Crie uma variável chamada "nome" e atribua a ela o seu nome. Em seguida, utilize 
//o alert para exibir a mensagem "Olá, [seu nome]!" .
let nome3 = "Willy";
alert(`Olá, ${nome3}`);
//questão3

//Utilize o prompt e faça a seguinte pergunta: Qual a linguagem de programação que 
//você mais gosta?. Em seguida, armazene a resposta em uma variável e mostre no 
//console do navegador.
let linguagemMaisGosta = prompt("Qual a linguagem que você mais gosta? ");
console.log(linguagemMaisGosta);
//questão4

//Crie uma variável chamada "valor1" e outra chamada "valor2", atribuindo a elas 
//valores numéricos de sua escolha. Em seguida, realize a soma desses dois valores 
//e armazene o resultado em uma terceira variável chamada "resultado". Utilize o 
//console.log para mostrar a mensagem "A soma de [valor1] e [valor2] é igual a 
//[resultado]." no console.
let valor15 = 20;
let valor25 = 31;
let resultado5 = valor15 + valor25;
console.log(`A soma de ${valor15} e ${valor25} é igual a ${resultado5}.`);
//questão5

//Crie uma variável chamada "valor1" e outra chamada "valor2", atribuindo a elas 
//valores numéricos de sua escolha. Em seguida, realize a subtração desses dois 
//valores e armazene o resultado em uma terceira variável chamada "resultado". 
//Utilize o console.log para mostrar a mensagem "A diferença entre [valor1] e 
//[valor2] é igual a [resultado]." no console.
let valor16 = 16;
let valor26 = 5;
let resultado6 = valor16 - valor26;
console.log(`A diferença entre ${valor16} e ${valor26} é igual a ${resultado6}.`);
//questão6

//Peça ao usuário para inserir sua idade com prompt. Com base na idade inserida, 
//utilize um if para verificar se a pessoa é maior ou menor de idade, exibindo uma 
//mensagem apropriada no console.
let idade = prompt("Digite sua idade: ");
if(idade >= 18){
    console.log("Você é maior de idade!");
}else{
    console.log("Você é menor de idade");
}
//questão7

//Crie uma variável "numero" e peça um valor com prompt verifique se é positivo, 
//negativo ou zero. Use if-else para imprimir a respectiva mensagem.
let numero8 = prompt("Digite um número qualquer: ");
if(numero8 > 0){
    console.log(`O valor ${numero8} é positivo`);
}else if(numero8 < 0){
    console.log(`O número ${numero8} é negativo`);
}else{
    console.log(`O número ${numero8} é nulo (ou melhor zero)`);
}
//questão8

//Use um loop while para imprimir os números de 1 a 10 no console.
let contador = 1;
while(contador<=10){
    console.log(contador);
    contador++;
}
//questão9

//Crie uma variável "nota" e atribua um valor numérico a ela. Use if-else para 
//determinar se a nota é maior ou igual a 7 e exiba "Aprovado" ou "Reprovado" no console.
let nota = 6;
if(nota >= 7){
    console.log("Aprovado");
}else{
    console.log("Reprovado");
}
//questão10

//Use o Math.random para gerar qualquer número aleatório e exiba esse número no console.
let numeroAleatorio11 = Math.random()
console.log(`O número aleatório é ${numeroAleatorio11}`);
//questão11

//Use o Math.random para gerar um número inteiro entre 1 e 10 e exiba esse número no console.
let numeroAleatorio12 = parseInt(Math.random() * 10 + 1);
console.log(`O número aleatório é ${numeroAleatorio12}`);
//questão 12

//Use o Math.random para gerar um número inteiro entre 1 e 1000 e exiba esse número no console.
let numeroAleatorio13 = parseInt(Math.random() * 1000 + 1);
console.log(`O número aleatório é ${numeroAleatorio13}`);
//questão13
