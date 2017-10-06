algoritmo "semnome"
// Função :
// Autor :
// Data : 20/03/2013
// Seção de Declarações 
var
nome:caractere
resp:caractere
cor:caractere
totcor:inteiro
inicio
// Seção de Comandos
totcor<-0
resp<-"s"
enquanto resp="s" faca
escreva("Nome: ")
leia(nome)
escreva("Cor: ")
leia(cor)
se cor="azul" entao
totcor<-totcor+1
fimse
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
escreva("Total de carros azuis: ",totcor)
fimalgoritmo
