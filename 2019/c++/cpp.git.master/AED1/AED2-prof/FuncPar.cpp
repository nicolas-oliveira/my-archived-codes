#include <iostream>
using namespace std;

bool verificaPar(int valor)
{
    if (valor %2 == 0)
        return true;
    else
        return false;
}
int main()
{
    int v;
    cout << "Digite um valor ";
    cin >> v;
    if(verificaPar(v))
        cout << "Valor � par";
    else
        cout << "Valor � �mpar";
    return 0;
}
