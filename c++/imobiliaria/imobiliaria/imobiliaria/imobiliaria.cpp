// imobiliaria.cpp : This file contains the 'main' function. Program execution begins and ends there.
//


#include <iostream>


#include <locale>
using namespace std;

int op;



void limpa() {
	system("cls");
}

void pausa() {
	system("pause");
}



void mostraMenu() {
	limpa();
	cout << "1- Inserir imoveis\n" << endl;
	cout << "2- Pesquisar imoveis\n" << endl;
	cout << "3- Listar imoveis\n" << endl;
	cout << "0- Sair\n";
	cout << "Qual a sua opção? " << endl;
	cin >> op;
	
}

struct imoveis
{

	string zona;
	string tipo;
	string tipologia;
	float preco = 0;
	string estado;


	void inserir(string Vzona, string Vtipo, string Vtipologia,int Vpreco, string Vestado)
	{
		zona = Vzona;
		tipo = Vtipo;
		tipologia = Vtipologia;
		preco  = 0;
		estado = Vestado;

	}
	void listar()
	{
		cout << "Localidade ------------"<< zona << endl ;
		cout << "Tipo ------------------" << tipo << endl;
		cout << "Tipológia -------------" << tipologia << endl;
		cout << "Preço do Imóvel -------" << preco << endl;
		cout << "Estado ----------------" << estado << endl;

	}
	

};

imoveis vendas[4];
int i;

void inserirImoveis() {

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
		
		
	

	}

}
void mostraImoveis() {
	for (i = 0; i <= 4; i++) {
		if (vendas[i].zona == " ")
		cout << "não tem elementos inseridos";
	
		else
			vendas[i].listar();
		pausa();
		
	break;
	}
	
}


void pesquisarImoveis() {

	for (i = 0; i <= 4; i++) {
		if (vendas[i].zona != " ") {
			cout << "Os imoveis disponiveis são " << endl;
			
			vendas[i].listar();
			
			break;
			
		}

	}
}







int main()

{
	setlocale(LC_ALL, "Portuguese");
	

	do{
	mostraMenu();
	if (op == 1)  inserirImoveis();
	if (op == 2)  pesquisarImoveis();
	if (op == 3)  mostraImoveis();
	
     if (op == 0)
	cout << "Escolheu terminar\n";
	 if (op >= 4)
		 cout << "opção invalida escolha novamente" << endl;
	pausa();
    } while (op != 0) ;


vendas[0].zona = "Porto";
vendas[0].tipo = "casa";
vendas[0].tipologia = "T3";
vendas[0].preco = 120.000;
vendas[0].estado = "usado";

vendas[1].zona = "V.N.de Gaia";
vendas[1].tipo = "apartamento";
vendas[1].tipologia = "T2";
vendas[1].preco = 140.000;
vendas[1].estado = "Novo";

vendas[2].inserir("Porto", "Apartamento", "T4", 150.000, "Novo");

	
}

