algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 13/03/2013
// Se��o de Declara��es 
var
n,soma,media: real
cont:inteiro
resp:caracter
inicio
// Se��o de Comandos
soma<-0
cont<-0
resp<-"s"
enquanto resp="s" faca
escreva("Digite o n�: ")
leia(n)
se n>4 entao
soma<-soma+n
cont<-cont+1
fimse
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
media<-soma/cont
escreva("A m�dia dos valores maiores que 4 �: ",media)
fimalgoritmo
