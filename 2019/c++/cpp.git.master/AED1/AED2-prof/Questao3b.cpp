#include <iostream>
using namespace std;

struct TDisc
{
    string palavra_port, palavra_ing;
};
TDisc dicionario[100];
void cadastra()
{
    for (int i =0 ; i <5; i++)
    {
        cout << "Portugu�s ";
        cin >> dicionario[i].palavra_port;
        cout << "Ingl�s ";
        cin >> dicionario[i].palavra_ing;
    }
}
string traduza (string palavra)
{
   string aux="";
   for (int i =0 ; i <5; i++)
    if(palavra == dicionario[i].palavra_port)
        aux = dicionario[i].palavra_ing;
    if (aux == "")
       return "Palavra n�o cadastrada";
    else
       return aux;
}

int main()
{
    cadastra();
    string palavra;
    cout << "Digite uma palavra em portugu�s ";
    cin >> palavra;
    cout << "Tradu��o "<< traduza(palavra);
    return 0;
}
