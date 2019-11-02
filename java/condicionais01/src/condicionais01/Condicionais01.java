/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package condicionais01;
import javax.swing.JOptionPane;
/**
 *
 * @author formando
 */
public class Condicionais01 {

    
    

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      
        /* TODO code application logic here
        // programa para determinar se o numero é par ou impar
        
           int num1 = 100;
            
            if (num1%2== 0){
               // System.out.println("o número é par");
             
                
            } else {      
                   System.out.println("o número é impar"  );  
                       }*/
        /*     int num ;
             String resultado = "";
            for(int i=1;i<=20;i++){
                
                if((i%2)==0) {
                resultado += i +"," ;
            }
            }
                 JOptionPane.showMessageDialog(null,resultado);                 
            }*/
        
      String  resultado = "";
      int num ;
        int i =1 ;
        
        
       while (i <=20){
           if ((i%2)==0){
            resultado += i +"," ;   
           }
         i++;  
       }
    
     JOptionPane.showMessageDialog(null,resultado); 
     
     System.out.println( " os pares são :"+ resultado);
    
      }
}
            
    
       
                
    
    

