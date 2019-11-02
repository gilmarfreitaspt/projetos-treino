/*
 * To change this license header, choose License Headers in Project Properties.
Crie uma classe que implemente um Objeto Bola que contenha os seguintes atributos: cor
(String), tamanho (Inteira) e cheia (lógico). Crie um construtor que receba a cor da bolae o
tamnho, e inicie o objeto com os valores passados e o estado de cheia como falso:
Implemente dois métodos: encher() para ativar o estado de cheia para verdadeiro e esvaziar
para alterar para falso. Crie um aplicativo em Java que declare e instancie2 objetos da classe
Bola, e instancia com as cores “Azul” e “Amarelo”, de tamanho 60 e 40, respetivamente, em
seguida encher as duas bolas instanciadas, e em seguida esvaziar a segunda bola.
 * and open the template in the editor.
 */
package bola;

/**
 *
 * @author formando
 */
public class Bola {

    
    
    public String cor ;
    public int tamanho;
    public boolean cheia= false;
    
    
    
     public void corBola(){
    
    }  
      public void estadoBola(){
      if (cheia == false){
          cheia = true;
          System.out.println("vai jogar  a bola ela está cheia  ");}
          else{
          System.out.println("Não vai jogar  a bola ela está vasia  ");}
    }  
    
    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        
         Bola bola1;
        bola1= new Bola();
        bola1.cor="Azul";
        bola1.tamanho=60;
        bola1.cheia=true;
        
                
         Bola bola2;
        bola2= new Bola();
        bola2.cor="Amarela";
        bola2.tamanho=40;
        bola2.cheia=false;
        
        
        bola1.estadoBola();
        bola2.estadoBola();
        
        
        
        
        // TODO code application logic here
    }
    
}
