algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 13/03/2013
// Se��o de Declara��es 
var
n1,n2,n3,nx: inteiro
inicio
// Se��o de Comandos
escreva("1� N�mero: ")
leia(n1)
escreva("2� N�mero: ")
leia(n2)
escreva("3� N�mero: ")
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
escreva("Os n�meros s�o: ", n1,n2,n3)
fimalgoritmo
