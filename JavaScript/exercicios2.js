+function dias(){
    let DiaDaSemana = prompt("Qual o dia da semana? ");
    if(DiaDaSemana == "Sábado" || DiaDaSemana == "Domingo"){
        alert("Bom fim de semana!");
    }else if(DiaDaSemana == "Segunda" || DiaDaSemana == "Terça" || DiaDaSemana == "Quarta" || DiaDaSemana == "Quinta" || DiaDaSemana == "Sexta"){
        alert("Boa semana!");
    }else{
        alert("Digite o dia da semana no formato Sábado/Segunda/Terça");
        dias();
    }
}

function positivoNegativo(){
    let numero = alert("Digite um número inteiro: ");
    if(numero>=0){
        alert("Número positivo");
    }else if (numero < 0){
        alert("Número negativo");
    }else{
        alert ("Digite um número válido!")
        positivoNegativo();
    }
}

function pontuacao(){
    pontos = prompt("Escreva a sua pontuação: ");
    if(pontos >= 100){
        alert ("Parabéns, você venceu!");
    }else{
        alert("Tente novamente para ganhar.");
    }
}

function saldoDaConta(){
    saldo = 4500;
    alert(`Seu saldo da conta está R$${saldo}`);
}

function bemVindo(){
    nome = prompt("Escreva o seu nome: ");
    alert("Bem vindo(a) " + nome);
}

dias();//1.questão
positivoNegativo();//2.questão
pontuacao()//3.questão
saldoDaConta()//4.questão
bemVindo()//5.questão