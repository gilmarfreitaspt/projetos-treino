/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package caes;

/**
 *
 * @author formando
 */
public class Caes {

    /**
     * Atributos
     * @param args the command line arguments
     */
    public String nome ;
    public int peso;
    public String cor ;
    public int idade;
    public String raca;
    
    
    // métodos
    public void alimentacao(){
    
    }
    public void dormir(){
    
    }  
     public void latir(){
     if (idade <=1)
         System.out.println("yip ! yip");
     else if (idade < 3)
         System.out.println("woo! woo!");
     else
         System.out.println("Uau! Uau!");
             
             
     }
     
     public Caes(){
         
     }
    public static void main(String[] args) {
        // TODO code application logic here
        
        Caes cao1;
        cao1= new Caes();
        cao1.idade=4;
        
        Caes cao2;
        cao2= new Caes();
        cao2.idade=1;
        
        Caes cao3;
        cao3= new Caes();
        cao3.idade=2;
        
        cao1.latir();
        cao2.latir();
        cao3.latir();
        
        
        
        
        
    }
    
}
