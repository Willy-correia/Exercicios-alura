numeros = [1,2,3,4,5,6,7,8,9,10] #primeira questão
nomes = ["ana", "clara", "brenda"] #primeira questão
anos = [2004, 2024] #primeira questão
listas = [23,45,0,82,"b",55,"a"]
teste = []

def ler_lista(listas):
    for lista in listas:
        print (f".{lista}")

def soma_dos_numeros_impares():
    soma = 0
    for numero in numeros:
        if(numero%2!=0):
            soma += numero
    print(f"A soma dos números ímpares entre 1 e 10 é {soma}")

def invertido():
    for numero in numeros[::-1]:
        print(numero)

def tabuada():
    try:
        numero_do_usuario = int(input("\n->digite um número para saber a tabuada dele: "))
        for contador in range(1, 11):
            multiplicacao = numero_do_usuario*contador
            print (f"A multiplicação entre {numero_do_usuario} e o {contador} é de {multiplicacao}") 
    except:
        tabuada()

def soma_dos_elementos ():
    soma = 0
    for lista in listas:
        try:
            soma += lista
        except:
            pass
    print(f"A soma dos elementos da lista é {soma}")
    
def media_da_lista (listas):
    soma = 0
    for lista in listas: 
        soma += lista
    try:
        media = soma/len(listas)
        print (f"A média dos números da lista é {media}")
    except:
        print ("Não é possivel fazer esse calculo")
    
print ("\nNúmeros:")
ler_lista(numeros) #segunda questão
soma_dos_numeros_impares() #terceira questão
invertido() #quarta questão

print ("\nNomes:")
ler_lista(nomes) #segunda questão

print ("\nAnos:")
ler_lista(anos) #segunda questão

tabuada() #quinta questão

soma_dos_elementos ()#questão seis

media_da_lista (numeros) #questão sete
media_da_lista (anos) #questão sete
media_da_lista (teste) #questão sete
