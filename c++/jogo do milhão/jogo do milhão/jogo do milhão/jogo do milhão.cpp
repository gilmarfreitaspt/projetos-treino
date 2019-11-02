


#include "pch.h"
#include <iostream>
#include <time.h>
#include <string>
#include <locale>

using namespace std;

//Protótipo das funções 
//Espaço onde as funções são apresentadas
void limpa();
void parar() ;
int sorte(int x, int y);
//float soma(float x, float y);

//Estrutura principal do programa
int main()
{
	setlocale(LC_ALL, "portuguese");

	int n = 0, i ;
	float num1, num2;
	char op;

	//Inicializar o timer
	srand(time(0));
	limpa();
	parar();
	int  principal[5];
	int	estrela[2];


	//int sorte;
	
	cout << "Bem vindo ao Jogo do Euro Milhão\n";
	cout << "escolha (S) para continuar ou  ( N ) para desistir";
	cin >> op;

	if
		((op == 'n') || (op == 'N'))
		cout << "Escolheu sair\n";
	system("pause");
	cout << " endl";
    if
		((op == 's') || (op == 'S')) {
         cout << "escolheu continuar boa sorte\n ";
		//cout << " Chave  " << sorte << " ";
	}

	do {
		cout << "Chave" << n << endl;

		for (i = 1; i <= 5; i++)
			cout << (sorte(1, 50)) << endl;
		     cin >> principal[i];
		cout << "---------------------\n";

		
            
			cout << "Estrelas " << n << endl;
			for (n = 1; n <= 2; n++)
				cout << (sorte(1, 12)) << endl;
				cin >> estrela[i];
				parar();

			
			 
		

		cout << "Bem vindo ao Jogo do Euro Milhão\n";
        cout << "(s)continuar (n)terminar ?";
		cin >> op;
		system("cls");
		n++;
	} while (op != 'n' && op != 'N');
}




//Construção das funções 

void limpa() {
	system("cls");

	cout << "-------------------------\n";
	cout << "--- EUROMILHÕES ---\n";
	cout << "-------------------------\n\n";

}

void parar() {
	system("pause");
}

int sorte(int n1, int n2)
{
	//Gera números entre n1 e n2 que foram pedidos do MAIN
	int valor;
	valor = rand() % (n2 - n1 + 1) + n1;
	return (valor);

}

//Exemplo da função para somar 2 numeros
/*float soma(float x, float y)
{
	float res;
	res = x + y;
	return (res);
}*/
