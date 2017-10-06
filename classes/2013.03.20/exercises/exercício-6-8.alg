algoritmo "semnome"
// Função :
// Autor :
// Data : 20/03/2013
// Seção de Declarações 
var
num: real
media,soma: real
cont:inteiro
resp:caracter
inicio
// Seção de Comandos 
resp<-"s"
soma<-0
cont<-0
enquanto resp="s" faca
escreva("Numero: ")
leia(num)
soma<-soma+num
escreva("Deseja continuar (S/N): ")
leia(resp)
cont<-cont+1
fimenquanto
media<-soma/cont
se media>8 entao
media<-10
fimse
escreva("A média é: ", media)
fimalgoritmo
