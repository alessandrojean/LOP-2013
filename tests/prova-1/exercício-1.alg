algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 10/04/2013
// Se��o de Declara��es 
var
cpf:caracter
datadivida:caracter
nome:caracter
valordivida:real
estado:caracter
totestado,totcpf,totclientes:inteiro
cpfx:caracter
resp:caracter
anox:caracter
anoatrasado:caracter
anoa:inteiro
inicio
// Se��o de Comandos 
resp<-"s"
totestado<-0
totcpf<-0
totclientes<-0
enquanto resp="s" faca
escreva("CPF (NNN.NNN.NNN-NN): ")
leia(cpf)
escreva("Data da d�vida (DD/MM/AAAA): ")
leia(datadivida)
escreva("Nome: ")
leia(nome)
escreva("Valor da d�vida: ")
leia(valordivida)
escreva("Estado (EE): ")
leia(estado)
//Contas
totclientes<-totclientes+1
se estado="SP" entao
totestado<-totestado+1
fimse
anox<-copia(datadivida,7,4)
cpfx<-copia(cpf,13,2)
se cpfx="32" entao
totcpf<-totcpf+1
fimse
anoatrasado<-anox
//Fim contas
//Dados cliente
escreval("CPF: ",cpf)
escreval("Data da d�vida: ",datadivida)
escreval("Nome: ",nome)
escreval("Valor da d�vida: ",valordivida)
escreval("Estado: ",estado)
escreval("A divida est� a atrasada desde :",anoatrasado)
escreva("Deseja continuar(S/N): ")
leia(resp)
//Fim dados cliente
fimenquanto
escreval("Total de clientes de SP:",totestado,". Percentual: ",totestado/totclientes*100)
escreval("Total de clientes com cpf final 32: ",totcpf,". Percentual: ", totcpf/totclientes*100)

fimalgoritmo
