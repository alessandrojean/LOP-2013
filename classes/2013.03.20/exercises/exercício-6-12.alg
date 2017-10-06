algoritmo "semnome"
// Função :
// Autor :
// Data : 20/03/2013
// Seção de Declarações 
var
modelo,cor,placa:caracter
ano,totverde,totano,totmod,totplaca,totcarro:inteiro
n1,n2,n3,n4:caracter
resp:caracter
inicio
// Seção de Comandos
resp<-"s"
totverde<-0
totano<-0
totmod<-0
totplaca<-0
totcarro<-0
enquanto resp="s" faca
escreva("Modelo: ")
leia(modelo)
escreva("Cor: ")
leia(cor)
escreva("Placa: ")
leia(placa)
escreva("Ano de fabricação: ")
leia(ano)
totcarro<-totcarro+1
se ano<1990 entao
totano<-totano+1
fimse
se cor="verde" entao
totverde<-totverde+1
fimse
se modelo="fiat uno" entao
totmod<-totmod+1
fimse
n1<-copia(placa,3,1)
n2<-copia(placa,4,1)
n3<-copia(placa,5,1)
n4<-copia(placa,6,1)
se (n1="5") ou (n2="5") ou (n3="5") ou (n4="5") entao
totplaca<-totplaca+1
fimse
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
escreval("Tot de carros cor verde: ",totverde, ". Percentual: ", totverde/totcarro*100)
escreval("Tot de carros ano<1990:",totano,". Percentual: ", totano/totcarro*100)
escreval("Tot de carros FIAT UNO: ",totmod,". Percentual: ", totmod/totcarro*100)
escreval("Tot de carros placa 5: ", totplaca,". Percentual: ",totplaca/totcarro*100)
fimalgoritmo
