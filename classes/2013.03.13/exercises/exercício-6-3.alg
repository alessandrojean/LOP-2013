algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 12/03/2013
// Se��o de Declara��es 
var
nome: caracter
nota1,nota2,nota3,media: real
inicio
// Se��o de Comandos
escreva("Digite o Nome: ")
leia(nome)
escreva("Digite a primeira nota: ")
leia(nota1)
escreva("Digite a segunda nota: ")
leia(nota2)
escreva("Digite a terceira nota: ")
leia(nota3)
media<-(nota1+nota2+nota3)/3
se media>=8 entao
escreva("Seu nome � ",nome,", sua m�dia � ",media," e voc� foi aprovado.")
senao
escreva("Seu nome � ",nome,", sua m�dia � ",media," e voc� foi reprovado.")
fimse
fimalgoritmo
