#include <iostream>


using namespace std;

struct TSala
{
    int num, cart, lamp;
    float larg, comp;
    string nome;
};

int main()
{
    TSala salas[50];
    for(int i=0 ; i<30; i++) // leitura
    {
        cout << "N�mero ";
        cin >> salas[i].num;
        cout << "Nome ";
        cin >> salas[i].nome;
        cout << "Qtde carteiras ";
        cin >> salas[i].cart;
        cout << "Qtde L�mpadas ";
        cin >> salas[i].lamp;
        cout << "Largura ";
        cin >> salas[i].larg;
        cout << "Comprimento ";
        cin >> salas[i].comp;
    }
    for(int i=0 ; i<30; i++) // impress�o
    {
        if(salas[i].cart>40)
            cout << "N�mero "<< salas[i].num << endl;
    }
    return 0;
}
