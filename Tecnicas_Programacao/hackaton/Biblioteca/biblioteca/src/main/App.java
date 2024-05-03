package main;

import models.Aluno;
import models.Biblioteca;
import models.Livro;
import models.Professor;
public class App {
    public static void main(String[] args) throws Exception {

        Livro livro1 = new Livro("Harry Potter e o Cálice de Fogo", "J.K. Rowling", 5);
        Livro livro2 = new Livro("Harry Potter e o Prisioneiro de Azkaban", "J.K. Rowling", 10);

        Aluno aluno1 = new Aluno("Flavia");
        Professor professor1 = new Professor("Fabio");
        
        Biblioteca biblioteca = new Biblioteca(10);
        biblioteca.adicionar(livro1);
        biblioteca.adicionar(livro2);
        biblioteca.realizarEmp(aluno1, livro2);
        biblioteca.realizarEmp(aluno1, livro1);
        biblioteca.realizarEmp(professor1, livro1);
        biblioteca.realizarEmp(professor1, livro2);

    }
}
