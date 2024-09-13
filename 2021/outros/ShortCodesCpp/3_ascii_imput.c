#include <stdio.h>
#include <stdlib.h>
int main(){
    char letra;
    printf("Digite qualquer coisa: ");
    scanf("%c", &letra);
    printf("Codigo da letra: %d\n", letra);

    if(letra <= 122 && letra >= 97){
        printf("E uma letra minuscula");
    }else if(letra >= 65 && letra <= 90){
        printf("E uma letra maiuscula ");
    }else if(letra >= 48 && letra <= 57){
        printf("E um numero ");
    }else if(letra >= 33 && letra <= 47 || letra >= 60 && letra <= 64 || letra >= 91 && letra <= 95 || letra >= 123 && letra <= 127){
        printf("E um simbolo");
    }else if(letra >= 0 && letra <= 32){
        printf("E uma tecla especial");
    }else{
        printf("Este caracter nao esta na tabela ascii");
    }
    return 0;
}