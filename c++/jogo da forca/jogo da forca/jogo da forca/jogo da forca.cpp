// jogo da forca.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <locale>

using namespace std;
int main()
{

	string frase1, frase2;
	char letra;
	int i, vidas= 5, erro = 1;


	//Leitura de string
	cout << "Escreva uma frase ";
	getline(cin, frase1);

	frase2 = frase1;

	cout << frase1 << endl;

	//Preencher a frase2 com *
	for (i = 0; i < frase2.length(); i++)
		if (frase2[i] != ' ') frase2[i] = '*';

	cout << frase2 << endl;

	while (frase1 != frase2)
	{
		cout << "\n\nInsira uma letra ";
		cin >> letra;

		for (i = 0; i < frase1.length(); i++)
			if (frase1[i] == letra)
			{
				frase2[i] = letra;
				erro = 0;
			}

		if (erro == 1)
			vidas--;
		
		//Inicializar o erro
		erro = 1;

		cout << frase2 << endl;
		cout << "Restam-lhe " <<vidas<<" vidas\n";
		if (vidas == 0) {
			cout << "Acabou de ser  enforcado e perdeu\n";
		
		    break;
		}

	}




}

