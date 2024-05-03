package Fatecpg.Model;

public class Docente extends Professor{
        private String nomeDocente;
        private int codDocente;
    public Docente(String nome, int id, String disciplina, String nomeDocente, int codDocente){
        super(nome, id, disciplina);
        this.nomeDocente = nomeDocente;
        this.codDocente = codDocente;
    }

    public String toString() {       
        return "Docente: \n"               
         + "Nome: "+ nomeDocente+"\n"               
         + "Codigo: "+ codDocente +"\n";   
        }
    }
