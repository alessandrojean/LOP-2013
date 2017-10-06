algoritmo "semnome"
// Função :
// Autor :
// Data : 27/03/2013
// Seção de Declarações 
var
setor, smaior, smenor: caracter
salario,maior,menor: real
somasal:real
nome:caracter
resp: caracter
i:inteiro
inicio
// Seção de Comandos
resp<-"s"
i<-0
maior<-0
somasal<-0
enquanto resp="s" faca
escreva("Nome: ")
leia(nome)
escreva("Setor: ")
leia(setor)
escreva("Salário: ")
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
escreval("O menor salário é",menor,". Setor: ",smenor)
escreval("O total da folha é: ",somasal)
fimalgoritmo
