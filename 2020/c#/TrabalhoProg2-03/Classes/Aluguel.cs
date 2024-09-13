namespace Imobiliaria {
  class Aluguel : Contrato {
    private double mensal;
    private int quantidadeDeMeses;
    private Imovel imovel;
    private Funcionario funcionario;
    private Cliente cliente;

    // Atributos de acesso à classe
    public double _mensal { 
      get { return this.mensal; } 
      set { this.mensal = value; } 
    }
    public int _quantidadeDeMeses { 
      get { return this.quantidadeDeMeses; } 
      set { this.quantidadeDeMeses = value; } 
    }

    public Aluguel(double mensal, int quantidadeDeMeses, Imovel imovel, 
    Funcionario funcionario, Cliente cliente) {
      this.mensal = mensal;
      this.quantidadeDeMeses = quantidadeDeMeses;
      this.imovel = imovel;
      this.funcionario = funcionario;
      this.cliente = cliente;
    }
    
    public void gerarContrato() {}

    public string imprimir() {
      string str0 = funcionario.imprimir();
      string str1 = imovel.imprimir();
      string str2 = cliente.imprimir();
      return string.Format("Aluguel: (\n {0},\n {1},\n {2},\n {3},\n {4},\n {5}\n)\n",
        this._mensal,
        this._quantidadeDeMeses,
        str0,
        str1,
        str2
      );;
    }
    
    public Aluguel() {}
  }
}