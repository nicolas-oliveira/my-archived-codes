using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaRemota2 {
  class Program {
    static void Main(string[] args) {
      Veiculo v1 = new Veiculo("GM", 300);
      Console.WriteLine(v1.getMarca());
      Carro c = new Carro(4, "Fiat", 320);
      Console.WriteLine(c.getNumPortas());
      Console.WriteLine(c.getMarca());
      Console.ReadKey();
    }
  }
  class Veiculo {
    private string marca;
    private int velocidade;
    public Veiculo(string marca, int velocidade) {
      this.marca = marca;
      this.velocidade = velocidade;
    }
    public string getMarca() {
        return marca;
    }
    public void setMarca(string nMarca) {
        marca = nMarca;
    }
  }
  class Carro : Veiculo {
    private int numPortas;
    public Carro(int numPortas, string marca, int velocidade ) : base(marca, velocidade) {
      this.numPortas = numPortas;
    }
    public void setNumPortas(int np) {
      numPortas = np;
    }
    public int getNumPortas() {
      return numPortas;
    }
  }
}
