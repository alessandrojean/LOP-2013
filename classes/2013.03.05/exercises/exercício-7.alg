algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 05/03/2013
// Se��o de Declara��es
var
nome,pizza,acompanhamento: caracter
quantpizza,quantacompanhamento: inteiro
preco,precoref,precop: real
inicio
// Se��o de Comandos
escreva("Nome: ")
leia(nome)
escreval("M-Mussarela     R$25,00")
escreval("C-Calabreza     R$30,00")
escreva("Escolha uma op��o de pizza: ")
leia(pizza)
se pizza="M" entao
precop<-25
senao
se pizza="C" entao
precop<-30
fimse
fimse
escreva("Quantidade: ")
leia(quantpizza)
escreval("R-Refrigerante     R$2,50")
escreval("S-Suco             R$5,00")
escreva("Acompanhamento: ")
leia(acompanhamento)
se acompanhamento="R" entao
precoref<-2.5
senao
se acompanhamento="S" entao
precoref<-5
fimse
fimse
escreva("Quantidade: ")
leia(quantacompanhamento)
preco<-quantpizza*precop+quantacompanhamento*precoref
escreva("O valor total �: R$", preco)
fimalgoritmo

