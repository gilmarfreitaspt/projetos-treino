// Ex04C++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//


#include <iostream>
#include <string>
#include <locale>
#include pch.h
using namespace std;

int main()


 {
	int op;
    inicio :
	cout << " 1 - Adi��o\n";
	cout << " 2 - Subtra��o\n";
	cout << " 3 - Multiplica��o\n";
	cout << " 4 - Divis�o\n";
	cout << " 5 - Pot�ncia\n";
	cout << " 6 - Fatorial\n";
	cout << " 0 - Terminar\n";
	cin >>  op ;
	

	if  ((op < 0) || (op > 6)){
		cout << " A op��o � invalida\n";
		cout << " escolha nomente\n";
		goto inicio;
        }
	else
		if ( op = 1 )  
		cout << " Escolheu Adi��o\n"; 
	else 
	if (op = 2) 
		cout << "Escolheu Subtra��o\n"; 
	else
	if (op = 3){
		cout << "Escolheu Multiplca��o\n";
	}
	else
	if (op = 4) {
		cout << "Escolheu Divis�o\n";
	}
	else
	if (op = 5) {
		cout << "Escolheu Potencia\n";
	}
	else
	if (op = 6) {
		cout << "Escolheu Fatorial\n";
	}
	
	
	else
		if 
       (op = 0) {
		cout << "Escolheu terminar\n";
		system("cls");
		system("pause");
		
	
	}
	

	 /*switch (op)
		   do {
		 case 1: cout << �Escolheu adi��o �; 
		 case 2: cout << �Escolheu Subitra��o �; 
		 case 3: cout << �Escolheu Multiplica��o �; 
		 case 4: cout << �Escolheu Divis�o�; 
		 case 5: cout << �Escolheu  Pot�ncia �; 
		 case 6: cout << �Escolheu Fatorial �; 
		 case 0: cout << �Escolheu Terminar �; 
        
		 }
	     break;
	    while */ 






}

