
using System;
namespace Estoque {
  public class Pass {
    public string pd;
    public string Pd {
      get {
        return pd;
      } 
      set { // deve receber de outra variavel se nao dá stack overflow
        pd = value;
      }
    }
    public Pass() {
      this.pd = "";
    }
  }
  public class nule {
    static void Main() {
      // Pass pass = new Pass();
      string pd = Console.ReadLine();
      Console.WriteLine(pd);
    }
  }
}
