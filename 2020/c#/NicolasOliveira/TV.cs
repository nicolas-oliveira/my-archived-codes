using System;
using System.Collections.Generic;
using System.Text;
namespace Imobiliaria {
  public interface ControleRemoto {
    void MudarCanal(int canal);
    void AumentaVolume(int taxa);
    void DiminuiVolume(int taxa);
    bool Ligar();
    bool Desligar();
  }

  public class TV {
    private int tamanho, canal, volume;
    private bool ligada;

    public int _tamanho { get { return this.tamanho; } set { this.tamanho = value; } }
    public int _canal { get { return this.canal; } set { this.canal = value; } }
    public int _volume { get { return this.volume; } set { this.volume = value; } }
    public bool _ligada { get { return this.ligada; } set { this.ligada = value; } }

    public TV() {}

    public TV(int tamanho) {
      this.tamanho = tamanho;
    }
  }

  public class ModeloTV : TV, ControleRemoto {
    private string marca, modelo;

    public string _marca { get { return this.marca; } set { this.marca = value; } }
    public string _modelo { get { return this.modelo; } set { this.modelo = value; } }
    
    public ModeloTV() {}

    public ModeloTV(int tamanho) {
      base._tamanho = tamanho;
    }

    public void MudarCanal(int canal) {
      base._canal = canal;
    }

    public void AumentaVolume(int taxa) {
      base._volume += taxa;
    }

    public void DiminuiVolume(int taxa) {
      base._volume -= taxa;
    }

    public bool Ligar() {
      return base._ligada = true;
    }

    public bool Desligar() {
      return base._ligada = false;
    }

    public string imprimir() {
      return string.Join("\n",
        "ModeloTV: (",
        $"  Modelo: {this._modelo}",
        $"  Marca: {this._marca}",
        $"  Canal: {this._canal}",
        $"  Volume: {this._volume}",
        $"  Ligada: {this._ligada}",
        ");\n"
      );
    }

  }

  public class Principal {
    public List<ModeloTV> tvs =  new List<ModeloTV>();

    public Principal() {}

    public void pesquisaModelo(List<ModeloTV> lista, string modelo) {
      int count = 0;
      bool encontrado = false;
      foreach (var item in lista) {
        count++;
        if(item != null) {
          if(item._modelo == modelo) {
            encontrado = true;
            Console.WriteLine($"{item.imprimir()}");
          }
        }
      }
      if(encontrado) {
        Console.WriteLine($"Numero de TVs encontradas: {count}");
        Console.Write("Digite qualquer tecla para continuar...");
        Console.ReadLine();
      } else {
        Console.WriteLine("Modelo não encontrado");
      }
    }

    public void pesquisaMarca(List<ModeloTV> lista, string marca) {
      int count = 0;
      bool encontrado = false;
      foreach (var item in lista) {
        if(item != null) {
          if(item._marca == marca) {
            count++;
            encontrado = true;
            Console.WriteLine($"{item.imprimir()}");
          }
        }
      }
      if(encontrado) {
        Console.WriteLine($"Numero de TVs encontradas: {count}");
        Console.Write("Digite qualquer tecla para continuar...");
        Console.ReadLine();
      } else {
        Console.WriteLine("Marca não encontrado");
      }
    }

    public static void Main() {
      Principal principal = new Principal();

      int op;
      do {
        Console.WriteLine("    TV");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1 - Ler valores dos campos");
        Console.WriteLine("2 - Consultar modelo");
        Console.WriteLine("3 - Consultar marca\n");
        Console.WriteLine("0 - Sair\n");

        Console.Write("Escolha uma opção: ");
        op = int.Parse(Console.ReadLine());
        Console.Clear();

        if(op == 1){
          int tamanho;
          string marca, modelo;
          Console.WriteLine("Digite o tamanho: ");
          tamanho = int.Parse(Console.ReadLine());

          ModeloTV tv = new ModeloTV(tamanho);

          Console.WriteLine("Digite a marca: ");
          marca = Console.ReadLine();
          Console.WriteLine("Digite o modelo: ");
          modelo = Console.ReadLine();
          tv._marca = marca;
          tv._modelo = modelo;

          principal.tvs.Add(tv);

          Console.Clear();
          Console.WriteLine(tv.imprimir());
          Console.ReadLine();
          Console.Clear();
        }

        if(op == 2) {
          string modelo;
          Console.WriteLine("Digite o modelo: ");
          modelo = Console.ReadLine();
          principal.pesquisaModelo(principal.tvs, modelo);
        }

        if(op == 3) {
          string marca;
          Console.WriteLine("Digite a marca: ");
          marca = Console.ReadLine();
          principal.pesquisaModelo(principal.tvs, marca);
        }

      } while(op != 0);
    }
  }
}