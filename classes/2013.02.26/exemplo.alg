algoritmo "semnome"
// Fun��o :
// Autor :
// Se��o de Declara��es 
var
nome: caracter
idade: inteiro
valorcompra: real
desconto: real
valorapagar: real
inicio
// Se��o de Comandos
escreva("Digite o seu nome: ")
leia(nome)
escreva("Digite a sua idade: ")
leia(idade)
escreva("Digite o valor da compra: ")
leia(valorcompra)
se idade>60 entao
desconto<-valorcompra*0.1
senao
desconto<-0
fimse
se desconto=0 entao
escreva("Valor a pagar: ",valorcompra)
senao
valorapagar<-valorcompra-desconto
escreval("Valor da compra: ",valorcompra)
escreval("Valor do desconto: ",desconto)
escreval("Valor a pagar: ",valorapagar)
fimse
fimalgoritmo
