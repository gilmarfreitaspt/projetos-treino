/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pessoa;

/**
 *
 * @author formando
 */  
public class Pessoa {
    public String nome ;
    public char sexo ;
    public int idade;
    public double peso;
    public double altura;
    public double imc;
  
    
   
     public void dados(){
          
        }
      public void calculaImc(){
     
      imc=peso/(altura*altura);
     System.out.println(imc);
      }
    
public Pessoa(){
                 
    }
    
    public static void main(String[] args) {
        // TODO code application logic here
       
      double a;
           double b;
         Pessoa p1;
         p1= new  Pessoa();
         p1.peso=100;
         p1.altura=162;
        
         Pessoa p2;
         p2= new  Pessoa();
         p2.peso=50;
         p2.altura=175;
         
 
  p1.calculaImc();     
  p2.calculaImc();
 
  if(p1.imc > p2.imc)
      System.out.println(" O maior IMC é da pessoa 1 " + p1.imc);
      else 
      System.out.println(" O maior IMC é da pessoa 2 " + p2.imc);
          
      
  }
}
           
    
    

