#include <stdio.h>
#include <stdlib.h>
int main(){
    char palavra[999];
    printf("Digite uma palavra: ");
    setbuf(stdin, 0); //Limpa o buffer, responsavel pela leitura de mais de uma letra de uma vez so
    //Atraves da entrada padrao, standart input
    fgets(palavra, 999, stdin);
    palavra[strlen(palavra) - 1] = '\0'; //Limpa o resto das posicoes nao usadas
    printf("%s", palavra);
    return 0;
}