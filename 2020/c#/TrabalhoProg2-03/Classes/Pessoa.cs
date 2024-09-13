namespace Imobiliaria {
  class Pessoa {
    private string nome, cpf;
    private Endereco endereco;

    public string _cpf { get { return this.cpf; } set { this.cpf = value; } }
    public string _nome { get { return this.nome; } set { this.nome = value; } }
    public Endereco _endereco { get { return this.endereco; } set { this.endereco = value; } }

    public Pessoa() {}
    
    public Pessoa(string nome, string cpf, Endereco endereco) {
      this.nome = nome;
      this.cpf = cpf;
      this.endereco = endereco;
    }

    public Pessoa(string nome, string cpf) {
      this.nome = nome;
      this.cpf = cpf;
    }
    
    public virtual string imprimir() {
      string str0 = endereco.imprimir();
      string str = string.Join("\n",
        "  Pessoa: ",
        $"    Nome: {this._nome},",
        $"    Cpf: {this._cpf},",
        str0
      );
      return str;
    }
  }
}