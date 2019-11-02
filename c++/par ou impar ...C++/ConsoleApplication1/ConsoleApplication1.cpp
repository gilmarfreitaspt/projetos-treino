// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <string>
#include < locale>
using namespace std;
int main()

{
	int ultNum, num = 1, somaImpar = 0, somaPar = 0, somaTotal = 0, contaPar = 0, contaImpar = 0, contaTotal = 0;
	double mediaPar, mediaImpar, mediaGlobal;
	int maior = 0;
	int	menor;

	cout << "Insira um numero para determinar se e PAR ou IMPAR.\n";
	cout << "Para terminar insira um numero negativo ou zero.\n";

	while (num > 0)
	{
		cin >> num;
		if (num > 0) 
			ultNum = num;
		
		
		if (num <= 0) break;

		contaTotal++;
		if (num % 2 == 0)
		{
			cout << "Numero PAR \n";
			contaPar++;
			somaPar = somaPar + num;

		}
		else
		{
			cout << "Numero IMPAR \n";
			contaImpar++;
			somaImpar = somaImpar + num;
		}

		if (num > maior) 
			maior = num;
		if (contaTotal == 1) 
			menor = num;
		if (num < menor) 
			menor = num;
		

	}  //fim do While



	contaTotal = contaPar + contaImpar;
	somaTotal = somaPar + somaImpar;
	mediaPar = somaPar / contaPar;
	mediaImpar = somaImpar / contaImpar;
	mediaGlobal = (somaPar + somaImpar) / contaTotal;

	system("cls");// limpa tela
	cout << " Foram inseridos um total de : \n" << contaTotal
    << " \n A soma dos numeros tem um valor total :\n" << somaTotal;
	cout << "\n O total de numeros pares sao :\n " << contaPar;
	cout << "\n  O total de numeros impares sao :\n" << contaImpar;
	cout << "\n A media dos pares : \n " << mediaPar;
	cout << "\n A media impar : \n " << mediaImpar;
	cout << "\n A media total :\n " << mediaGlobal;
	cout << "\n O maior numero :\n " << maior;
	cout << "\n O menor numero :\n " << menor;
	cout << "\n O ultimo numero inserido :\n " << ultNum;
}
