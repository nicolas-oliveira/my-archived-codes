#include <iostream>
using namespace std;
int main(){
    int array[] = {1,25,32,43,58};
    int* parray = &array[0];

    cout << *(parray + 1) << endl; //Incremento de ponteiro acessa o array ou vetor 
    return 0;
}