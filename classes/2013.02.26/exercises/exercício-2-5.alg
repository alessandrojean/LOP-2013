algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 24/02/2013
// Se��o de Declara��es
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
// Se��o de Comandos
escreva("Digite o seu nome: ")
leia(nome)
escreva("Digite quantas horas voc� trabalhou: ")
leia(horas)
escreva("Digite o seu n�mero de dependentes: ")
leia(dependentes)
escreval("Seu nome � ",nome,", voc� trabalhou ",horas," horas e tem ",dependentes," dependentes.")
salbruto<-horas*12
inss<-salbruto*0.085
ir<-salbruto*0.05
dependentes<-dependentes*40
saltotal<-salbruto-inss-ir+dependentes
escreval("Seu sal�rio bruto ser�: ",salbruto)
escreval("O desconto do INSS ser�: ", inss)
escreval("O desconto do IR ser�: ",ir)
escreval("Seu sal�rio liquido ser�: ", saltotal)
fimalgoritmo
