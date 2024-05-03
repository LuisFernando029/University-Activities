package models;

public class Livro {
    private String titulo;
    private String autor;
    private int numCopias;
    

    public Livro(String titulo, String autor, int numCopias) {
        this.titulo = titulo;
        this.autor = autor;
        this.numCopias = numCopias;
    }
    public String getTitulo() {
        return titulo;
    }
    public int getNumCopias() {
        return numCopias;
    }
    public void setNumCopias(int numCopias) {
        this.numCopias = numCopias;
    }
    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }
    public String getAutor() {
        return autor;
    }
    public void setAutor(String autor) {
        this.autor = autor;
    }
    public void emprestar() {
        if(numCopias > 0){
            numCopias--;
            System.out.println("O livro foi emprestado com sucesso.");
        } else{
            System.out.println("Não há cópias disponiveis.");
        }
    }
    public void devolver(){
        numCopias++;
        System.out.println("Livro devolvido.");
    }
    @Override
    public String toString() {
        return "Livro [titulo=" + titulo + ", autor=" + autor + "]";
    }
    
    
    
}
