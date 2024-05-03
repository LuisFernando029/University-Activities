package Fatecpg;

import Fatecpg.Model.Aluno;
import Fatecpg.Model.Professor;

public class Main {
    public static void main(String[] args) {
        Aluno aluno = new Aluno("Julia", 333, 0, 555, "aprovado" );
        Professor professor = new Professor("Alessandro", 656, "Tecnicas de Programação");
        
        aluno.setProfessor(professor);
        System.out.println(aluno.getProfessor());
        
        aluno.setHistorico("Aprovado!");
        professor.atribuirNota(aluno, 8.5);

        System.out.println(aluno.getHistorico());
        System.out.println("Nota do aluno: " + aluno.getNota());
    }
}
    

