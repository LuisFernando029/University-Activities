package Fatecpg.Model;

public class Estagiario extends Aluno {
    private String nomeEstagiario;
    private String docEstagiario;

    public Estagiario(String nome, int id, double nota, int matricula, String historico, String nomeEstagiario, String docEstagiario){
        super(nome, id, nota, matricula, historico);
        this.nomeEstagiario = nomeEstagiario;
        this.docEstagiario = docEstagiario;
    }

    public String toString() {       
        return "Estagiario: \n"               
         + "Nome: "+ getNome()+"\n"               
         + "id: "+ getId() +"\n"
         + "Nota: "+ getNota()+"\n"               
         + "Nome: "+ nomeEstagiario +"\n"
         + "Doc: "+ docEstagiario+"\n";   
    }
}
