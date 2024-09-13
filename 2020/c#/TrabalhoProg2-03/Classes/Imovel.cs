using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria {
  public abstract class Imovel {
    private int quadra;
    private string lote, situacao;
    private double area, valor;
    private Endereco endereco;
    private Cliente cliente;
    
    public int _quadra { get { return this.quadra; } set { this.quadra = value; } }
    public string _lote { get { return this.lote; } set { this.lote = value; } }
    public string _situacao { get { return this.situacao; } set { this.situacao = value; } }
    public double _area { get { return this.area; } set { this.area = value; } }
    public double _valor { get { return this.valor; } set { this.valor = value; } }

    public Imovel() {}

    public Imovel(string situacao, double valor) {
      this.situacao = situacao;
      this.valor = valor;
    }

    public abstract string imprimir();

    public abstract double CalcularIPTU();
  }
}