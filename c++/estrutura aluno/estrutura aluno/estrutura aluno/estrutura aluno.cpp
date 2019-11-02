// estrutura aluno.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

#include <locale>
using namespace std;



struct pessoa
{
	int numero;
	string nome;
	int nota1;
	int nota2;
	int nota3;
};

pessoa aluno;

void inserirRegisto();
void mostrarRegisto();
void mostraMenu();
void limpa();
void parou();



int main()
{

	int op;

	do {
		mostraMenu();
		cin >> op;

		if (op == 1)
			inserirRegisto();
		if (op == 2)
			mostrarRegisto();
		if (op == 0)
			cout << "Escolheu terminar\n";
	} while (op != 0);
}


void inserirRegisto()
{
	limpa();
	cout << "Escolheu a opção Inserir registos\n";

	cout << "Número do aluno: ";
	cin >> aluno.numero;
	//Ignorar o Enter(resolve o problema de Buffer)
	cin.ignore(INT16_MAX, '\n');
	cout << "Nome do aluno\n ";
	cin >> aluno.nome;
	//getline(cin, aluno.nome);

	do {
		cout << "Nota primeiro periodo: (1-20) ";
		cin >> aluno.nota1;
	} while (aluno.nota1 < 0 || aluno.nota1 > 20);


	do {
		cout << "Nota segundo periodo: (1-20) ";
		cin >> aluno.nota2;
	} while (aluno.nota2 < 0 || aluno.nota2 > 20);

	do {
		cout << "Nota terceiro periodo: (1-20) ";
		cin >> aluno.nota3;
	} while (aluno.nota3 < 0 || aluno.nota3 > 20);



}

void mostrarRegisto()
{
	float medianotas;
	limpa();
	//cout << "Escolheu a opção mostrar registos\n";
	cout << "Número do aluno: " << aluno.numero << endl;
	cout << "Nome do aluno: " << aluno.nome << endl;
	cout << "Nota primeiro periodo:  " << aluno.nota1 << endl;
	cout << "Nota segundo periodo:  " << aluno.nota2 << endl;
	cout << "Nota terceiro periodo: " << aluno.nota3 << endl;
	medianotas = (aluno.nota1 + aluno.nota2 + aluno.nota3) / 3;
	cout << "O aluno/a " << aluno.nome << " tem uma média de " << medianotas << "\n";
	if (medianotas >= 10)
		cout << "Aprovado";
	else
        cout << "Reprovado";

	cout <<"\n"<< medianotas;
	parou();
	
}

void mostraMenu() {
	limpa();

	cout << "1- Inserir registo\n";
	cout << "2- Mostrar registo\n";
	cout << "0- Sair\n";
	cout << "Qual a sua opção? ";
}

void limpa() {
	//system("cls");
	cout << "Dados do Aluno \n\n\n\n";
}

void parou() {
	//system("pause");

}
