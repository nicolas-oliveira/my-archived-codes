// Implemente a classe Funcionario contendo os atributos nome, cpf e salario e os
// métodos de acesso e pelo menos dois métodos construtores. Implemente também uma
// classe Gerente, filha da classe Funcionario e que possui uma senha para identificação.
// Implemente os métodos de acesso e pelo menos dois métodos construtores. Todo fim
// de ano, os funcionários do nosso banco recebem uma bonificação. Os funcionários
// comuns recebem 10% do valor do salário e os gerentes, 15%. Crie um método
// chamado “GeraBonificação()” para gerar a bonificação para o Funcionário. Faça uma
// sobrescrita desse método na classe Gerente, gerando a bonificação correta para o
// mesmo.
// O cálculo da bonificação de um Gerente pode ser feito também a partir do acréscimo
// de um determinado valor em seu salário. Faça uma sobrecarga do método
// “GeraBonificação()” da classe Gerente, passando como parâmetro um determinado
// valor para a bonificação.
// Implemente também uma classe para controlar as bonificações, denominada
// “ControleDeBonificacoes”. Essa classe terá o atributo “totalDeBonificacoes”
// iniciando com o valor 0. Esse atributo armazenará o total de bonificações. Além disso,
// essa classe terá um método para registrar as bonificações (“RegistaBonifacoes”). Esse
// método receberá como parâmetro funcionário qualquer (independente do seu tipo) e
// irá somar a bonificação desse funcionário ao total de bonificações. Deverá ser
// implementado um método para ver o total de bonificações.
// Por fim, implemente uma classe para testar as classes implementadas anteriormente,
// contendo o método Main. Instancie os seguintes objetos e define os seguintes valores.
    // 1. ControleDeBonificacoes controle = new
    // ControleDeBonificacoes();
    // 2. Funcionario funcionario1 = new Funcionario();
    // 3. funcionario1.setSalario(5000.0);
    // 4. controle. RegistaBonifacoes(funcionario1);
    // 5. Gerente gerente1 = new Gerente();
    // 6. gerente1.setSalario(1000.0);
    // 7. controle.RegistaBonifacoes(gerente1);
    // 8. System.out.println(controle.getTotalDeBonificacoes());


using System;
namespace Funcionario {

  public class Funcionario {
    protected string nome { get; set; }
    protected string cpf { get; set; }
    protected double salario { get; set; }
    public Funcionario() {
      this.nome = "";
      this.cpf = "";
      this.salario = 0;
    }
    public Funcionario(double salario) {
      this.salario = salario;
    }
    public Funcionario(string nome, string cpf, double salario) {
      this.nome = nome;
      this.cpf = cpf;
      this.salario = salario;
    }
    public virtual void geraBonificação() {
      this.salario *= 1.1;
    }
    public double getSalario() {
      return this.salario;
    }
  }
  public class Gerente : Funcionario {
    protected string senha { get; set; }
    public Gerente() {
      this.nome = "";
      this.cpf = "";
      this.salario = 0;
      this.senha = "";
    }
    public Gerente(double salario) {
      this.salario = salario;
    }
    public Gerente(string nome, string cpf, double salario, string senha) {
      this.nome = nome;
      this.cpf = cpf;
      this.salario = salario;
      this.senha = senha;
    }
    public override void geraBonificação() {
      this.salario *= 1.15;
    }
  }
  public class ControleDeBonificacoes {
    private double totalDeBonificacoes = 0;
    public void registraBonificacoes(Funcionario obj) {
      this.totalDeBonificacoes += obj.getSalario();
    }
    public double getTotalDeBonificacoes() {
      return totalDeBonificacoes;
    }
  }
  public class Test {
    static void Main() {
      ControleDeBonificacoes controle = new ControleDeBonificacoes();
      Funcionario funcionario1 = new Funcionario(5000.0);
      controle.registraBonificacoes(funcionario1);
      Gerente gerente1 = new Gerente(1000.0);
      controle.registraBonificacoes(gerente1);
      Console.WriteLine(controle.getTotalDeBonificacoes());
    }
  }
}