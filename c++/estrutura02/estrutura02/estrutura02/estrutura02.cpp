#include "pch.h"
#include <iostream>
#include <string>
#include <locale>
#include <iomanip>
using namespace std;

 struct pessoa
{	int numero;
	string nome;
    float nota1;
	float nota2 ;
	float nota3 ;
};
int i;
double media = 0;
pessoa  dadosAluno;
pessoa  turma[20];

//PROTÓTIPO DAS FUNÇÕES
void inserirRegisto();
void listarTurma();
void limpa();
void pesquisarAluno();
void pausa();
void mostraMenu();
void ordenar();
void mediaNota();
void ordenarPorNumero();
int main()
{
	///********dados para teste *************** ////
	turma[0].numero = 4;
	turma[0].nome = "Ana Martins";
	turma[0].nota1 = 12;
	turma[0].nota2 = 14;
	turma[0].nota3 = 12;

	turma[1].numero = 1;
	turma[1].nome = "Anabela Ramos";
	turma[1].nota1 = 12;
	turma[1].nota2 = 14;
	turma[1].nota3 = 6;


	turma[2].numero = 3;
	turma[2].nome = "Carlos Matias";
	turma[2].nota1 = 10;
	turma[2].nota2 = 10;
	turma[2].nota3 = 9;


	int opcao;

	 setlocale(LC_ALL, "Portuguese");
	do {
		limpa();
		mostraMenu();
		cin >> opcao;
		if (opcao == 1)
			inserirRegisto();
		if (opcao == 2)
			pesquisarAluno();
		if (opcao == 3)
			listarTurma();
	} while (opcao != 0);


}
/********************************************************************************/
void limpa() {
	system("cls");
}

void pausa() {
	system("pause");
}


/********************************************************************************/
void mostraMenu() {
	limpa();
	cout << "1- Inserir registo\n";
	cout << "2- Pesquisar\n";
	cout << "3- Listar turma\n";
	cout << "0- Sair\n";
	cout << "Qual a sua opção? ";
}

/***********************************************************************************/
void inserirRegisto()
{
	limpa();
	cout << "Número do aluno: ";
	cin >> dadosAluno.numero;
	//Ignorar o Enter(resolve o problema de Buffer)
	cin.ignore(INT16_MAX, '\n');

	cout << "Nome do aluno\n ";
	getline(cin, dadosAluno.nome);

	// TESTE DE ENTRA DE NOTAS ENTRE 1 E 20
	do {
		cout << "Nota primeiro periodo: (1-20) ";
		cin >> dadosAluno.nota1;
	} while (dadosAluno.nota1 < 1 || dadosAluno.nota1 > 20);


	do {
		cout << "Nota segundo periodo: (1-20) ";
		cin >> dadosAluno.nota2;
	} while (dadosAluno.nota2 < 1 || dadosAluno.nota2 > 20);

	do {
		cout << "Nota terceiro periodo: (1-20) ";
		cin >> dadosAluno.nota3;
	} while (dadosAluno.nota3 < 1 || dadosAluno.nota3 > 20);

	// PERCORRER O VETOR TURMA
	for (int i = 0; i < 20; i++)
	{
		//procurar a primeira posição no vetor disponível
		if (turma[i].numero == 0)
		{
			turma[i] = dadosAluno;  //copiar a ficha para a gaveta Turma
			cout << "Registado !!! O aluno na turma";
			break;
		}
		
		//Se número da ficha for igual ao número de uma das fichas no vetor
		if (turma[i].numero == dadosAluno.numero)
		{
			cout << "Este aluno/a já existe na turma!!!";
			break;
		}

	}
	ordenar();
	pausa();
}
	
/***************************************************************************/
void ordenar()
{
	for(int i=0; i<19; i++)
		for (int j = i + 1; j < 20; j++)
			if (turma[j].numero != 0)
				if (turma[i].nome > turma[j].nome)
				{
					dadosAluno = turma[i];
					turma[i] = turma[j];
					turma[j] = dadosAluno;
				}
}
		
	
/***************************************************************************/

void listarTurma()
{
	bool vazio = true;

	limpa();
	for (i = 0; i < 20; i++)
		if (turma[i].numero != 0)
		{
			cout << "Pos. vector " << i << endl;
			cout << "Número do aluno: " << turma[i].numero << endl;
			cout << "Nome do aluno: " << turma[i].nome << endl;
			cout << "Nota primeiro periodo:  " << turma[i].nota1 << endl;
			cout << "Nota segundo periodo:  " << turma[i].nota2 << endl;
			cout << "Nota terceiro periodo: " << turma[i].nota3  << endl;
			mediaNota();
			cout << "\n" << endl;
			vazio = false;
		}
	      
		if (vazio==true)   /// pode ser feito com if (vazio)
			cout << "Ficheiro vazio!!! \n";
		
	pausa();
}

/***************************************************************************/
// da a media do aluno e informa se está aprovado ou reprovado
void mediaNota() {

	cout << fixed << setprecision(1);

	if (turma[i].numero != 0)
		media = (turma[i].nota1 + turma[i].nota2 + turma[i].nota3) / 3;

	if (media >= 9.5) {

		cout << "A média do Aluno : " << turma[i].nome << " é " << media << " e está :" << endl;
		cout << "****** Aprovado ********" << endl;
	}
	else {
		cout << "A média do Aluno : " << turma[i].nome << " é " << media << " e está :" << endl;
		cout << "****** Reprovado ********" << endl;
	}
 }


void pesquisarAluno()
{
	int numeroAluno;
	bool existe = false;

	limpa();
	cout << "Qual o número do aluno ? ";
	cin >> numeroAluno;
	for (i = 0; i < 20; i++)
		if (turma[i].numero == numeroAluno)
		{
			existe = true;
			cout << "Pos. vector " << i << endl;
			cout << "Número do aluno: " << turma[i].numero << endl;
			cout << "Nome do aluno: " << turma[i].nome << endl;
			cout << "Nota primeiro periodo:  " << turma[i].nota1 << endl;
			cout << "Nota segundo periodo:  " << turma[i].nota2 << endl;
			cout << "Nota terceiro periodo: " << turma[i].nota3 << endl << endl;
			mediaNota();
		}	

	if (existe==false)
			cout << "Não encontrei o aluno \n";

	pausa();
}
void ordenarPorNumero()
{
	for (int i = 0; i < 19; i++)
		for (int j = i + 1; j < 20; j++)
			if (turma[j].numero != 0)
				if (turma[i].numero > turma[j].numero)
				{
					dadosAluno = turma[i];
					turma[i] = turma[j];
				    turma[j] = dadosAluno;
				}
}
