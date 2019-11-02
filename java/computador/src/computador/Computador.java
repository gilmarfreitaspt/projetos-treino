/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
  Crie uma classe chamada “Computador” com os seguintes atributos: “Marca”, “Cor”,
  “Modelo”, “Número de série e “Preço de Venda”. Implemente na classe Computador os
   seguintes métodos:

 */
package computador;

/**
 *
 * @author formando
 */
public class Computador {
  public   String marca;
  public   String cor;
  public   String modelo;
  public   double  numeroSerie;
  public   double  precoVenda;
  public double taxa,precoFinal ;
  
  void Inserir(){}
  
  void calcularvalor(){
     
       if (marca=="Hp" ){
         taxa = precoVenda * 0.30;
         precoFinal = precoVenda+taxa;}
       
        else if(marca == "Toshiba"){
           taxa = precoVenda * 0.50 ; 
           precoFinal = precoVenda+taxa;}
        
       else {
           taxa = precoVenda * 0.10;
           precoFinal = precoVenda+taxa;}
        
    System.out.println("O valor taxa de acrescimo " + taxa);
    System.out.println("O Preço Final é " + precoFinal);
  }
  
   
  
  void atualizarpreco() {}

   Computador(){

 
   }
    
    public static void main(String[] args) {
     
        Computador cp1;
        cp1= new Computador();
        cp1.marca= "Hp";
        cp1.cor= "vermelho ";
        cp1.modelo= "celerom ";
        cp1.numeroSerie= 001 ;
        cp1.precoVenda= 150 ;
        
        Computador cp2;
        cp2= new Computador();
        cp2.marca= "Toshiba";
        cp2.cor= "preto ";
        cp2.modelo= "spectro ";
        cp2.numeroSerie= 002 ;
        cp2.precoVenda= 250 ;
        
          Computador cp3;
        cp3= new Computador();
        cp3.marca= "Lenovo ";
        cp3.cor= "preto ";
        cp3.modelo= "tmc ";
        cp3.numeroSerie= 003 ;
        cp3.precoVenda= 150 ;
        
     cp1.calcularvalor();
     cp2.calcularvalor();
     cp3.calcularvalor();
     
        
    }
    
}
