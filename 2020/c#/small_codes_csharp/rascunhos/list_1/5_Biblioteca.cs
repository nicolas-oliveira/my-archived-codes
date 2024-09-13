using System;
using System.Collections.Generic;

namespace Biblioteca {
  public class Obra {
    public string genero { get; set; }
    public string lingua { get; set; }
    public string autor { get; set; }
    public string editora { get; set; }
    public int ano { get; set; }

    public Obra() {
      this.genero = "";
      this.lingua = "";
      this.autor = "";
      this.editora = "";
      this.ano = 0;
    }
    public void cadastraObra(string genero, string lingua, string autor, string editora, int ano) {
      this.genero = genero;
      this.lingua = lingua;
      this.autor = autor;
      this.editora = editora;
      this.ano = ano;
    }
    public void printaObra() {
      Console.WriteLine(this.genero);
      Console.WriteLine(this.lingua);
      Console.WriteLine(this.autor);
      Console.WriteLine(this.editora);
      Console.WriteLine(this.ano);
    }
  }

  public class Usuario {
    private string cep { get; set; }
    private string nome { get; set; }
    private string telefone { get; set; }
    private int idade { get; set; }
    private bool professor { get; set; }
    private bool aluno { get; set; }
    private bool funcionario { get; set; }

    public Usuario() {
      this.cep = "";
      this.nome = "";
      this.telefone = "";
      this.idade = 0;
      this.professor = false;
      this.aluno = false;
      this.funcionario = false;
    }

    public void cadastraUsuario(string cep, string nome, string telefone, int idade) {
      this.nome = nome;
      this.cep = cep;
      this.telefone = telefone;
      this.idade = idade;
    }

    public void tipoUsuario(bool professor, bool aluno, bool funcionario){
        if(professor) {
          this.professor = true;
        }
        if(aluno) {
          this.aluno = true;  
        }
        if(funcionario) {
          this.funcionario = true;
        }
    }
    public void printaUsuario() {
      Console.WriteLine(this.nome);
      Console.WriteLine(this.cep);
      Console.WriteLine(this.telefone);
      Console.WriteLine(this.idade);
      Console.WriteLine(this.professor);
      Console.WriteLine(this.aluno);
      Console.WriteLine(this.funcionario);
    }
  }

  public class Biblioteca {
    static void Main() {
      Obra ob = new Obra();
      Usuario usr = new Usuario();

      ob.cadastraObra("Não ficção", "Português", "Machado de Assis", "Livres Livraria", 1888);
      usr.cadastraUsuario("12997-99", "Nicolas", "99159888", 22);
      usr.tipoUsuario(false, true, false);
      usr.printaUsuario();
      Console.WriteLine();
      ob.printaObra();
    }
  }
}