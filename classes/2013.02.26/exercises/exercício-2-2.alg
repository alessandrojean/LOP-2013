algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 24/02/2013
// Se��o de Declara��es
var
nome: caracter
idade: inteiro
cargo: caracter
salario: real
salbruto: real
saltotal: real
grat: real
inicio
// Se��o de Comandos
escreva("Digite o seu nome: ")
leia(nome)
escreva("Digite a sua idade: ")
leia(idade)
escreva("Digite o seu cargo: ")
leia(cargo)
escreva("Digite o seu sal�rio: ")
leia(salario)
escreval("Seu nome � ",nome,", voc� tem ",idade," anos e � ",cargo,".")
salbruto<-salario+salario*0.38
grat<-salbruto*0.2
saltotal<-salbruto-salbruto*0.15+grat
escreval("Seu sal�rio bruto �: ",salbruto)
escreval("Seu sal�rio liquido ser�: ",saltotal)
fimalgoritmo
