using System;
namespace Estacionamento {
    public class Pessoa {
      private string nome { get; set; }
      private int idade { get; set; }
      private double peso { get; set; }
      private double altura { get; set; }

      public Pessoa() {
        this.nome = "";
        this.idade = 0;
        this.peso = 0;
        this.altura = 0;
      }

      public Pessoa(string nome, int idade, double peso, double altura) {
        this.nome = nome;
        this.idade = idade;
        this.peso = peso;
        this.altura = altura;
      }
      
      public int AumentaIdade(int aumento) {
        return this.idade += aumento;
      }

      public void printPessoa() {
        Console.WriteLine(this.nome);
        Console.WriteLine(this.idade);
        Console.WriteLine(this.peso);
        Console.WriteLine(this.altura);
      }
    }
    public class Veiculo {
      private string modelo { get; set; }
      private int ano { get; set; }
      private double preco { get; set; }

      public Veiculo() {
        this.modelo = "";
        this.ano = 0;
        this.preco = 0;
      }

      public Veiculo(string modelo, int ano, double preco) {
        this.modelo = modelo;
        this.ano = ano;
        this.preco = preco;
      }
      
      public double DiminuiPreco(double preco) {
        return this.preco -= preco;
      }
      public void printVeiculo() {
        Console.WriteLine(this.modelo);
        Console.WriteLine(this.ano);
        Console.WriteLine(this.preco);
      }
    }
    public class Foo {
      static void Main() {
        Pessoa pessoa = new Pessoa("Nicolas", 23, 63, 1.70);
        pessoa.printPessoa();

        Console.WriteLine();

        Veiculo veiculo = new Veiculo("Fusca", 1968, 1200);
        veiculo.printVeiculo();
      }
    }
}
