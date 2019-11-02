
#include "pch.h"
#include <iostream>
#include <string>
#include <locale>



using namespace std;

int main()
{
	setlocale(LC_ALL, "portuguese");

	int vetor[10];
	int i = 0;
	int soma = 0;
	



	int op;

	cout << "        MENU\n ";

	cout << "1 - Inserir elementos no vetor\n";
	cout << "2 - Mostrar elementos\n";
	cout << "3 - Mostrar elementos invertidos\n";
	cout << "4 - Inverter dados dentro do vetor\n";
	cout << "5 - Apresentar soma dos elementos\n";
	cout << "0 - Terminar\n\n";
	cout << "\n Escolher opcao: ";
	cin >> op;



	while (op != 0)
	{


		switch (op) {


		case  1:
			cout << "Insira 10 valores para terminar insira zero\n ";

			for (i = 0; i < 10; i++) {
				cin >> vetor[i];
			}

			break;

		case 2:
			cout << "Mostrar os elementos\n";

			for (i = 0; i < 10; i++) {
				cout << vetor[i] << " ";

			}
			break;

		case 3:
			cout << "Mostrar os elementos invertidos\n";

			for (i = 9; i >=0; i--) {
				cout << vetor[i] << " ";

			}
			break;

		case 4:

			cout << "Apresentar soma dos elementos\n";
			soma = 0;
			  for(i = 0; i < 10; i++) {
				  soma = vetor[i] + soma;
			  }

			  break;

		default:
			cout << "Operação invalida";
		}

		cout << " Terminada a tarefa  " << op << "\n";
		cout << " Pressione uma tecla\n";
		cin >> op;

	}



	cout << "Programa Terminado\n" << " \n" << " Obrigado!!!";


	return 0;
}
