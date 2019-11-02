// ex07.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <string>
#include <iomanip>
#include <locale>
#include <iomanip>





int main()


{
	using namespace std;
	setlocale(LC_ALL, "portuguese");
	int num[6];
	int par, impar, aux ,j, i;
	double soma = 0;
	double media;

	for (i = 0; i <= 5;i++)
	{
		cout << " insira o " << i + 1 << "º numero ";
		cin >> num[i];
		soma = num[i] + soma;
	}
	media = soma / 6;
	system("pause");
    system("cls");
	
	cout << "\nOs numeros do vetor :\n";
	for (i = 0; i <= 5; i++)
		cout << num[i] << "\t";

	cout << "\n \n" << "Os numeros do ARRAY ordenada" << "\n";
	for (i = 0; i <= 4; i++)
		for (j = i + 1; j <= 5;j++)
			if (num[i] > num[j])
			{
				aux = num[i];
				num[i] = num[j];
				num[j] = aux;
			}

	for (i = 0; i <= 5; i++)
		cout << num[i] << "\t";

	cout << "\nOs numeros PARES:\n";
    for (i = 0; i <= 5; i++)
		if (num[i] % 2 == 0)
			cout << num[i] << "\t";
	
	cout << "\nOs numeros IMPARES:\n";
	for (i = 0; i <= 5; i++)
		if (num[i] % 2 != 0)
			cout << num[i] << "\t";

	
	cout << "\nA soma dos elementos : " << soma;
	cout << "\nA media dos elementos : " << fixed << setprecision(2) << media;
	cout << "\n\n\n";
	 }

