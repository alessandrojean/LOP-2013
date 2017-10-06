algoritmo "semnome"
// Função :
// Autor :
// Data : 03/04/2013
// Seção de Declarações 
var
nome,resp:caracter
letra:caracter
i,tam,par:inteiro
inicio
// Seção de Comandos 
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
par<-copia(tam,2,1)
fimenquanto
se (par=0) ou (par=2) ou (par=4) ou (par=6) ou (par=8) entao
escreval("Nome: ",nome,". Tamanho: ",tam)
fimse
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
fimalgoritmo
