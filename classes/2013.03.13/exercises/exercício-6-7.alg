algoritmo "semnome"
// Função :
// Autor :
// Data : 13/03/2013
// Seção de Declarações 
var
n1,n2,n3,nx: inteiro
inicio
// Seção de Comandos
escreva("1º Número: ")
leia(n1)
escreva("2º Número: ")
leia(n2)
escreva("3º Número: ")
leia(n3)
se n1>n2 entao
nx<-n2
n2<-n1
n1<-nx
fimse
se n2>n3 entao
nx<-n3
n3<-n2
n2<-nx
fimse
se n1>n2 entao
nx<-n2
n2<-n1
n1<-nx
fimse
escreva("Os números são: ", n1,n2,n3)
fimalgoritmo
