algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 27/03/2013
// Se��o de Declara��es 
var
setor, smaior, smenor: caracter
salario,maior,menor: real
somasal:real
nome:caracter
resp: caracter
i:inteiro
inicio
// Se��o de Comandos
resp<-"s"
i<-0
maior<-0
somasal<-0
enquanto resp="s" faca
escreva("Nome: ")
leia(nome)
escreva("Setor: ")
leia(setor)
escreva("Sal�rio: ")
leia(salario)
somasal<-somasal+salario
se salario>maior entao
maior<-salario
smaior<-setor
fimse
se i=0 entao
menor<-salario
smenor<-setor
i<-1
senao
se salario<menor entao
menor<-salario
smenor<-setor
fimse
fimse
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
escreval("O menor sal�rio �",menor,". Setor: ",smenor)
escreval("O total da folha �: ",somasal)
fimalgoritmo
