namespace Imobiliaria {
  class Cliente : Pessoa {
    private bool liberado;
  
    public bool _liberado { get { return this.liberado; } set { this.liberado = value; } }

    public Cliente() {}

    public Cliente(string cpf, string nome, Endereco endereco, bool liberado) {
      base._cpf = cpf;
      base._nome = nome;
      base._endereco = endereco;
      this.liberado = liberado;
    }
    
    public override string imprimir() {
      string str0 = base.imprimir();
      string str = string.Join("\n", 
        "Cliente: (",
        $"{str0}",
        $"  Liberado: {this._liberado}",
        ");"
      );
      return str;
    }
  }
}