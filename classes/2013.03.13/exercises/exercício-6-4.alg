// Algoritmo :
// Função :
// Autor :
// Data :
algoritmo "semnome"
// Seção de Declarações 
var V1, V2 : real
inicio
// Seção de Comandos 
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
