using System;
namespace Calculadora {
  public class Calculadora {
    private int num1 { get; set; }
    private int num2 { get; set; }
    private int resultado { get; set; }

    public Calculadora() {
      this.num1 = 0;
      this.num2 = 0;
    }

    public void soma(int num1, int num2) {
      this.resultado = num1 + num2;
    }  

    public void subtracao(int num1, int num2) {
      this.resultado = num1 - num2;
    }

    public void multiplicacao(int num1, int num2) {
      this.resultado = num1 * num2;
    }

    public void printaNumero() {
      Console.WriteLine(this.resultado);
    }
  }
  public class CalculadoraTeste {
    static void Main() {
      Calculadora nn = new Calculadora();

      nn.soma(1,3);
      nn.printaNumero();
      nn.soma(3,4);
      nn.printaNumero();
      nn.multiplicacao(3,4);
      nn.printaNumero();
    }
  }
} 