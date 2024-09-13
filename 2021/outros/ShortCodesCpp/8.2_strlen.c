#include <stdio.h>
int main(){
    char x[25];
    
    scanf("%s",&x);
    int i;
    for(i = 0; x[i] != 0; ++i); //strlen(x)
    printf("%d\n", i);
    return 0;
}