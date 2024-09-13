using System;
namespace Dvd {
  public class Dvd {
    private string codigo  { get; set; }
    private string titulo { get; set; }
    private string genero { get; set; }
    private string artista { get; set; }
    private string status { get; set; }
    private int ano_de_lancamento { get; set; }
    private int  preco_compra { get; set; }
    private int  preco_venda { get; set; }

    public Dvd() {
      this.codigo = "";
      this.titulo = "";
      this.genero = "";
      this.artista = "";
      this.status = "disponível";
      this.ano_de_lancamento = 0;
      this.preco_compra = 0;
      this.preco_venda = 0;
    }
    
    public void vender() {
      status = "vendido";
    }

    public void devolver() {
      status = "disponível";
    }

    static void Main() {
      Dvd dvd1 = new Dvd();

      Console.WriteLine(dvd1.status);
    }
  }
}