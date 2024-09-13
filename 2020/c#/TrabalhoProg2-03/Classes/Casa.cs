namespace Imobiliaria {
  class Casa : Imovel {
    private double areaConstruida;

    public double _areaConstruida { get { return this.areaConstruida; } set { this.areaConstruida = value; } }
    
    public Casa() {}

    public Casa(double areaConstruida, int quadra, string lote, string situacao, 
    double area, double valor) {
      this.areaConstruida = areaConstruida;
      base._quadra = quadra;
      base._lote = lote;
      base._situacao = situacao;
      base._area = area;
      base._valor = valor;
    }

    public override string imprimir() {
      string str = string.Join("\n",
        "Casa: (",
        $"  Area Construida: {this._areaConstruida}",
        $"  Quadra: {this._quadra}",
        $"  Lote: {this._lote}",
        $"  Situação: {this._situacao}",
        $"  Área: {this._area}",
        $"  Valor: {this._valor}",
        ");\n"
      );
      return str;

    }

    public override double CalcularIPTU() {
      return 0.55;
    }
  }
}