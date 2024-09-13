// Crie uma classe chamada Ingresso que possui um valor em reais e um método
// imprimeValor(). 
//
// Crie uma classe Normal, que herda Ingresso e possui um método que imprime o valor 
// do ingresso e a mensagem "Ingresso Normal". 
//
// Crie uma classe VIP, que herda Ingresso e possui um valor adicional. 
//
// Crie um método que retorne o valor do ingresso, com o valor adicional incluído.
// 
// Crie uma classe CamaroteInferior, que herda da classe VIP e possui a localização 
// do ingresso e métodos para acessar e imprimir esta localização e para imprimir o
// valor do ingresso e a mensagem "Ingresso VIP - Camarote Inferior”. 
//
// Crie também uma classe CamaroteSuperior, que herda da classe VIP e é mais cara 
// (possui mais um valor - adicionalSuperior). 
//
// Esta última possui um método para retornar o valor do ingresso. 
// Por fim, crie uma classe de Teste com o método Main e crie objeto da classe Ingresso. 
//
// Peça para o usuário digitar 1 para normal e 2 para VIP. Conforme a escolha do 
// usuário, diga se o ingresso é do tipo normal ou VIP. 
// Se for VIP, peça para ele digitar 1 para camarote superior e 2 para camarote inferior. 
// Conforme a escolha do usuário, diga se que o VIP é camarote superior ou inferior. 
// Peça para o usuário digitar as informações necessárias para a instanciação do 
// objeto ingresso, dependendo do tipo de ingresso (preço, adicional, adicionalSuperior). 
// Por fim, imprima o valor do ingresso.

using System;
namespace Ingresso {
  public class Ingresso {
    protected double valor { get; set; }
    public Ingresso() {  
      this.valor = 0;
    }
    public Ingresso(double valor) {
      this.valor = valor;
    }
    public virtual void imprimeValor() {
      Console.WriteLine(valor);
    }
  }
  public class Normal : Ingresso {
    public Normal(double valor) {
      this.valor = valor;
    }
    public override void imprimeValor() {
      Console.WriteLine(valor + " Ingresso Normal");
    }
  }
  public class Vip : Ingresso {
    protected double valorAdicional;
    public Vip() {
      this.valor = 0;
      this.valorAdicional = 0;
    }
    public Vip(double valorAdicional) {
      this.valor += valorAdicional;
    }
    public Vip(double valor, double valorAdicional) {
      this.valor = valor + valorAdicional;
      this.valorAdicional = valorAdicional;
    }
  }
  public class CamaroteInferior : Vip {
    public string localizacao { get; set; }
    public CamaroteInferior(double preco, double adicionalInferior) {
      this.valorAdicional = adicionalInferior;
      this.valor = preco + adicionalInferior;
    }
    public void consulta() {
      Console.WriteLine("Localização do ingresso: " + localizacao);
    }
    public override void imprimeValor() {
      Console.WriteLine(this.valor + " Ingresso VIP - Camarote Inferior");
      
    }
  }
  public class CamaroteSuperior : Vip {
    public string localizacao { get; set; }
    public CamaroteSuperior(double preco, double adicionalSuperior) {
      this.valorAdicional = adicionalSuperior;
      this.valor = preco + adicionalSuperior;
    }
    public void consulta() {
      Console.WriteLine("Localização do ingresso: " + localizacao);
    }
    public override void imprimeValor() {
      Console.WriteLine(this.valor + " Ingresso VIP - Camarote Superior");
    }
  }
  public class Test {
    static void Main() {
      int esc1 = 0;
      int esc2 = 0;
      do {
        Console.Write("Escolha 1 para ingresso normal e 2 para VIP: ");
        esc1 = int.Parse(Console.ReadLine());

        if(esc1 == 1) {
          Console.Write("Digite o valor: ");
          double valor = double.Parse(Console.ReadLine());
          Normal ig = new Normal(valor);
          ig.imprimeValor();
          break;
        };

        if(esc1 == 2) { 
          do {
            Console.Write("Escolha 1 para Camarote Inferior e 2 para Camarote Superior: ");
            esc2 = int.Parse(Console.ReadLine());

            if(esc2 == 1 || esc2 == 2) break;
          } while(esc1 != 1 || esc1 != 2);

          if(esc2 == 1) {
            Console.Write("Digite o valor: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Digite o adicional: ");
            double adicional = double.Parse(Console.ReadLine());

            CamaroteInferior ci = new CamaroteInferior(valor, adicional);
            ci.imprimeValor();
          } 

          if(esc2 == 2) {
            Console.Write("Digite o valor: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Digite o adicional: ");
            double adicional = double.Parse(Console.ReadLine());

            CamaroteSuperior cs = new CamaroteSuperior(valor, adicional);
            cs.imprimeValor();
          };
          break;
        }
      } while(esc1 != 1 || esc1 != 2);
    }
  }
}