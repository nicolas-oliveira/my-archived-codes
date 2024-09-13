// Crie a classe Imovel, que possui um endereço e um preço. Crie os métodos de acesso
// e um método ImprimePreco(). 
//
// Crie também uma classe Novo, que herda Imovel e possui um adicional no preço e 
// crie os métodos de acesso e um método ImprimePreco(), acrescentando esse valor 
// adicional.  
//
// Crie uma classe Velho, que herda Imovel e possui um desconto no preço e crie os 
// métodos de acesso e um método ImprimePreco(), concedendo esse desconto.
// 
// Crie uma classe de Teste com o método Main. No método man crie um objeto da classe 
// Imovel e peça para o usuário digitar 1 para novo e 2 para velho. 
//
// Peça para o usuário digitar também o valor do imóvel e o valor adicional ou o 
// valor do desconto, considerando o tipo de imóvel definido pelo usuário. 
// Por fim, imprima o valor final do imóvel.

using System;
namespace Imovel {
  public class Imovel {
    protected string endereco { get; set; }
    protected double preco { get; set; }
    public Imovel() {
      this.endereco = "";
      this.preco = 0;
    }
    public Imovel(string endereco, int preco) {
      this.endereco = endereco;
      this.preco = preco;
    }
    public virtual void imprimePreco() {
      Console.WriteLine("Preço: " + this.preco);
    }
  }
  public class Novo : Imovel {
    private double adicional;

    public Novo(double preco, double adicional) {
      this.adicional = adicional;
      this.preco = preco;
    }
    public override void imprimePreco() {
      this.preco += this.adicional;
      Console.WriteLine("Preço: " + this.preco);
    } 
  }
  public class Velho : Imovel {
    private double desconto;

    public Velho(double preco, double desconto) {
      this.desconto = desconto;
      this.preco = preco;
    }
    public override void imprimePreco() {
      this.preco -= this.desconto;
      Console.WriteLine("Preço: " + this.preco);
    } 
  }
  public class Teste {
    static void Main() {
      Imovel im = new Imovel();
      int esc = 0;
      do {
        Console.Write("Digite 1 para novo e 2 para velho: ");
        esc = int.Parse(Console.ReadLine());
        if(esc == 1 || esc == 2) break;
      } while(esc != 1 || esc != 2);

      if(esc == 1) {
        Console.Write("Escolha o preço para o Novo Imóvel: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Escolha o valor adicional para o Novo Imóvel: ");
        double adicional = double.Parse(Console.ReadLine());
        Novo nv = new Novo(preco, adicional);
        nv.imprimePreco();
      } else {
        Console.Write("Escolha o preço para o Velho Imóvel: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Escolha o valor a ser descontado para o Velho Imóvel: ");
        double desconto = double.Parse(Console.ReadLine());
        Velho nv = new Velho(preco, desconto);
        nv.imprimePreco();
      }

    }
  }
}