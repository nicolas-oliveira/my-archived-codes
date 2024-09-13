using System;
namespace Conta {
  class ContaComum {
    public string nconta, titular;
    public float saldo;

    public ContaComum(String nc , string tit) {
        nconta = nc;
        titular = tit;
        saldo = 0;
    }

    public virtual void abertura(float valor) {
        saldo = valor;
    }

    public void deposito(float valor) {
        saldo += valor;
    }

    public virtual void saque(float valor) {
        if (saldo >= valor)
            saldo = saldo - valor;
        else
            Console.WriteLine("Saldo insuficiente");
    }

    public float verificaSaldo() {
        return saldo;
    }
  }
  class ContaEspecial : ContaComum {
    float limite;

    public ContaEspecial(String nc, string tit, float limite) : base(nc, tit) {
        this.limite = limite;
    }

    public override void abertura(float valor) {
        saldo = valor + limite;
    }

    public override void saque(float valor) {
        if (saldo >= valor) {
            if (valor > (saldo - limite))
                Console.WriteLine("Você está usando seu limite");
            else
                Console.WriteLine("Saque ok");
            saldo -= valor;
        } else
            Console.WriteLine("Saldo insuficiente");
    }
  }
  class ContaPoupanca : ContaComum {
    public ContaPoupanca(string nc, string tit) : base(nc, tit) { }

    public void rendimento() {
      Console.WriteLine("Aqui vc tem rendimento");
    }
  }
  class Program {
    static void Main() {  
      ContaComum cc = new ContaComum("2345-09", "Eurico");
      cc.abertura(100);
      
      double x;

      Console.WriteLine("Digite o valor do saque ");
      x = Convert.ToDouble(Console.ReadLine());
      cc.saque(x);
      cc.deposito(200);
      cc.saque(150);
      
      Console.WriteLine(cc.verificaSaldo());
      Console.WriteLine("Conta Especial");
      
      ContaEspecial ce = new ContaEspecial("2444-43", "Joaquim", 1000);
      
      ce.abertura(100);
      
      Console.WriteLine(ce.titular);
      
      ce.saque(150);
      
      Console.WriteLine(ce.verificaSaldo());
      
      Console.ReadKey();
    }
  }

}
