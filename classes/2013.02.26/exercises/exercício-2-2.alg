algoritmo "semnome"
// Função :
// Autor :
// Data : 24/02/2013
// Seção de Declarações
var
nome: caracter
idade: inteiro
cargo: caracter
salario: real
salbruto: real
saltotal: real
grat: real
inicio
// Seção de Comandos
escreva("Digite o seu nome: ")
leia(nome)
escreva("Digite a sua idade: ")
leia(idade)
escreva("Digite o seu cargo: ")
leia(cargo)
escreva("Digite o seu salário: ")
leia(salario)
escreval("Seu nome é ",nome,", você tem ",idade," anos e é ",cargo,".")
salbruto<-salario+salario*0.38
grat<-salbruto*0.2
saltotal<-salbruto-salbruto*0.15+grat
escreval("Seu salário bruto é: ",salbruto)
escreval("Seu salário liquido será: ",saltotal)
fimalgoritmo
