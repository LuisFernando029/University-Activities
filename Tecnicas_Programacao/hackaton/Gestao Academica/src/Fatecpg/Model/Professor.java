package Fatecpg.Model;

public class Professor extends Pessoa{
    private String disciplina;
    public Professor(String nome, int id, String disciplina) {
        super(nome,id);
        this.disciplina = disciplina;
    }
    public String getDisciplina() {
        return disciplina;
    }
    public void setDisciplina(String disciplina) {
        this.disciplina = disciplina;
    }
    
    public void atribuirNota(Aluno aluno, double nota) {
        aluno.setNota(nota);
    }
    @Override
    public String toString() {
        return "Professor [disciplina=" + disciplina + ", Id=" + getId() + "  Nome:  " + getNome() + "]";
    }
   

}
