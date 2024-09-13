// Crie uma classe “Alimento” que possua os atributos “descricao” (texto), “preco”
// (decimal) e “validade” (inteiro), crie dois métodos construtores e os métodos
// assessores para estes atributos. 
//
// Crie também um método “VerificaValidade()” que imprimirá a validade dos 
// alimentos (em dias) e um método “ImprimeInformacoes()” para imprimir a 
// descrição concatenada com o preço e a validade. 
//
// Crie duas classes filhas de “Alimento”, que serão “AlimentoPerecivel” com o 
// atributo “tipo” (texto) e “AlimentoIndustrializado” com o atributo “fabricante” 
// (texto). 
//
// Crie dois métodos construtores e os métodos assessores para ambas as classes filhas. 
// Considere a validade dos alimentos perecíveis como horas e dos alimentos 
// industrializados como dias. 
//
// Reescreva o método “VerificaValidade()” nas classes filhas imprimindo a validade 
// em dias (classe “AlimentoPerecivel” ou em horas (AlimentoIndustrializado), 
// dependendo o tipo do produto. Por fim reescreva o método “ImprimeInformacoes()” 
// para imprimir a descrição concatenada com o preço, a validade e o tipo para a 
// subclasse “AlimentoPerecivel” e para imprimir descrição concatenada com o preço, 
// a validade e o fabricante para a subclasse “AlimentoIndustrializado”.
//
// Não esqueça de informar se a validade é em horas ou em dias.
// Crie uma classe “Teste” contendo o método “Main” que irá simular a compra de
// conjunto de alimentos, independentemente do tipo de alimento. Cada produto
// comprado deverá ser armazenado em um vetor na classe “Main”. 
//
// Esse vetor/arraylist deve se chamar “carrinho” que simula o carrinho de compras 
// de produtos alimentícios de um cliente em um e-commerce. Insira nesse “carrinho” 
// vários alimentos perecíveis e alimentos industrializados e depois chame o método
// “getDescrição” e “getValidade” de todos os objetos presentes no vetor/arraylist 
// para o usuário do carrinho saber as informações dos produtos em seu carrinho.


using System;
namespace Alimento {
  public class Alimento {
    protected string descricao { get; set; }
    protected decimal preco { get; set; }
    protected int validade { get; set; }
    public Alimento() {
      this.descricao = "";
      this.preco = 0;
      this.validade = 0;
    }
    public Alimento(string descricao, decimal preco, int validade) {
      this.descricao = descricao;
      this.preco = preco;
      this.validade = validade;
    }
    public virtual void verificaValidade() {
      Console.WriteLine("O produto vence em " + this.validade + " dias");
    }
    public virtual void imprimeInformacoes() {
      Console.WriteLine("\nPreço: " + this.preco + "\nValidade: "+ this.validade +"\nDescrição: "+ this.descricao);
    }
  }
  public class AlimentoPerecivel : Alimento {
    protected string tipo { get; set; }
    public AlimentoPerecivel() {
      this.descricao = "";
      this.preco = 0;
      this.validade = 0;
      this.tipo = "";
    }
    public AlimentoPerecivel(decimal preco, int validade, string tipo, string descricao) {
      this.descricao = descricao;
      this.preco = preco;
      this.validade = validade;
      this.tipo = tipo;
    }
    public override void verificaValidade() {
      Console.WriteLine("O produto vence em " + this.validade + " horas");
    }
    public override void imprimeInformacoes() {
      Console.WriteLine("\nPreço: " + this.preco + "\nValidade(horas): "+ this.validade +"\nDescrição: "+ this.descricao);
    }
  }
  public class AlimentoIndustrializado : Alimento {
    protected string fabricante { get; set; }
    public AlimentoIndustrializado() {
      this.descricao = "";
      this.preco = 0;
      this.validade = 0;
      this.fabricante = "";
    }
    public AlimentoIndustrializado(decimal preco, int validade, string fabricante, string descricao) {
      this.descricao = descricao;
      this.preco = preco;
      this.validade = validade;
      this.fabricante = fabricante;
    }
    public override void imprimeInformacoes() {
      Console.WriteLine("\nPreço: " + this.preco + "\nValidade(dias): "+ this.validade +"\nDescrição: "+ this.descricao);
    }
  }
  public class Test {
    static void Main() {
      Alimento[] carrinho = new Alimento[3];
      carrinho[0] = new AlimentoIndustrializado(12, 120, "Qualty", "Manteiga");
      carrinho[1] = new AlimentoPerecivel(6, 200, "Verdura", "Alface");
      carrinho[2] = new AlimentoPerecivel(4, 600, "Frutas", "Maçã");
      for(int i = 0; i < 3; i++){
        carrinho[i].imprimeInformacoes();
      }
    }
  }
}