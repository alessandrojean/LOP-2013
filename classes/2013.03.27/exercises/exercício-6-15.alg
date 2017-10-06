algoritmo "semnome"
// Função :
// Autor :
// Data : 27/03/2013
// Seção de Declarações 
var
nome, nmaior, nmenor: caracter
salario,maior,menor: real
resp: caracter
i:inteiro
inicio
// Seção de Comandos
resp<-"s"
i<-0
maior<-0
enquanto resp="s" faca
escreva("Nome: ")
leia(nome)
escreva("Salário: ")
leia(salario)
se salario>maior entao
maior<-salario
nmaior<-nome
fimse
se i=0 entao
menor<-salario
nmenor<-nome
i<-1
senao
se salario<menor entao
menor<-salario
nmenor<-nome
fimse
fimse
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
escreval("O maior salário é",maior,". Nome: ",nmaior)
escreval("O menor salário é",menor,". Nome: ",nmenor)
fimalgoritmo
