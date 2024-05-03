package models;

public class Aluno extends Pessoa {
    private int numEmprestimos;

    public Aluno(String nome) {
        super(nome);
        this.numEmprestimos = 0;
    }
    @Override
    public void emprestarLivro(Livro livro) {
        if (numEmprestimos < 2) {
            super.emprestarLivro(livro);
            numEmprestimos++;         
        } else{
            System.out.println("Limite de emprestimo atingido!");
        }
    }
    
}
