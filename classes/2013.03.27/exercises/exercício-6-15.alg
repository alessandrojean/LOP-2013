algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 27/03/2013
// Se��o de Declara��es 
var
nome, nmaior, nmenor: caracter
salario,maior,menor: real
resp: caracter
i:inteiro
inicio
// Se��o de Comandos
resp<-"s"
i<-0
maior<-0
enquanto resp="s" faca
escreva("Nome: ")
leia(nome)
escreva("Sal�rio: ")
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
escreval("O maior sal�rio �",maior,". Nome: ",nmaior)
escreval("O menor sal�rio �",menor,". Nome: ",nmenor)
fimalgoritmo
