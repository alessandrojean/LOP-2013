algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 27/02/2013
// Se��o de Declara��es 
var
nome: caracter
clube: caracter
clubeluxo: caracter
cidade: caracter
valor: real
acrescimo: real
taxa: real
inicio
// Se��o de Comandos 
escreva("Digite o seu nome: ")
leia(nome)
escreva("Digite o seu clube: ")
leia(clube)
escreva("O clube � de luxo? ")
leia(clubeluxo)
escreva("Digite a cidade: ")
leia(cidade)
escreva("Digite o valor: ")
leia(valor)
se cidade="s�o paulo" entao
valor<-valor+valor*0.1
fimse
se clubeluxo="sim" entao
escreva("Digite a taxa de ades�o: ")
leia(taxa)
valor<-valor+taxa
fimse
escreval("Seu nome � ",nome,", seu clube � ",clube,", sua cidade � ",cidade)
escreva("O valor ser�: ",valor)
fimalgoritmo
