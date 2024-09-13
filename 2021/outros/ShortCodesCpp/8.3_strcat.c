#include <stdio.h>
#include <string.h>
int main(){
    int i;
    char x[3], y[6];
    
    
    scanf("%[^\n]s", &x);
    
    for(i = 0; (x[i] = y[i]) != 0; ++i);
    strcat(y, "DEF");
    
    for(i = 0; i < 6; i++) //ainda não fncionou, nada aqui funcionou
    printf("%d", y[i]);
    
    return 0;
}