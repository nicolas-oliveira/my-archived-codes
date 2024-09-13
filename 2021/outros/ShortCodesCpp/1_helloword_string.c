// Fazer um hello word em C
// Fazer um input de output de um nome em c

#include <stdio.h>
int main(){
    char nome[30];
    printf("Olá mundo.\n");
    printf("Digite seu nome: ");
    scanf ("%[^\n]s", &nome);
    printf("Olá %s\n", nome);
}