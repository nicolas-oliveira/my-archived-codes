using System;
namespace Imobiliaria {
  public  class Casa {}
  public class Terreno {}
  public class Apartamento {}

  class Pessoa {
    private string cpf, nome, rg, dataNascimento, telefone, email;
    private bool liberado;
    private Endereco endereco = new Endereco();

    // Encapsulamento dos atributos através da criação de um atributo paralelo
    // que permite a manipulação da classe
    public string _cpf { get { return this.cpf; } set { this.cpf = value; } }
    public string _nome { get { return this.nome; } set { this.nome = value; } }
    public string _rg { get { return this.rg; } set { this.rg = value; } }
    public string _dataNascimento { get { return this.dataNascimento; } set { this.dataNascimento = value; } }
    public string _telefone { get { return this.telefone; } set { this.telefone = value; } }
    public string _email { get { return this.email; } set { this.email = value; } }
    public bool _liberado { get { return this.liberado; } set { this.liberado = value; } }

    public Pessoa() {
      this.cpf = "";
      this.nome = "";
      this.rg = "";
      this.dataNascimento = "";
      this.telefone = "";
      this.email = "";
      this.liberado = true;
    }

    public Pessoa(string cpf, string nome, string rg, string dataNascimento, 
    Endereco endereco, string telefone, string email, bool liberado) {
      this.cpf = cpf;
      this.nome = nome;
      this.rg = rg;
      this.dataNascimento = dataNascimento;
      this.endereco = endereco;
      this.telefone = telefone;
      this.email = email;
      this.liberado = true;
    }

    // Método responsável por retornar a string de todos os atributos das classes
    // Que por sua vez acessa as classes correspondentes à super-classe
    public virtual string imprimir() {
      string endInfo = endereco.imprimir();
      return String.Format("Pessoa: \n  Nome: {0},\n  Email: {1},\n  Cpf: {2},\n  Telefone: {3},\n  DataDeNascimento: {4},\n  RG: {5},\n{6}",
        this._nome,
        this._email,
        this._cpf,
        this._telefone,
        this._dataNascimento,
        this._rg,
        endInfo
      );
    }
  }
  class Cliente : Pessoa {}
  class Funcionario : Pessoa {}
  class EnderecoImovel {}
  class EnderecoPessoa {}
  
  public class Program {
    static void Main() {
      Console.WriteLine("Vai");
    }
  }
}
