namespace Imobiliaria {
  class Terreno: Imovel {
    public Terreno() {}

    public Terreno(int quadra, string lote, string situacao, 
    double area, double valor) {
      base._quadra = quadra;
      base._lote = lote;
      base._situacao = situacao;
      base._area = area;
      base._valor = valor;
    }
    public override double CalcularIPTU() {
      return 0.03;
    }

    public override string imprimir() {
      string str = string.Join("\n",
        "Terreno: (",
        $"  Quadra: {this._quadra}",
        $"  Lote: {this._lote}",
        $"  Situação: {this._situacao}",
        $"  Área: {this._area}",
        $"  Valor: {this._valor}",
        ");\n"
      );
      return str;
    }
  }
}