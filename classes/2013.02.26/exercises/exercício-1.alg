algoritmo "semnome"
// Função :
// Autor :
// Data : 26/02/2013
// Seção de Declarações 
var
nome: caracter
fabricante: caracter
valor: real
desconto: real
valorfinal: real
inicio
// Seção de Comandos 
escreva("Digite o seu nome: ")
leia(nome)
escreva("Digite o fabricante: ")
leia(fabricante)
escreva("Digite o valor: ")
leia(valor)
se fabricante="volks" entao
desconto<-valor*0.1
fimse
se fabricante="ford" entao
desconto<-valor*0.05
fimse
se fabricante="toyota" entao
desconto<-valor*0.03
fimse
valorfinal<-valor-desconto
escreva("O valor a pagar será: ",valorfinal)
fimalgoritmo
