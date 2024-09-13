using System;

namespace Pessoa {
  class Pessoa {
    private string cpf, nome, rg, dataNascimento, endereco, telefone, email;
    private bool liberado;

    public string _cpf { get { return this.cpf; } set { this.cpf = value; } }
    public string _nome { get { return this.nome; } set { this.nome = value; } }
    public string _rg { get { return this.rg; } set { this.rg = value; } }
    public string _dataNascimento { get { return this.dataNascimento; } set { this.dataNascimento = value; } }
    public string _endereco { get { return this.endereco; } set { this.endereco = value; } }
    public string _telefone { get { return this.telefone; } set { this.telefone = value; } }
    public string _email { get { return this.email; } set { this.email = value; } }
    public bool _liberado { get { return this.liberado; } set { this.liberado = value; } }

    public Pessoa() {
      this.cpf = "";
      this.nome = "";
      this.rg = "";
      this.dataNascimento = "";
      this.endereco = "";
      this.telefone = "";
      this.email = "";
      this.liberado = true;
    }

    public Pessoa(string cpf, string nome, string rg, string dataNascimento, 
    string endereco, string telefone, string email, bool liberado) {
      this._cpf = cpf;
      this._nome = nome;
      this._rg = rg;
      this._dataNascimento = dataNascimento;
      this._endereco = endereco;
      this._telefone = telefone;
      this._email = email;
      this._liberado = true;
    }

    public virtual void imprimir() {
      string s = String.Format("\nPessoa (\n {0},\n {1},\n {2},\n {3},\n {4},\n {5},\n {6}\n)\n",
        this._nome,
        this._email,
        this._cpf,
        this._telefone,
        this._dataNascimento,
        this._endereco,
        this._rg
      );
      Console.WriteLine(s);
    }
  }
}