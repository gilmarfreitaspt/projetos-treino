// ciclos.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"         //(Usar no Visual Studio 2017)
#include <iostream>
#include <string>
#include <locale>

using namespace std;

int main()
{
   
	char valor;
	int i,col,num, lin;
	for (i = 1; i <= 10; i++)
	{
		cout << " valor de i = "; 
			cout << i << endl;
	}
	system(" pause");
	system(" cls");
	for (i = 100; i > 0;  i-=5)
	{
		cout << "valor de i = ";
		cout << i << endl;
	}
 // caso particular do for sem parametros 
	    for (;;)
	{
		cout << "escreva valores e termine  com X";
		cin >> valor;
		if (valor == 'x' || valor == 'X')
			break;
	}
		system(" pause");
		system(" cls");
		for (lin = 1;lin <= 3;lin++)
		{
			for (col = 1;col <= 3;col++)
				cout << lin << "," << col << "  ";
			cout << endl;
		}


	/*Escrever com umciclo
		1 2 3 4 5 6 7 8 9 10
		11 12 13 14 15 16 17 18 19 20
		91 92 93 94 95 96 97 98 99 100*/
		system(" pause");
		system(" cls");

		for (num = 1; num <= 100; num++)
		{
			cout << num << "\t";
			if (num % 10 == 0)

			cout << i << endl;
			
		}
		system(" pause");
		system(" cls");


		
		

		//for (i = 1; i <= 10; i++)  // i unidades
		

			//for (k = 0; k <= 9; k++) // k dezenas
			//{
				//cout << 10 * k + i << " ";

			//}
			//cout << endl;
			// SOLUÇÃO 2

		/*for (lin = 1;lin <= 10; lin++)
		{
			for (col = 0; col < 100; col += 10)
				cout << lin + col << "\t";
			cout << endl;
		}

		*/
   
}

