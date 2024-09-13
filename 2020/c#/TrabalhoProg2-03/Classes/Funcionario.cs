namespace Imobiliaria {
  class Funcionario : Pessoa {
    private double salario, percComissao;

    public Funcionario() {}

    public Funcionario(string cpf, string nome, Endereco endereco, 
    double salario, double percComissao) {
      base._cpf = cpf;
      base._nome = nome;
      base._endereco = endereco;
      this.salario = salario;
      this.percComissao = percComissao;
    }
    
    void CalcularSalario(double comissao, double salario) {
      salario = 5000 + comissao;
    }

    public override string imprimir() {
      string str0 = base.imprimir();
      string str = string.Join("\n",
        "Funcionario: (",
        $"{str0}",
        $"  Salario: {this.salario},",
        $"  Comissão: {this.percComissao},",
        ");"
      );
      return str;
    }
  }
}