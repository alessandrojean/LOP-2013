algoritmo "semnome"
// Função :
// Autor :
// Data : 27/02/2013
// Seção de Declarações 
var
nome: caracter
clube: caracter
clubeluxo: caracter
cidade: caracter
valor: real
acrescimo: real
taxa: real
inicio
// Seção de Comandos 
escreva("Digite o seu nome: ")
leia(nome)
escreva("Digite o seu clube: ")
leia(clube)
escreva("O clube é de luxo? ")
leia(clubeluxo)
escreva("Digite a cidade: ")
leia(cidade)
escreva("Digite o valor: ")
leia(valor)
se cidade="são paulo" entao
valor<-valor+valor*0.1
fimse
se clubeluxo="sim" entao
escreva("Digite a taxa de adesão: ")
leia(taxa)
valor<-valor+taxa
fimse
escreval("Seu nome é ",nome,", seu clube é ",clube,", sua cidade é ",cidade)
escreva("O valor será: ",valor)
fimalgoritmo
