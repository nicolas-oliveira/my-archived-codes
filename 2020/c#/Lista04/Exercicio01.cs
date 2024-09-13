// Escreva um programa em C# que implemente o Polimorfismo a partir do método
// mover(), presente na superclasse Brinquedo e nas subclasses Carro, Aviao e Barco,
// imprimindo na tela o nome da classe e o movimento. Ex.: “O avião voa.” Crie pelo
// menos dois métodos construtores e encapsule os atributos. Por fim, crie uma classe
// principal, onde deverão ser criados os objetos das classes, além das entradas
// (Console.ReadLine) e saídas (Console.WriteLine) do programa.

using System;
namespace Brinquedo {
  public class Brinquedo {
    private double velocidade, aceleracao;
    public Brinquedo() {
      this.velocidade = 0;
      this.aceleracao = 0;
    }
    public Brinquedo(double velocidade, double aceleracao) {
      this.velocidade = velocidade;
      this.aceleracao = aceleracao;
    }
    public void setVelocidade(double velocidade) {
      this.velocidade = velocidade;
    }
    public void setAceleracao(double aceleracao) {
      this.aceleracao = aceleracao;
    }
    public virtual void mover() {
      Console.WriteLine("O Brinquedo se move");
    }
    public void mover(double velocidade) {
      this.velocidade = velocidade;
      Console.WriteLine("O Brinquedo se move com velocidade de " + this.velocidade);
    }
    public void mover(double velocidade, double aceleracao) {
      this.velocidade = velocidade;
      this.aceleracao = aceleracao;
      Console.WriteLine("O Brinquedo se move com velocidade de " + this.velocidade + " e aceleração " + this.aceleracao);
    }
  }

  public class Carro : Brinquedo {
    private int aro;
    public Carro() {
      this.aro = 0;
      setAceleracao(0);
      setVelocidade(0);
    }
    public Carro(int aro) {
      this.aro = aro;
    }
    public Carro(double velocidade, double aceleracao, int aro) {
      setAceleracao(velocidade);
      setVelocidade(aceleracao);
      this.aro = aro;
    }
    public override void mover() {
      Console.WriteLine("O Carro acelera");
    }
  }

  public class Aviao : Brinquedo {
    private int qtdeTurbina;

    public Aviao() {
      this.qtdeTurbina = 0;
      setAceleracao(0);
      setVelocidade(0);
    }
    public Aviao(int qtdeTurbina) {
      this.qtdeTurbina = qtdeTurbina;
    }
    public Aviao(double velocidade, double aceleracao, int qtdeTurbina) {
      setAceleracao(velocidade);
      setVelocidade(aceleracao);
      this.qtdeTurbina = qtdeTurbina;
    }
    public override void mover() {
      Console.WriteLine("O avião voa");
    }
  }

  public class Barco : Brinquedo {
    private string tipo;

    public Barco() {
      this.tipo = "";
      setAceleracao(0);
      setVelocidade(0);
    }
    public Barco(string tipo) {
      this.tipo = tipo;
    }
    public Barco(double velocidade, double aceleracao, string tipo) {
      setAceleracao(velocidade);
      setVelocidade(aceleracao);
      this.tipo = tipo;
    }
    public void mover() {
      Console.WriteLine("O barco navega");
    }
  }

  public class Teste {
    static void Main() {
      Brinquedo bq = new Brinquedo();
      Barco bc = new Barco();
      Carro cr = new Carro();
      Aviao av = new Aviao();
      bq.mover();
      cr.mover();
      bc.mover();
      av.mover();

      cr.mover(150);
      cr.mover(150,20);
    }
  }
}