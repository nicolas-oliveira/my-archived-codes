namespace Imobiliaria {
  class Venda : Contrato {
    private double valorTotal, comissao;
    private int totalDeParcelas;
    private string formaPagamento;
    private Funcionario funcionario;
    private Imovel imovel;
    private Cliente cliente;

    public double _valorTotal { get { return this.valorTotal; } set { this.valorTotal = value; } }
    public double _comissao { get { return this.comissao; } set { this.comissao = value; } }
    public int _totalDeParcelas { get { return this.totalDeParcelas; } set { this.totalDeParcelas = value; } }
    public string _formaPagamento { get { return this.formaPagamento; } set { this.formaPagamento = value; } }
    
    public Venda() {}

    public Venda(double valorTotal, double comissao, int totalDeParcelas, string formaPagamento, 
    Funcionario funcionario, Imovel imovel, Cliente cliente) {
      this.valorTotal = valorTotal;
      this.comissao = comissao;
      this.totalDeParcelas = totalDeParcelas;
      this.formaPagamento = formaPagamento;
      this.funcionario = funcionario;
      this.imovel = imovel;
      this.cliente = cliente;
    }

    public void gerarContrato() {}
    
    public string imprimir() {
      string str0 = funcionario.imprimir();
      string str1 = imovel.imprimir();
      string str2 = cliente.imprimir();
      string str = string.Format("Venda: (\n {0},\n {1},\n {2},\n {3},\n {4},\n {5},\n {6}\n)\n",
        this._valorTotal,
        this._comissao,
        this._totalDeParcelas,
        this._formaPagamento,
        str0,
        str1,
        str2
      );
      return str;
    }
  }
}