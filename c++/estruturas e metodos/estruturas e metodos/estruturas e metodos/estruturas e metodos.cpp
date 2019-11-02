// estruturas e metodos.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <string.h>
#include <locale>
using namespace std;

      struct carro {
	   string marca;
	   string cor;
	   int potencia;
	   int km;
	   int velMax;
	   float preco;
	   bool Vendido;
		void inserir(string vMarca, string vCor, int vPot, int vVelMax)
		{
			marca = vMarca;
			cor = vCor;
			potencia = vPot;
			velMax = vVelMax;
			km = 0;
			preco = 0;
			Vendido = false;
		}
		void listar() 
		{
			cout << "marca .........." << marca<<"\n";
			cout << "Cor .........." << cor << "\n";
			cout << "Potência .........." << potencia << "\n";
			cout << "KM .........." << km << "\n";
			cout << "Velocidade maxima .........." << velMax << "\n";
			cout << "Preço .........." << preco << "\n";
			if (!Vendido)cout << "Vendido: não\n\n ";
			else cout << "Vendido Sim \n\n";
		}
		void mudarKmPrecoEstado(int vKm, float vPreco, bool vVendido)
		{
			 if ( vKm >0) km = vKm;
			 if (vPreco > 0) preco = vPreco;
			 Vendido = vVendido;
		}



	};


	int main()
	{
		int i;
		setlocale(LC_ALL, "portuguese");
		carro stand[20];
		

		stand[0].inserir("Fiat", "Cinza", 70, 165);
		stand[1].inserir("Renault", "Preto", 105, 180);
		stand[2].inserir("Fiat", "Branco", 90, 165);
		stand[3].inserir("VW", "Cinza", 80, 185);
		stand[4].inserir("Lancia", "Verde", 90, 175);
		for (i = 0;i <= 19;i++) {
			if (stand[i].marca != "" && stand[i].Vendido)
				stand[i].listar();
			else break;
		}

		// Listar todos os vendidos

		

		cout << "Tudo Ok\n\n";
		system("pause");
	}




	/*carro carro1;
		// varialvel carro1 que chama o metodo inserir
		carro1.inserir("Fiat", "Preto", 65, 150);
		carro1.listar();
		system("pause"); system("cls");

		carro1.mudarKmPrecoEstado(1500,15000,1);
		system("pause"); system("cls");



		carro1.listar();
		system("pause");
		system("cls");*/


