algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 03/04/2013
// Se��o de Declara��es 
var
nome,resp:caracter
letra:caracter
i,tam:inteiro
inicio
// Se��o de Comandos 
resp<-"s"
enquanto resp="s" faca
letra<-""
i<-0
tam<-0
escreva("Nome: ")
leia(nome)
enquanto letra<>"$" faca
i<-i+1
letra<-copia(nome,i,1)
se (letra="$") ou (letra="") entao
letra<-"$"
senao
tam<-tam+1
fimse
fimenquanto
escreval("Nome: ",nome,". Tamanho: ",tam)
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
fimalgoritmo
