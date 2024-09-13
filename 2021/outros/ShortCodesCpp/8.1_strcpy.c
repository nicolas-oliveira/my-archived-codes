#include <stdio.h>

int main(){
    char x[25], y[25];
    
    scanf("%s",&y);

    for(int i = 0; (x[i] = y[i]) != 0; ++i); //strcpy(x,y);
    
    int i = 0;
    while(x[i] != 0){
    printf("%c", x[i]);
    i++;
    }
    return 0;
}