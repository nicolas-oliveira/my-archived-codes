#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>//Para trabalhar com condicoes booleanas
int main(){
    bool a = true, b = false;
    if(a){ //A condicao implicita sempre e verdadeira
        printf("A eh verdadeiro\n");
    }
    if(b){
        printf("B eh verdadeiro\n");
    }else{
        printf("B eh falso\n");
    }
    if(!b){ //Se b for falso
        printf("B eh falso\n");
    }
    return 0;
}