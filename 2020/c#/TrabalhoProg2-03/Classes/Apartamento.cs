namespace Imobiliaria {
  public class Apartamento : Imovel {
    private string condominio;
    private int andar;

    public string _condominio { get { return this.condominio; } set { this.condominio = value; } }
    public int _andar { get { return this.andar; } set { this.andar = value; } }

    public Apartamento() {}

    public Apartamento(string condominio, int andar, int quadra, string lote, 
    string situacao, double area, double valor) {
      this.condominio = condominio;
      this.andar = andar;
      base._quadra = quadra;
      base._lote = lote;
      base._situacao = situacao;
      base._area = area;
      base._valor = valor;
    }

    public override string imprimir() {
      string str = string.Join("\n",
        "Apartamento: (",
        $"  Condominio: {this._condominio}",
        $"  Andar: {this._andar}",
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
      return 0.02;
    }
  }
}