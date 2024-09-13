using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjInterfaceConta {
  interface Conta {
    double LimitePadrao { get; set; }
    double VerSaldo();
    void Saque(double valor);
    void Deposito(double valor);
  }

  public class ContaCorrente : Conta {
    private double saldo;
    private double limite;
    public double LimitePadrao { get; set; }

    public ContaCorrente(double limite) {
      LimitePadrao = limite;
    }

    public ContaCorrente(double limite, double saldo) {
      LimitePadrao = limite;
      this.saldo = saldo;
    }
    public double VerSaldo() {
      return saldo;
    }
    public void Saque(double valor) {
      saldo = saldo - valor;
    }
    public void Deposito(double valor) {
      saldo = saldo + valor;
    }
    public ContaCorrente() {
      saldo = 0;
      limite = LimitePadrao;
    }
  }

  public class ContaPoupanca : Conta {
    private double saldo;
    public double LimitePadrao { get; set; }

    public ContaPoupanca(double limite) {
      LimitePadrao = limite;
    }

    public ContaPoupanca(double limite, double saldo) {
      LimitePadrao = limite;
      this.saldo = saldo;
    }

    public double VerSaldo() {
      return saldo;
    }

    public void Saque(double valor) {
      saldo = saldo - valor;
    }

    public void Deposito(double valor) {
      saldo = saldo + valor;
    }

    public void Rendimento(double tx, int d) {
      saldo = saldo + saldo * tx / d;
    }

    public ContaPoupanca() {
      saldo = 0;
    }
  }
  class Program {
    static void Main(string[] args) {
      ContaCorrente cc = new ContaCorrente();
      ContaPoupanca cp = new ContaPoupanca();
      int op,op1;

      do {
        Console.WriteLine("Menu : \n  1-Conta Poupança\n 2-Conta Corrente\n 3-Sair \nDigite sua opção: ");
        op = Convert.ToInt16(Console.ReadLine());

        if (op == 1) {
          double val;
          Console.WriteLine("SubMenu Conta Poupança :\n 1-Ver Saldo\n 2-Saque\n 3-Depósito\n 4-Rendimento\nEscolha uma opção: ");
          op1 = Convert.ToInt16(Console.ReadLine());

          switch (op1) {
            case 1:
              Console.WriteLine("Saldo " + cp.VerSaldo());
              break;

            case 2:
              Console.WriteLine("Qual valor do saque?  ");
              val = Convert.ToDouble(Console.ReadLine());
              cp.Saque(val);
              break;

            case 3:
              Console.WriteLine("Qual valor do depósito?  ");
              val = Convert.ToDouble(Console.ReadLine());
              cp.Deposito(val);
              break;

            case 4:
              Console.WriteLine("Qual taxa de rendimento mensal?  ");
              val = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Número de dias no mês ? ");
              int d = Convert.ToInt16(Console.ReadLine());
              cp.Rendimento(val, d);
                break;

            default:
              Console.WriteLine("Opção inválida  ");
              break;
          }
        } else
            if (op == 2) {
              Console.WriteLine("SubMenu Conta Corrente :\n 1-Ver Saldo\n 2-Saque\n 3-Depósito \n 4-Rendimento\nEscolha uma opção: ");
              op1 = Convert.ToInt16(Console.ReadLine());
              double val;

              switch (op1) {
                case 1:
                  Console.WriteLine("Saldo " + cc.VerSaldo());
                  break;

                case 2:
                  Console.WriteLine("Qual valor do saque?  ");
                  val = Convert.ToDouble(Console.ReadLine());
                  cc.Saque(val);
                  break;

                case 3:
                  Console.WriteLine("Qual valor do depósito?  ");
                  val = Convert.ToDouble(Console.ReadLine());
                  cc.Deposito(val);
                  break;

                default:
                  Console.WriteLine("Opção inválida  ");
                  break;
              }
            }
      } while (op != 3);

      Console.ReadKey();
    }
  }
}
