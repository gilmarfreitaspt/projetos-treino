// forca2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include <iostream>
#include <string>
#include <locale>
#include "pch.h"



  using namespace std;


int main()
{
	


	char palavra[30], letra[1], secreta[30];
 int tam, i = 0, chances, acertos;
 bool acerto;
 chances = 10;
 tam = 0;

  acerto = false;
  acertos = 0;

  cout << "escolha uma palavra para o jogo da forca ";
  cin >> palavra;
  system("cls");

  while (palavra[i] != '\o') {
	i++;
	tam++;
}

for (i = 0;i < 30;i++)
{
	secreta[i] = '-';
}
while ((chances > 0) && (acertos < tam))
{
	cout << "Chances Restantes:" << chances << "\n\n";
	cout << "palavra secreta";
	for (i = 0; i < tam;i++)
	{
		cout << secreta[i];
	}
	cout << "\n\nDigite uma letra:";
	cin >> letra[0];
	for (i = 0;i < tam;i++) {

		if (palavra[i] == letra[0])
			acerto = true;
		secreta[i] = palavra[i];
		acertos++;
	}


 if (!acerto) {
		chances--;
	}

		acerto = false;
		system("cls");
	}
 if (acertos == tam)
	cout << "voce venceu!";

 else
	"Que pena voçê perdeu";

	system("pause");
}
