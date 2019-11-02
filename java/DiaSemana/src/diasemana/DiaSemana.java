/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package diasemana;
import javax.swing.JOptionPane;

/**
 *
 * @author formando
 */
public class DiaSemana {
 
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
         int diasemana=2;
         switch(diasemana){
             case(1):
        JOptionPane.showMessageDialog(null,"Domingo");
            break;
        case(2):
        JOptionPane.showMessageDialog(null,"Segunda");
            break;
        case(3):
        JOptionPane.showMessageDialog(null,"Terça");
            break;
        case(4):
        JOptionPane.showMessageDialog(null,"Quarta");
            break;
        case(5):
        JOptionPane.showMessageDialog(null,"Qunta");
            break;
                         
         case(6):
        JOptionPane.showMessageDialog(null,"Sexta");
            break;         
           case(7):
        JOptionPane.showMessageDialog(null,"Sabado");
            break;       
         default:
            JOptionPane.showMessageDialog(null,"Número inválido");  
                 
         }
        
        // TODO code application logic here
    }
    
}
