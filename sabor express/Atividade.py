#1 - Crie um dicionário representando informações sobre uma pessoa, como nome, idade e cidade.
#2 - Utilizando o dicionário criado no item 1:
#Modifique o valor de um dos itens no dicionário (por exemplo, atualize a idade da pessoa);
#Adicione um campo de profissão para essa pessoa;
#Remova um item do dicionário.
#3 - Crie um dicionário utilizando para representar números e seus quadrados de 1 a 5.
#4 - Crie um dicionário e verifique se uma chave específica existe dentro desse dicionário.
#5 - Escreva um código que conte a frequência de cada palavra em uma frase utilizando um dicionário.

pessoas = {"nome" : "Jessica","idade" : 20,"cidade" : "Natal"} #1
######################### Questão 1 ###########################################

pessoas["idade"] = 22
print (pessoas)# 2.1

pessoas["profissão"] = "Médica"
print (pessoas) #2.2

del pessoas ["nome"] 
print (pessoas)#2.3

########################### Questão 2 ####################################

quadrados = {n : n**2 for n in range(1,6)}
print(quadrados)#3

########################## Questão 3 #########################################
dicionario_aleatorio = {"numero da casa" : 356, "local" : "disney", "morador" : "mickey"}

categoria = "casa"

try:
    categoria1 = "local"
    print (f"A categoria {categoria1} é {dicionario_aleatorio[categoria1]}")
    categoria2 = "distância"
    print (dicionario_aleatorio[categoria2])
except:
    print (f"A categoria {categoria2} não existe no dicionário")
############################ Questão 4 ##############################################

frase = "o rato roeu a roupa do rei de roma e o rei de roma decidiu se vingar do rato"

contagem_palavras = {}

palavras = frase.split()

for palavra in palavras:
    contagem_palavras[palavra] = contagem_palavras.get(palavra, 0) + 1

print(contagem_palavras)
#Ele vai verificando as palavras uma de cada vez, e se por um acaso a palavra ja estiver lá na contagem, ele coloca a
#proxima no mesmo local que a primeira e acrescenta mais 1 na contagem
