using System;
using System.Security.Cryptography.X509Certificates;

namespace TRABALHOPROGRAMACAO {
  class Curso {
    public
    string nome;
    string area;
    bool status;
    double valorMensalidade;

    Curso() {}
    Curso(string nome, string area, double valorMensalidade) {
      this.nome = nome;
      this.area = area;
      this.valorMensalidade = valorMensalidade;
      status = true;
    }

    void cadastrar() {
      if (!status) Console.WriteLine("Curso já cadastrado");
      else {
        status = false;
        Console.WriteLine("Curso cadastrado");
      }
    }
    public string getNome() {
      return nome;
    }
    string getArea() {
      return area;
    }
    public void setArea(string area) {
      this.area = area;
    }
    double getValorMensalidade() {
      return valorMensalidade;
    }
    void setValorMensalidade(double valorMensalidade) {
      this.valorMensalidade = valorMensalidade;
    }

    internal string setNome(string nomecurso) {
      return nomecurso;
    }
  };
}