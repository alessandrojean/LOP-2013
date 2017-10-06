algoritmo "semnome"
// Função :
// Autor :
// Data : 27/03/2013
// Seção de Declarações 
var
data:caracter
datacopia: caracter
resp: caracter
inicio
// Seção de Comandos 
resp<-"s"
enquanto resp="s" faca
escreva("Data: ")
leia(data)
datacopia<-copia(data,4,2)
se datacopia=09 entao
escreva("Essa data é do mês 9")
fimse
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
fimalgoritmo
