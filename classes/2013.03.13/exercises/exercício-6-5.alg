algoritmo "semnome"
// Função :
// Autor :
// Data : 13/03/2013
// Seção de Declarações 
var
n,soma,media: real
cont:inteiro
resp:caracter
inicio
// Seção de Comandos
soma<-0
cont<-0
resp<-"s"
enquanto resp="s" faca
escreva("Digite o nº: ")
leia(n)
se n>4 entao
soma<-soma+n
cont<-cont+1
fimse
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
media<-soma/cont
escreva("A média dos valores maiores que 4 é: ",media)
fimalgoritmo
