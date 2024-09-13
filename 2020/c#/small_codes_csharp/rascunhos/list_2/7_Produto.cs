using System;
namespace Estoque {
  public class Produto {
    public string descricao { set; get; }
    public string marca { set; get; }
    public string tipo { set; get; }

    public Produto() {
      this.descricao = "";
      this.marca = "";
      this.tipo = "";
    }
    public Produto(string descricao, string marca, string tipo) {
      this.descricao = descricao;
      this.marca = marca;
      this.tipo = tipo;
    }
    public Produto(string marca, string tipo) {
      this.marca = marca;
      this.tipo = tipo;
    }
  }
  public class ItemProduto : Produto {
    public float preco_custo { set; get; }
    public float margem_de_lucro { set; get; }
    public bool vendido { set; get; }
    public float Preco_venda;
    public float preco_venda { 
      set {
        Preco_venda = value;
        if(Preco_venda < preco_custo) {
          Console.WriteLine("O preço de venda está menor do que a de compra!");
        }
      } 
      get { return Preco_venda; }
    }

    public ItemProduto() {
      this.preco_custo = 0;
      this.preco_venda = 0;
      this.vendido = false;
      this.margem_de_lucro = 0;
    }
    public ItemProduto(float preco_custo, float preco_venda, bool vendido = false) {
      this.preco_custo = preco_custo;
      this.preco_venda = preco_venda;
      this.margem_de_lucro = margem_de_lucro;
      this.vendido = vendido;
    }
    public float CalcularMargemLucro() {
      this.margem_de_lucro = this.preco_venda - this.preco_custo;
      return this.margem_de_lucro;
    }
    public float MargemLucroPorcentagem() {
      this.margem_de_lucro = ((this.preco_venda - this.preco_custo) / this.preco_venda) * 100;
      return this.margem_de_lucro;
    }

  }
  public class nule {
    static void Main() {
      Produto pd = new Produto();
      ItemProduto ipd = new ItemProduto();
      Console.Write("Informe o preço de custo: ");
      ipd.preco_custo = float.Parse(Console.ReadLine());
      Console.Write("Informe o preço de venda: ");
      ipd.preco_venda = float.Parse(Console.ReadLine());
      Console.WriteLine(ipd.preco_venda);
      ipd.MargemLucroPorcentagem();
      Console.Write("Margem Lucro em Porcentagem: ");  
      Console.WriteLine(ipd.margem_de_lucro);
    }
  }
}