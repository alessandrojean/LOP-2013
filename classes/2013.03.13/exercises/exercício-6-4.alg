// Algoritmo :
// Fun��o :
// Autor :
// Data :
algoritmo "semnome"
// Se��o de Declara��es 
var V1, V2 : real
inicio
// Se��o de Comandos 
escreva("Qual o primeiro valor ? ")
leia(V1)
escreva("Qual o segundo valor ? ")
leia(V2)
se V2 < V1 entao
   V1 <- V2
fimse
escreva("Qual o terceiro valor ? ")
leia(V2)
se V2 < V1 entao
   V1 <- V2
fimse
escreval( "O menor valor digitado foi : " , V1)
fimalgoritmo
