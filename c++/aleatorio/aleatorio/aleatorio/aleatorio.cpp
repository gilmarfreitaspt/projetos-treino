#include "pch.h"
#include <iostream>
#include <time.h>
#include <string>
#include <locale>

using namespace std;

//Protótipo das funções 
//Espaço onde as funções são apresentadas
void limpa();
void parar();
int aleatorioentre(int x, int y);
float soma(float x, float y);

//Estrutura principal do programa
int main()
{

	setlocale(LC_ALL, "portuguese");
	//true random("Inicializar o timer")
	srand(time(0));

	int n = 1, i, num;
	//float num1, num2;

	char op;

	//numero de vezes a gerar
	int numOp;

	//vetor de 5 numeros aleatorios
	int numRand[5];

	//vetor de 2 estrelas
	int estrRand[2];

	//int vetor[10];

	int z = 0;

	//conta se o array ja tem o número
	int count = 0;

	// label para recomeçar
inicio:
	cout << "Quantas chaves deseja gerar?";
	cin >> numOp;

	limpa();
	parar();

	// loop com o nº de chaves pedidas
	for (int z = 0; z < numOp; z++) {

		n = z + 1;

		cout << "Chave " << n << endl;

		for (i = 0; i <= 4; i++) {
			//da-me um valor aleatorio
			num = aleatorioentre(1, 50);

			// verificar se esse numero existe no array
			for (int j = 0; j <= 4; j++) {
				if (numRand[j] == num) {
					count++;
				}
			}
			//se nao existe, inserir no array 
			if (count == 0) {
				numRand[i] = num;
			}
			// se repetido, voltar atras no ciclo
			else {
				i--;
			}
			count = 0;
			//saida do numero
			cout << num << endl;
		}

		cout << endl;
		//cout << "---------------------\n";

		cout << "Estrelas " << n << endl;
		for (i = 0; i <= 1; i++) {

			// estrela aleatoria
			num = aleatorioentre(1, 12);

			// verificar se essa estrela existe no array
			for (int j = 0; j <= 1; j++) {

				// se estrela do array é igual à estrela gerada
				if (estrRand[j] == num) {
					count++;
				}
			}
			//se a estrela nao existe no array, vou inseri-la
			if (count == 0) {
				estrRand[i] = num;
			}

			count = 0;

			cout << num << endl;

		}

		cout << "---------------------\n";

		cout << "Numeros ordenados: \n";
		//ordenar os numeros
		for (i = 0; i <= 3; i++) {
			for (int j = i + 1; j <= 4; j++) {

				// se o valor da posiçao i do array é maior que em j, troca de posiçao 
				if (numRand[i] > numRand[j]) {
					int temp;
					temp = numRand[i];
					numRand[i] = numRand[j];
					numRand[j] = temp;
				}
			}

			cout << numRand[i] << endl;
			if (i == 3) {
				cout << numRand[4] << endl;
			}

		}

		cout << "\n";

		cout << "Estrelas ordenadas: \n";
		//ordenar as estrelas
		if (estrRand[0] > estrRand[1]) {
			int temp;
			temp = estrRand[0];
			estrRand[0] = estrRand[1];
			estrRand[1] = temp;
		}

		cout << estrRand[0] << endl;
		cout << estrRand[1] << endl;

		cout << "\n\n";
	}


	cout << "(C)ontinuar (T)erminar ?";
	cin >> op;

	if (op == 'C') {
		goto inicio;
	}
	else {
		exit;
	}



}


//Construção das funções 

void limpa() {
	system("cls");
	cout << "-------------------------\n";
	cout << "--- EUROMILHÕES ---\n";
	cout << "-------------------------\n\n";

}

void parar() {
	system("pause");
}

int aleatorioentre(int n1, int n2)
{
	//Gera números entre n1 e n2 que foram pedidos do MAIN
	int valor;
	valor = rand() % (n2 - n1 + 1) + n1;
	return (valor);
}

//Exemplo da função para somar 2 numeros
float soma(float x, float y)
{
	float res;
	res = x + y;
	return (res);
}