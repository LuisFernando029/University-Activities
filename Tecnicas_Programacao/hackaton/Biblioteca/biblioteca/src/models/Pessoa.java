package models;

public class Pessoa {
    private String nome;

    public Pessoa(String nome) {
        this.nome = nome;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }
    
    public void emprestarLivro(Livro livro){
        livro.emprestar();
    }
    public void devolverLivro(Livro livro){
        livro.devolver();
    }
    
}
