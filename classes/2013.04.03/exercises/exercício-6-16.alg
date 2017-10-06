algoritmo "semnome"
// Função :
// Autor :
// Data : 27/03/2013
// Seção de Declarações 
var
data,dia,mes,ano:caracter
resp:caracter
i:inteiro
inicio
// Seção de Comandos 
resp<-"s"
i<-0
enquanto resp="s" faca
escreva("Data: ")
leia(data)
dia<-copia(data,1,2)
mes<-copia(data,4,2)
ano<-copia(data,7,4)
se mes="09" entao
escreval("Essa data é do mês de Setembro.")
senao
escreval("Essa data não é de Setembro")
fimse
i<-i+1
se i>100 entao
resp<-"n"
senao
i<-i+1
escreva("Deseja continuar (S/N): ")
leia(resp)
fimse
fimenquanto
fimalgoritmo
