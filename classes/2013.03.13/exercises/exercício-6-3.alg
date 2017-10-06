algoritmo "semnome"
// Função :
// Autor :
// Data : 12/03/2013
// Seção de Declarações 
var
nome: caracter
nota1,nota2,nota3,media: real
inicio
// Seção de Comandos
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
escreva("Seu nome é ",nome,", sua média é ",media," e você foi aprovado.")
senao
escreva("Seu nome é ",nome,", sua média é ",media," e você foi reprovado.")
fimse
fimalgoritmo
