algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 27/03/2013
// Se��o de Declara��es 
var
data:caracter
datacopia: caracter
resp: caracter
inicio
// Se��o de Comandos 
resp<-"s"
enquanto resp="s" faca
escreva("Data: ")
leia(data)
datacopia<-copia(data,4,2)
se datacopia=09 entao
escreva("Essa data � do m�s 9")
fimse
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
fimalgoritmo
