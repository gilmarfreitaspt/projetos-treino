
#include "pch.h"
#include <iostream>
#include <string>
#include <locale>



using namespace std;

int main()
{
	setlocale(LC_ALL, "portuguese");

	int vetor[10];
	int vetortemporario[10];
	int i = 0;
	int j;
	int soma = 0;
    int op = 9;


inicio:
	while (op != 0)
	{
	system("CLS");
	cout << "        MENU\n ";

	cout << "1 - Inserir elementos no vetor\n";
	cout << "2 - Mostrar elementos\n";
	cout << "3 - Mostrar elementos invertidos\n";
	cout << "4 - Inverter dados dentro do vetor\n";
	cout << "5 - Apresentar soma dos elementos\n";
	cout << "0 - Terminar\n\n";
	cout << "\n Escolher opcao: ";
	cin >> op;
	if (op < 0 || op > 5) {
		cout << " Escolheu uma opção invalida\n";
		system("pause");
		goto inicio;
	}
	
	 

		switch (op) {
			

		case  1:
			cout << "Insira 10 valores para terminar insira zero\n ";

			for (i = 0; i < 10; i++) {
				cin >> vetor[i];
				
			}
			
			system("pause");
			break;
			

		case 2:
			cout << "Mostrar os elementos\n";

			for (i = 0; i < 10; i++) {
				cout << vetor[i] << " ";
				
			}
			
			system("pause");
			break;
			

		case 3:
			cout << "Mostrar os elementos invertidos\n";

			for (i = 9; i >= 0; i--) {
				cout << vetor[i] << " ";
				
			}
			
			system("pause");
			break;
			
		case 4:

			cout << "inverter elementos da tabela\n";
			
			j = 9;  // para apontar para ultima posição do vetor principa
			for (i = 0; i < 10; i++) {
				vetortemporario[i] = vetor[j];
				j--; // decrementa o apontador
			}

			for (i = 0; i < 10; i++)
				vetor[i] = vetortemporario[i];

			cout << "Elementos invertidos com sucesso!" << endl;

			for (i = 0; i < 10; i++)
				cout << vetor[i] << "  ";
			
			system("pause");
			break;
			

		case 5:

			cout << "Apresentar soma dos elementos\n";
			soma = 0;
			for (i = 0; i < 10; i++) 
				soma = vetor[i] + soma;
			
			cout << soma <<"\n" << endl;
			
			system("pause");
			break;
		
		case 0:
			cout << "Obrigado!\n";
        }

		cout << " \nTerminada a tarefa " << op << "\n";
		cout << " Pressione uma tecla\n";
		
		

	}



	cout << "Programa Terminado\n" << " \n" << " Obrigado!!!";


	return 0;
}
