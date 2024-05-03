package Fatecpg.Model;

public class Aluno extends Pessoa {
    private double nota;
    private int matricula;
    private String historico;
    private Professor professor;

    public Aluno(String nome, int id, double nota, int matricula, String historico) {
        super(nome, id);
        this.nota = nota;
        this.matricula = matricula;
        this.historico = historico;
    }
    public double getNota() {
        return nota;
    }
    public void setNota(double nota) {
        this.nota = nota;
    }
    public void setNome(double nota) {
        this.nota = nota;
    }
    public int getMatricula() {
        return matricula;
    }
    public void setMatricula(int matricula) {
        this.matricula = matricula;
    }

    public String getHistorico() {
        return this.historico;
    }

    public void setHistorico(String historico) {
        this.historico = historico;
    }

    public String gerarHistorico() {
        return "Aprovado!";
    }

    public void setProfessor(Professor professor) {
        this.professor = professor;
    }

    public Professor getProfessor() {
        return this.professor;
    }
   
}
