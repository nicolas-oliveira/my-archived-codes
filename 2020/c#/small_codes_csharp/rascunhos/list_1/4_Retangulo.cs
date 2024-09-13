using System;
namespace Retangulo {
  public class Retangulo {
    private int lado1 { get; set; }
    private int lado2 { get; set; }
    private double area { get; set; }
    private double perimetro { get; set; }

    public Retangulo() {
      this.lado1 = 0;
      this.lado2 = 0;
      this.area = 0;
      this.perimetro = 0;
    }

    public void calculaArea(int lado1, int lado2) {
      this.area = (lado1 * lado2);
    }

    public double calculaPerimetro(int lado1, int lado2) {
      return this.perimetro = (2 * (lado1 + lado2));
    }

    public void printaResultado() {
      Console.WriteLine(this.area);
      Console.WriteLine(this.perimetro);
    }
  }
  public class TestaRetangulo {
    static void Main() {
      Retangulo ret = new Retangulo();

      ret.calculaArea(10, 5);
      ret.calculaPerimetro(10, 5);
      ret.printaResultado();
      ret.calculaPerimetro(10, 7);
      ret.calculaArea(10, 7);
      ret.printaResultado();
    }
  }
}