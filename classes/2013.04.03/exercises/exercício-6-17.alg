algoritmo "semnome"
// Função :
// Autor :
// Data : 27/03/2013
// Seção de Declarações 
var
data,dia,mes,ano:caracter
mesx:caracter
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
escolha mes
caso "01"
mesx<-"Janeiro"
caso "02"
mesx<-"Fevereiro"
caso "03"
mesx<-"Março"
caso "04"
mesx<-"Abril"
caso "05"
mesx<-"Maio"
caso "06"
mesx<-"Junho"
caso "07"
mesx<-"Julho"
caso "08"
mesx<-"Agosto"
caso "09"
mesx<-"Setembro"
caso "10"
mesx<-"Outubro"
caso "11"
mesx<-"Novembro"
caso "12"
mesx<-"Dezembro"
outrocaso
mesx<-" "
fimescolha
se mesx<>" " entao
escreval(dia," de ",mesx," de ",ano)
fimse
i<-i+1
se i>100 entao
resp<-"n"
senao
escreva("Deseja continuar (S/N): ")
leia(resp)
fimse
fimenquanto
fimalgoritmo
