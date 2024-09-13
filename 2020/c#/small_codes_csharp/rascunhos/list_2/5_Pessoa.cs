using System;

namespace name {
  public class Pessoa {
    private string nome;
    private int idade;

    public string getNome() {
      return nome;
    }
    
    public void setNome(string novoNome) {
      nome = novoNome;
    }
    
    public int getIdade() {
      return idade;
    }
    
    public Pessoa(string n, int id) {
      nome = n;
      idade = id;
    }
    
    static void Main(string[] args) {
      Pessoa p = new Pessoa("Nicolas", 22);
      Console.WriteLine(p.nome);
      p.setNome("Joao");
      Console.WriteLine(p.nome);
    }
  }
}