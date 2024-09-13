using System;
using System.Collections.Generic;
using System.Text;

namespace TRABALHOPROGRAMACAO {
  class Endereço {
    public
    string cep;
    string logradouro;
    string bairro;
    string cidade;
    string estado;
    int numero;
    string complemento;

    protected

    Endereço() {}
    Endereço(string cep, string logradouro, string bairro, string cidade, string estado, int numero, string complemento) {
      this.cep = cep;
      this.logradouro = logradouro;
      this.bairro = bairro;
      this.cidade = cidade;
      this.estado = estado;
      this.complemento = complemento;
      this.numero = numero;
    }
    void inserirEndereco() {
      Console.WriteLine("Digite seu cep:");
      string cep = Console.ReadLine();
      Console.WriteLine("Digite seu logradouro:");
      string logradouro = Console.ReadLine();
      Console.WriteLine("Digite seu bairro:");
      string bairro = Console.ReadLine();
      Console.WriteLine("Digite sua cidade:");
      string cidade = Console.ReadLine();
      Console.WriteLine("Digite seu estado:");
      string estado = Console.ReadLine();
      Console.WriteLine("Digite seu complemento:");
      string complemento = Console.ReadLine();
      Console.WriteLine("Digite seu numero:");
      int numero = int.Parse(Console.ReadLine());
    }
    void setCep(string cep) {
      this.cep = cep;
    }
    void setLogradouro(string logradouro) {
      this.logradouro = logradouro;
    }
    void setBairro(string bairro) {
      this.bairro = bairro;
    }
    void setCidade(string cidade) {
      this.cidade = cidade;
    }
    void setEstado(string Estado) {
      this.estado = Estado;
    }
    void setComplemento(string complemento) {
      this.complemento = complemento;
    }
    void setNumero(int numero) {
      this.numero = numero;
    }
    string getCep() {
      return cep;
    }
    string getLogradouro() {
      return logradouro;
    }
    string getBairro() {
      return bairro;
    }
    string getCidade() {
      return cidade;
    }
    string getEstado() {
      return estado;
    }
    string getComplemento() {
      return complemento;
    }
    int getNumero() {
      return numero;
    }
  }
}