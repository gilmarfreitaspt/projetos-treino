// imobiliaria2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//


#include <iostream>
#include <string>
#include <locale>
#include <iomanip>
using namespace std;


int op, i ;


void limpa() {
	system("cls");
}

void pausa() {
	system("pause");
}

struct imoveis
{

	string zona;
	string tipo;
	string tipologia;
	float preco = 0;
	string estado;
};

void mostraMenu() {
	limpa();
	cout << "1- Inserir imoveis\n" << endl;
	cout << "2- Pesquisar imoveis\n" << endl;
	cout << "3- Listar imoveis\n" << endl;
	cout << "0- Sair\n";
	cout << "Qual a sua opção? " << endl;
	cin >> op;

}
 
void inserirImoveis();
void mostraImoveis();
 
void pesquisarImoveis();
 


int main()
{
	using namespace std;
	
	double vendas[4];
	
       do {
		mostraMenu();
		if (op == 1)  inserirImoveis();
		if (op == 2)  pesquisarImoveis();
		if (op == 3)  mostraImoveis();

		if (op == 0)
			cout << "Escolheu terminar\n";
		if (op >= 4)
			cout << "opção invalida escolha novamente" << endl;
		pausa();
	} while (op != 0);



    void inserirImoveis()  {
	    
		for (i = 0; i < 4; i++) {

			if (vendas[i].zona == " ") 

				limpa();

				cout << "insira a zona  " << endl;
				cin >> vendas[i].zona;
				cout << "insira o tipo  " << endl;
				cin >> vendas[i].tipo;
				cout << "insira a tipologia  " << endl;
				cin >> vendas[i].tipologia;
				cout << "insira o valor   " << endl;
				cin >> vendas[i].preco;
				cout << "insira estado    " << endl;
				cin >> vendas[i].estado;

				pausa();

			break;
		}
		
	 }
		void  mostraImoveis() {
			for (i = 0; i <= 4; i++) {
				if (vendas[i].zona == "")
					cout << "não tem elementos inseridos";

				else
					vendas[i];
				pausa();

				break;
			}

		}

}

