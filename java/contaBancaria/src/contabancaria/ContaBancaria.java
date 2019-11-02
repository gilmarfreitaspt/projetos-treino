/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package contabancaria;

/**
 *
 * @author Formando
 */
public class ContaBancaria {

    /**
     * @param args the command line arguments
     */
    
    
  
    int ibam = 0010010001;
    double saldo = 0;
    String titular ;
    double movimentos;
    String agencia = "CAixa geral de Depositos";
    String dataAbertura = "25 de Agosto 2019";
    double saldoTotal,vDeposito,vSaca,vRendimento,saldoFinal;
    
    
    public void saca(){
         if (saldo < vSaca)
          System.out.println("não tem saldo suficiente para levantar o valor pretendido Senhor " +titular); 
         else 
             saldoTotal = saldoTotal - vSaca;
             System.out.println(" ----------------------------");
              System.out.println(" o valor do saldo "+titular+" tem disponivél "+saldo+"0€");
              System.out.println(" o valor do saldo após o levantamento  é  "+saldoTotal+"0€");
    }
    public void deposita(){
       
        saldoTotal= vDeposito + saldo ;
        System.out.println("--------------***------------------");
        System.out.println("O saldo  com o novo deposito de "+ titular+"  tem disponivél  "+saldoTotal+"0€");
    }
    public double calculaRendimento(){
        vRendimento = saldo * 0.1;
       
        return vRendimento;
    }
    
    public void rendimento(){
       
      saldoTotal = saldoTotal+calculaRendimento();
         System.out.println("--------------***------------------");
        System.out.println("O saldo  com o Rendimento do "+ titular + saldoFinal+"0€");
    }
    public  ContaBancaria(){
     
        
        
    }
    
    public static void main(String[] args) {
        // TODO code application logic here
        
        ContaBancaria conta1;
        conta1=new ContaBancaria();
        conta1.saldo=1000;
        conta1.vSaca=100;
        conta1.vDeposito= 250;
        conta1.titular="Gilmar Freitas";
       
        conta1.rendimento();
        System.out.println("O rendimento mensal de  " +  conta1.calculaRendimento()+"0€");
        conta1.deposita();
        conta1.saca();
       
        ContaBancaria conta2;
        conta2=new ContaBancaria();
        conta2.saldo=50;
        conta2.vSaca=200;
        conta2.vDeposito= 50;
        conta2.titular="João";
     
    

        conta2.rendimento();
        System.out.println("O rendimento mensal de  " +  conta2.calculaRendimento()+"0€");
        conta2.deposita();
        conta2.saca();
    
    }
    
    
}
