algoritmo "semnome"
// Função :
// Autor :
// Data : 24/02/2013
// Seção de Declarações
var
nome: caracter
horas: real
dependentes: inteiro
salario: real
salbruto: real
saltotal: real
inss: real
ir: real
inicio
// Seção de Comandos
escreva("Digite o seu nome: ")
leia(nome)
escreva("Digite quantas horas você trabalhou: ")
leia(horas)
escreva("Digite o seu número de dependentes: ")
leia(dependentes)
escreval("Seu nome é ",nome,", você trabalhou ",horas," horas e tem ",dependentes," dependentes.")
salbruto<-horas*12
inss<-salbruto*0.085
ir<-salbruto*0.05
dependentes<-dependentes*40
saltotal<-salbruto-inss-ir+dependentes
escreval("Seu salário bruto será: ",salbruto)
escreval("O desconto do INSS será: ", inss)
escreval("O desconto do IR será: ",ir)
escreval("Seu salário liquido será: ", saltotal)
fimalgoritmo
