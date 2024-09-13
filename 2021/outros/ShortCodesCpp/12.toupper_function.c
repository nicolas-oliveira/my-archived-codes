/*
Fazer uma função equivalente ao toupper do C++ em C
*/
#include <stdio.h>
int toupper(int var);
int main(){
    char letter;
    
    printf("Digite uma letra minuscula: ");
    scanf("%c", &letter);
    
    letter = toupper(letter);
    
    printf("%c", letter);
    
    return 0;
}

int toupper(int var){
        if(var >=97 && var <=122){
        var -= 32;
        }
        return var;
    }