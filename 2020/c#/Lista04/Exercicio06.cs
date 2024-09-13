// Crie uma classe Conta, que possua um número e um saldo e os métodos para pegar
// saldo, depositar e sacar. 
// Adicione o atributo número da conta e saldo. 
//
// Crie os métodos assessores, Deposita(double) e Saca(double).
//
// Crie também um método chamado Atualiza para atualizar essa conta de acordo 
// com uma taxa percentual fornecida.
//
// Crie duas subclasses da classe Conta: ContaCorrente e ContaPoupanca. Ambas terão
// o método Atualiza reescrito: A ContaCorrente deve atualizar-se com o dobro da taxa
// e a ContaPoupanca deve atualizar-se com o triplo da taxa.
//
// Além disso, a ContaCorrente deve reescrever o método Deposita, a fim de retirar uma
// taxa bancária de dez centavos de cada depósito.
//
// Por fim, crie uma classe com método “Main” e instancie essas classes
// implementadas, faça um depósito em cada uma das instâncias, atualize-as e veja o
// resultado (saldo).
//
// Por fim, crie uma classe “Relatorio” que será responsável por mostrar a
// movimentação de todas as contas bancárias. Essa classe terá um método chamado
// “MostraMovimentacao” que receberá como parâmetro uma conta qualquer e
// imprimirá o número da conta movimentada e o saldo atual dessa conta.

using System;
namespace Conta {
  public class Conta {
    private int numero;
    private double saldo, taxa;
    public Conta() {
      this.numero = 0;
      this.saldo = 0;
      this.taxa = 0;
    }
    public double getNumero() {
      return this.numero;
    }
    public void setNumero(double saldo) {
      this.numero = numero;
    }
    public double getSaldo() {
      return this.saldo;
    }
    public void setSaldo(double saldo) {
      this.saldo = saldo;
    }
    public void setTaxa(double taxa) {
      this.taxa = taxa;
    }
    public double getTaxa() {
      return this.taxa;
    }
    public virtual void depositar(double n) {
      this.saldo += n;
    }
    public void sacar(double n) {
      this.saldo -= n;
    }
    public virtual void atualizar() {
      
    }
  }
  public class ContaCorrente : Conta {
    public override void atualizar() {
      setTaxa(getTaxa()*2);
    }
    public override void depositar(double n) {
      double value = getSaldo() + (n - 0.1);
      setSaldo(value);
    }
  }
  public class ContaPoupanca : Conta {
    public override void atualizar() {
      setTaxa(getTaxa()*3);
    }
  }
  public class Relatorio {
    public void mostraMovimentacao(Conta c) {
      Console.WriteLine(c.getNumero());
      Console.WriteLine(c.getSaldo());
    }
  }
  public class Test {
    static void Main() {
      Relatorio rl = new Relatorio();

      ContaCorrente cc = new ContaCorrente();
      cc.depositar(1000);
      cc.sacar(100);
      ContaPoupanca cp = new ContaPoupanca();
      cp.depositar(1000);
      cp.sacar(100);

      rl.mostraMovimentacao(cc);
      rl.mostraMovimentacao(cp);
    }
  }
}