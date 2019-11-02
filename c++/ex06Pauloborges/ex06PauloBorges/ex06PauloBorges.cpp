// ex06PauloBorges.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

#include "pch.h"
#include <iostream>
#include <iomanip>
#include <string>
#include <locale>


using namespace std;
int num = 0;

//******* Procedimento para limpar ecra
void limpa()
{
	system("cls");
}

//******* Procedimento para parar
void parar()
{
	system("pause");
}

//******* Procedimento para desenhar uma linha
void linha(char x)
{
	int i;
	for (i = 1;i <= 40;i++)
		cout << x;
	cout << endl;
}

//Procedimento MENU
void desenhaMenu()
{
	limpa();
	linha('*');
	cout << "        MENU\n ";
	linha('*');
	cout << "1 - Inserir elementos no vetor\n";
	cout << "2 - Mostrar elementos\n";
	cout << "3 - Mostrar elementos invertidos\n";
	cout << "4 - Inverter dados dentro do vetor\n";
	cout << "5 - Apresentar soma dos elementos\n";
	cout << "0 - Terminar\n\n";
	cout << "Escolher opcao: ";
}

/************************************************
	1 OPÇÃO PARA INSERIR ELEMENTOS
*************************************************/
void inserirVetor()
{
	int vetor[10], i;
	limpa();
	cout << "TAREFA 1 - Inserir elementos.\nInsira valores para terminar insira o 0 ZERO.\n";
	//Código
	for (i = 1;i <= 10;i++)
	{
		int num = 0;
		cin >> vetor[i];
		if (vetor[i] == 0) break;
		if (num = 0)
		num == vetor[i];i++;
		
	}
	parar();
}

/************************************************
	2 OPÇÃO PARA MOSTRAR ELEMENTOS
*************************************************/
void mostrarElementos()
{
	limpa();
	cout << "TAREFA 2 - Mostrar elementos\n";
	//Código
	parar();
}

/************************************************
	3 OPÇÃO PARA MOSTRAR ELEMENTOS INVERTIDOS
*************************************************/
void mostrarElementosInvertidos()
{
	limpa();
	cout << "TAREFA 3 – Mostrar elementos invertidos \n";
	//Código
	parar();
}

/************************************************
	4 OPÇÃO PARA INVERTER ELEMENTOS
*************************************************/
void inverterDados()
{
	limpa();
	cout << "TAREFA 4 – Inverter elementos na tabela  \n";
	//Código
	parar();
}

/************************************************
	5 OPÇÃO PARA MOSTRAR SOMA DOS ELEMENTOS
*************************************************/
void somaElementos()
{
	limpa();
	cout << "TAREFA 5 – Apresentar soma\n";
	cout << "esse é  a soma"; num;
	//Código
	parar();
}


void main()

{
	setlocale(LC_ALL, "portuguese");
	
	int op;
	do
	{
		desenhaMenu();
		cin >> op;
		// Lista de procedimentos a serem CHAMADOS
		if (op == 1) inserirVetor();
		else if (op == 2) mostrarElementos();
		else if (op == 3) mostrarElementosInvertidos();
		else if (op == 4) inverterDados();
		else if (op == 5) somaElementos();
		else if (op != 0) {
			cout << "ERRADO\n";
			parar();
		}
	/*} while (op != 0);

	system("pause");
	limpa();
#include <iomanip>
#include <string>
#include <locale>


	using namespace std;

	// DECLARAÇÃO DE VARIÁVEIS GLOBAIS
	bool temElem = false;
	int vetor[10];


	//******* Procedimento para limpar ecra
	void limpa()
	{
		system("cls");
	}

	//******* Procedimento para parar
	void parar()
	{
		system("pause");
	}

	//******* Procedimento para desenhar uma linha
	void linha(char x)
	{
		int i;
		for (i = 1;i <= 40;i++)
			cout << x;
		cout << endl;
	}

	//Procedimento MENU
	void desenhaMenu()
	{
		limpa();
		linha('*');
		cout << "        MENU\n ";
		linha('*');
		cout << "1 - Inserir elementos no vetor\n";
		cout << "2 - Mostrar elementos\n";
		cout << "3 - Mostrar elementos invertidos\n";
		cout << "4 - Inverter dados dentro do vetor\n";
		cout << "5 - Apresentar soma dos elementos\n";
		cout << "0 - Terminar\n\n";
		cout << "Escolher opcao: ";
	}

	/************************************************
		1 OPÇÃO PARA INSERIR ELEMENTOS
	*************************************************
	void inserirVetor()
	{
		int i;

		limpa();
		cout << "POSICAO 3 " << vetor[3];
		cout << "TAREFA 1 - Inserir elementos.\nInsira valores para terminar insira o 0 ZERO.\n";
		//Código
		for (i = 0;i < 10;i++)
		{
			cin >> vetor[i];
			if (vetor[i] == 0) break;
		}
		parar();
		temElem = true;
	}

	/************************************************
		2 OPÇÃO PARA MOSTRAR ELEMENTOS
	*************************************************/
	void mostrarElementos()
	{
		int i;
		limpa();
		cout << "TAREFA 2 - Mostrar elementos\n";
		//Código
		for (i = 0;i < 10; i++)
			if (vetor[i] != 0)
				cout << vetor[i] << " | ";
			else
				break;
		parar();
	}

	/************************************************
		3 OPÇÃO PARA MOSTRAR ELEMENTOS INVERTIDOS
	*************************************************/
	void mostrarElementosInvertidos()
	{
		int i;
		limpa();
		cout << "TAREFA 3 – Mostrar elementos invertidos \n";
		//Código
		for (i = 0;i < 10; i++)
			cout << vetor[i] << " | ";
		parar();
		parar();
	}

	/************************************************
		4 OPÇÃO PARA INVERTER ELEMENTOS
	*************************************************/
	void inverterDados()
	{
		limpa();
		cout << "TAREFA 4 – Inverter elementos na tabela  \n";
		//Código
		parar();
	}

	/************************************************
		5 OPÇÃO PARA MOSTRAR SOMA DOS ELEMENTOS
	*************************************************/
	void somaElementos()
	{
		limpa();
		cout << "TAREFA 5 – Apresentar soma\n";
		//Código
		parar();
	}

	/********************* PRINCIPAL ***********************/
	void main()
	{
		setlocale(LC_ALL, "portuguese");

		int op;


		do
		{
		inicio:
			desenhaMenu();
			cin >> op;
			//Condição para verificar se tem elementos e se escolheu uma das opçoes 2,3,4 ou 5
			//Se não tem elementos !temElem não faz sentido escolher 2,3,4 ou 5
			if ((op == 2 || op == 3 || op == 4 || op == 5) && (!temElem))
			{
				cout << "Não tem elementos, escolha opcao 1 \n";
				parar();
				goto inicio;
			}

			else if (op == 1) inserirVetor();
			else if (op == 2) mostrarElementos();
			else if (op == 3) mostrarElementosInvertidos();
			else if (op == 4) inverterDados();
			else if (op == 5) somaElementos();
			else if (op != 0) {
				cout << "ERRADO\n";
				parar();
			}
		} while (op != 0);

		system("pause");
		limpa();
	}
	
	
}



