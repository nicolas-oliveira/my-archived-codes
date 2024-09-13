using System;

namespace TRABALHOPROGRAMACAO {
  class Livro {
    public
    int codigo;
    string nome;
    string autor;
    string anoLancamento;
    string editora;
    string edicao;
    bool status;

    protected

    Livro() {
      status = true;
    }

    Livro(int codigo, string nome, string autor, string anoLancamento, string editora, string edicao) {
      this.codigo = codigo;
      this.nome = nome;
      this.autor = autor;
      this.anoLancamento = anoLancamento;
      this.editora = editora;
      this.edicao = edicao;
    }
    void cadastrarLivro() {
      if (!status) Console.WriteLine("Livro ja cadastrado!");
      else {
        status = false;
        Console.WriteLine("Livro cadastrado!");
      }
    }
    int getCodigo() {
      return codigo;
    }
    void setCodigo(int codigo) {
      this.codigo = codigo;
    }
    string getNome() {
      return nome;
    }
    void setNome(string nome) {
      this.nome = nome;
    }
    string getAutor() {
      return autor;
    }
    void setAutor(string autor) {
      this.autor = autor;
    }
    string getAnoLancamento() {
      return anoLancamento;
    }
    void setAnoLancamento(string anoLancamento) {
      this.anoLancamento = anoLancamento;
    }
    string getEditora() {
      return editora;
    }
    void setEditora(string editora) {
      this.editora = editora;
    }
    string getEdicao() {
      return edicao;
    }
    void setEdicao(string edicao) {
      this.edicao = edicao;
    }
  };

  class Exemplar {
    public
    int codigo;
    int nroExemplar;
    bool exclusivo;

    protected

    Exemplar() {
      exclusivo = true;
    }
    Exemplar(int codigo, int nroExemplar) {
      this.codigo = codigo;
      this.nroExemplar = nroExemplar;
    }
    void cadastrarE() {
      if (!exclusivo) Console.WriteLine("Exemplar ja cadastrado!");
      else {
        exclusivo = false;
        Console.WriteLine("Exemplar cadastrado!");
      }
    }
  }

  class Emprestimo {
    public
    int codigo;
    string dataEmprestimo;
    string dataDevolucao;
    double valorMulta;

    protected

    Emprestimo() {}
    Emprestimo(int codigo) {}
    void setCodigo(int codigo) {
      this.codigo = codigo;
    }
    void setDataEmprestimo(string dataEmprestimo) {
      this.dataEmprestimo = dataEmprestimo;
    }

    void setDataDevolucao(string dataDevolucao) {
      this.dataDevolucao = dataDevolucao;
    }

    void setValorMulta(double valorMulta) {
      this.valorMulta = valorMulta;
    }
    int getCodigo() {
      return codigo;
    }
    string getDataEmprestimo() {
      return dataEmprestimo;
    }
    string getDataDevolucao() {
      return dataDevolucao;
    }
    double getValorMulta() {
      return valorMulta;
    }
  };
}