package models;

public class Biblioteca {
    private Livro[] livros;
    private int numLivros;
    
    public Biblioteca(int tamMax) {
       livros = new Livro[tamMax];
       numLivros = 0;
    }
    
    public void adicionar(Livro livro){
        if (numLivros < livros.length) {
            livros[numLivros] = livro;
            numLivros++;
            System.out.println("Livro adicionado à biblioteca.");
        } else {
            System.out.println("Capacidade de livros atingido.");
        }
    }

    public void realizarEmp(Pessoa pessoa, Livro livro){
        pessoa.emprestarLivro(livro);
    }
    public void realizarDev(Pessoa pessoa, Livro livro){
        pessoa.devolverLivro(livro);
    }

}
