/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aluno;

/**
 *
 * @author formando
 */
public class Aluno {

   // atributos
    private String nome = "João";
    private String email = "joao@gmail.com";
    public  int idade = 23;
    private  char sexo = 'M';
    
    public Aluno(){

}
    public String getNome(){
        return this.nome;
    }
     public void  setNome(String nome){
         this.nome=nome;
    }
    
         public String getemail(){
        return this.email;
    }
     public void  setEmail(String email){
         this.email=email;
    }
         public int getIdade(){
        return this.idade;
    }
     public void  setIdade(int idade){
         this.idade=idade;
    }
        public char getSexo(){
        return this.sexo;
    }
     public void  setSexo(char sexo){
         this.sexo=sexo;
    }
     public void listarAluno(){
          System.out.println(" O nome do aluno é : " + this.nome);
          System.out.println(" O nome do aluno é : " + this.email);
          System.out.println(" O nome do aluno é : " + this.idade);
          System.out.println(" O nome do aluno é : " + this.sexo);
          System.out.println(" ---------------------------------- ");
          
     }
    
    
    
    
    
    
    public static void main(String[] args) {
        // TODO code application logic here
        
        
        Aluno aluno1=new Aluno();
        aluno1.listarAluno();
        
        
        aluno1.setNome("Maria");
        aluno1.setSexo('f');
        aluno1.listarAluno();
        
        Aluno aluno2 = new Aluno();
        aluno2.setNome("Felipe");
        aluno2.setIdade(44);
        aluno2.setEmail("Felipehotmail.com");
        aluno2.setSexo('M');
        aluno2.listarAluno();
        
    }
    
}
