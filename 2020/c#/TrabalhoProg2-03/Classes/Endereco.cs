using System;

namespace Imobiliaria {
  public class Endereco {
    private string logradouro, bairro, cidade, estado, cep;
    private int numero;

    public string _logradouro { get { return this.logradouro; } set { this.logradouro = value; } }
    public string _bairro { get { return this.bairro; } set { this.bairro = value; } }
    public string _cidade { get { return this.cidade; } set { this.cidade = value; } }
    public string _estado { get { return this.estado; } set { this.estado = value; } }
    public string _cep { get { return this.cep; } set { this.cep = value; } }
    public int _numero { get { return this.numero; } set { this.numero = value; } }

    public Endereco() {}

    public Endereco(string logradouro, string bairro, string cidade, 
    string estado, string cep, int numero) {
      this.logradouro = logradouro;
      this.bairro = bairro;
      this.cidade = cidade;
      this.estado = estado;
      this.cep = cep;
      this.numero = numero;
    }

    public virtual string imprimir() {
      string str = string.Join("\n", 
      "  Endereco: ",
       $"    Rua: {this._logradouro},",
       $"    Bairro: {this._bairro},",
       $"    Cidade: {this._cidade},",
       $"    Estado: {this._estado},",
       $"    Cep: {this._cep},",
       $"    Numero: {this._numero},"
      );
      return str;
    }
  }
}