using System;
namespace Conta {
  public class Conta {
    private string dono { get; set; }
    private int numero { get; set; }
    private double saldo { get; set; }
    private double limite { get; set; }

    public Conta(){
        this.dono = "";
        this.numero = 0;
        this.saldo = 0;
        this.limite = 0;
    }

    public void saque(double quantidade) {
      this.saldo -= quantidade;
    }

    public double verificaSaldo() {
      return this.saldo;
    }

    public double verificaLimite() {
      return this.limite;
    }

    public void aumentaLimite(double quantidade) {
      this.limite += quantidade;
    }

    public void diminuiLimite(double quantidade) {
      this.limite -= quantidade; 
    }

    public void deposita(double quantidade) {
      this.saldo += quantidade;
    }
  }
  public class TestaConta {
    static void Main() {
      Conta cn = new Conta();
      cn.deposita(2000);
      Console.WriteLine(cn.verificaSaldo());
      cn.saque(200);
      Console.WriteLine(cn.verificaSaldo());
    }
  }
}