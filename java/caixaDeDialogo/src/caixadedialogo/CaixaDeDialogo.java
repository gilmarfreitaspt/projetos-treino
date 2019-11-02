/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package caixadedialogo;
import javax.swing.JOptionPane;
/**
 *
 * @author formando
 */
public class CaixaDeDialogo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        //Declaração de Variaves
        String nome, apelido;
        
        nome=JOptionPane.showInputDialog(null,"Digite o nome");
        apelido=JOptionPane.showInputDialog(null,"Digite o apelido");
        
        JOptionPane.showMessageDialog(null,nome+ apelido);
        
        
        
        
        
        
    }
    
}
