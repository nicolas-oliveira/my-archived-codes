using System;
namespace Controles {
  public class Controle {
    public virtual void Ligar() {
      Console.WriteLine("Ligar o aparelho");
    }
    public void Ligar(string n) {
      Console.WriteLine("Ligar o aparelho " + n);
    }
  }  
  public class ControleDaTv : Controle {
    public override void Ligar() {
      Console.WriteLine("Ligar a TV");
    }
  }
  public class ControleDoRadio : Controle {
    public override void Ligar() {
      Console.WriteLine("Ligar o radio");
    }
  }
  public class ListaTeste {
    static void Main() {
      Controle c = new Controle();
      c.Ligar();
      c.Ligar("Samsung TV");
    }
  }
}