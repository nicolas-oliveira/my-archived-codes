using System;
namespace HelloWorld {
  public class Livro {
    private string titulo, autor;
    private int anoPublicacao;

    public Livro(string tit, string aut, int year) {
      titulo = tit;
      autor = aut;  
      anoPublicacao = year;
    }

    public Livro(string aut, string tit) {
      titulo = tit;
      autor = aut;  
    }

    public Livro(int year) {
      anoPublicacao = year;
    }
    
    public void setTitulo(string titulo) {
      this.titulo = titulo;
    }
    
    public string getTitulo() {
      return titulo;
    }
    
    public static void Main() {

    }
  }
}