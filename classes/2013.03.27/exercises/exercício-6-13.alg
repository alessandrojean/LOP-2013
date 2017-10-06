algoritmo "semnome"
// Função :
// Autor :
// Data : 27/03/2013
// Seção de Declarações 
var
nome,resp: caracter
n1,n2,n3,n4,n5,n6,media:real
inicio
// Seção de Comandos
resp<-"s"
enquanto resp="s" faca
escreva("Nome: ")
leia(nome)
escreva("Nota 1: ")
leia(n1)
escreva("Nota 2: ")
leia(n2)
escreva("Nota 3: ")
leia(n3)
escreva("Nota 4: ")
leia(n4)
escreva("Nota 5: ")
leia(n5)
escreva("Nota 6: ")
leia(n6)
media<-(n1+n2+n3+n4+n5+n6)/6
  se media>=7 entao
  escreval("Nome: ",nome,". Média: ",media,". Aprovado")
  senao
    se (media>=5) e (media<7) entao
    escreval("Nome: ",nome,". Média: ",media,". Recuperação")
    senao
      escreval("Nome: ",nome,". Média: ",media,". Reprovado")
      fimse
    fimse
escreva("Deseja continuar (S/N): ")
leia(resp)
fimenquanto
fimalgoritmo
