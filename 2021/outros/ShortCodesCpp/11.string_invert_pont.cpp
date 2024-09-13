#include <iostream>
#include <string.h>
using namespace std;
int main(){
    char name[100];
    int size;
    char* p;
    char* pstart;
    
    cout << "Digite seu nome: ";
    cin >> name;
    
    size = strlen(name);
    
    p = &name[size - 1];
    
    pstart = &name[0];

    while(true){
        cout << *p;

        if(p-- == pstart) //O decremento funciona após ele comparar o ponteiro
            break;
        
    }
    return 0;
}