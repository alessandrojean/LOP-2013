algoritmo "Coronometoro"
// Função :
// Autor :
// Data : 27/03/2013
// Seção de Declarações 
var
hora,min,seg:inteiro
controle:inteiro
inicio
seg<-00
min<-00
hora<-00
controle<-0
enquanto controle=0 faca
se seg>59 entao
se min<=59 entao
min<-min+1
seg<-00
senao
se hora<24 entao
hora<-hora+1
min<-00
seg<-00
senao
hora<-00
seg<-00
min<-00
fimse
fimse
senao
seg<-seg+1
fimse
escreval(hora,":",min,":",seg)
timer 120
fimenquanto
fimalgoritmo
