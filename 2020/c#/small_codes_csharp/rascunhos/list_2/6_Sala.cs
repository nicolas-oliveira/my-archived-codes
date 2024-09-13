// Considenrando os slides 08 e 09 , elabore :
// 1 - Classe Aluno com nome e CPF, crie os métodos de acesso
// 2-  Classe Professor com nome, CPF e área, crie os métodos de acesso
// 3 - Classe TCC com os atributos título, resumo, área e com um objeto da 
// classe Aluno e um da classe Professor.
// 4 - Elabora uma classe principal para demonstrar o uso da Classe TCC.

using System;
namespace Sala {
  public class Aluno {
    public string nome { get; set; }
    public string cpf { get; set; }
  }
  public class Professor {
    public string nome { get; set; }
    public string cpf { get; set; }
    public string area { get; set; }
  }
  public class Tcc {
    public Aluno aluno = new Aluno();
    public Professor professor = new Professor();

    public string titulo { get; set; }
    public string resumo { get; set; }
    public string area { get; set; }
  }
  public class Sala {
    static void Main() {
      Tcc tcc = new Tcc();
      tcc.aluno.nome = "Nicolas";
      tcc.professor.nome = "Vânia";
      
      Console.WriteLine(tcc.aluno.nome);
      Console.WriteLine(tcc.professor.nome);
    }
  }
}