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
	cout << " 1 - Adição\n";
	cout << " 2 - Subtração\n";
	cout << " 3 - Multiplicação\n";
	cout << " 4 - Divisão\n";
	cout << " 5 - Potência\n";
	cout << " 6 - Fatorial\n";
	cout << " 0 - Terminar\n";
	cin >>  op ;
	

	if  ((op < 0) || (op > 6)){
		cout << " A opção é invalida\n";
		cout << " escolha nomente\n";
		goto inicio;
        }
	else
		if ( op = 1 )  
		cout << " Escolheu Adição\n"; 
	else 
	if (op = 2) 
		cout << "Escolheu Subtração\n"; 
	else
	if (op = 3){
		cout << "Escolheu Multiplcação\n";
	}
	else
	if (op = 4) {
		cout << "Escolheu Divisão\n";
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
		 case 1: cout << “Escolheu adição ”; 
		 case 2: cout << “Escolheu Subitração ”; 
		 case 3: cout << “Escolheu Multiplicação ”; 
		 case 4: cout << “Escolheu Divisão”; 
		 case 5: cout << “Escolheu  Potência ”; 
		 case 6: cout << “Escolheu Fatorial ”; 
		 case 0: cout << “Escolheu Terminar ”; 
        
		 }
	     break;
	    while */ 






}

