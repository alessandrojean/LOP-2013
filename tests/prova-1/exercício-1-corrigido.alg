algoritmo "semnome"
// Função :
// Autor :
// Data : 17/04/2013
// Seção de Declarações 
var
cpf,nome,data,resp,estado:caracter
d1,d2,d3,d4:caracter
dx,totsp,tot,ano,anod,totcpf:inteiro  .
valor:real
inicio
// Seção de Comandos
resp<-"s"
tot<-0
totsp<-0
totcpf<-0
dx<-0
enquanto resp="s" faca
escreva("CPF: ")
leia(cpf)
escreva("Data: ")
leia(data)
escreva("Nome: ")
leia(nome)
escreva("Valor: ")
leia(valor)
escreva("Estado: ")
leia(estado)
se estado="sp" entao
totsp<-totsp+1
fimse
d1<-copia(data,7,1)
d2<-copia(data,8,1)
d3<-copia(data,9,1)
d4<-copia(data,10,1)
escolha d1
caso "1"
dx<-1000
caso "2"
dx<-2000
caso "3"
dx<-3000
caso "4"
dx<-4000
caso "5"
dx<-5000
caso "6"
dx<-6000
caso "7"
dx<-7000
caso "8"
dx<-8000
caso "9"
dx<-9000
fimescolha
escolha d2
caso "1"
dx<-dx+100
caso "2"
dx<-dx+200
caso "3"
dx<-dx+300
caso "4"
dx<-dx+400
caso "5"
dx<-dx+500
caso "6"
dx<-dx+600
caso "7"
dx<-dx+700
caso "8"
dx<-dx+800
caso "9"
dx<-dx+900
fimescolha
escolha d3
caso "1"
dx<-dx+10
caso "2"
dx<-dx+20
caso "3"
dx<-dx+30
caso "4"
dx<-dx+40
caso "5"
dx<-dx+50
caso "6"
dx<-dx+60
caso "7"
dx<-dx+70
caso "8"
dx<-dx+80
caso "9"
dx<-dx+90
fimescolha
escolha d4
caso "1"
dx<-dx+1
caso "2"
dx<-dx+2
caso "3"
dx<-dx+3
caso "4"
dx<-dx+4
caso "5"
dx<-dx+5
caso "6"
dx<-dx+6
caso "7"
dx<-dx+7
caso "8"
dx<-dx+8
caso "9"
dx<-dx+9
fimescolha
ano<-2013-dx
escreval("CPF: ",cpf)
escreval("Nome: ",nome)
escreval("Valor: ",valor)
escreval("Numeros de anos em atraso: ",ano)
se copia(cpf,13,2)="32" entao
escreval("O CPF tem final 32 (",cpf,")")
totcpf<-totcpf+1
fimse
tot<-tot+1
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
escreval("Total do estado de SP: ",totsp,". Percentual: ",totsp/tot*100)
escreva("Total de CPF com final 32: ",totcpf)
fimalgoritmo
