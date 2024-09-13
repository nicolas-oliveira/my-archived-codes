// - Implemente em C# as classes abaixo, juntamente
// com seus atributos e métodos, para um sistema de
// Estacionamento.

using System;
namespace Name
{
// Definição de pessoa:
// ----------------- //
// Pessoa
// ----------------- //
// nome: String
// idade: int
// peso: double
// altura: double
// ----------------- //
// AlteraNome(novoNome: String): void
// AlteraIdade(novaIdade: int): void
// AlteraPeso(novoPeso: double): void
// AlteraAltura(novaAltura: double): void
// RetornaNome(): String
// RetornaIdade(): int
// RetornaPeso(): double
// RetornaAltura(): double
// AumentaIdade(aumento int): int
// ----------------- //
    public class Pessoa {
        public string nome;
        public int idade;
        public double peso, altura;

        public Pessoa() {
            nome = "";
            idade = 0;
            peso = 0;
            altura = 0;
        }
        public Pessoa(string nome, int idade, double peso, double altura) {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }
        public void AlteraNome(string novoNome) {
            nome = novoNome;
        }
        public void AlteraIdade(int novaIdade) {
            idade = novaIdade;
        }
        public void AlteraPeso(double novoPeso) {
            peso = novoPeso;
        }
        public void AlteraAltura(double novaAltura) {
            altura = novaAltura;
        }
        public string RetornaNome() {
            return nome;
        }
        public int RetornaIdade() {
            return idade;
        }
        public double RetornaPeso() {
            return peso;
        }
        public double RetornaAltura() {
            return altura;
        }
        public int AumentaIdade(int aumento) {
            idade += aumento;
            return idade;
        }
    }
// ----------------- //
// Veiculo
// ----------------- //
// modelo: String
// ano: int
// preco: double
// ----------------- //
// AlteraModelo(novoModelo: String): void
// AlteraAno(novoAno: int): void
// AlteraPreco(novoPreco: double): void
// PegaModelo(): String
// PegaAno(): int
// PegaPreco(): double
// DiminuiPreco(porc double): double
// ----------------- //
    public class Veiculo{
        public string modelo;
        public int ano;
        public double preco;

        public Veiculo(){
            modelo = "";
            ano = 0;
            preco = 0;
        }
        public Veiculo(string modelo, int ano, double preco) {
            this.modelo = modelo;
            this.ano = ano;
            this.preco = preco;
        }
    // AlteraAno(novoAno: int): void
    // AlteraPreco(novoPreco: double): void
    // PegaModelo(): String
    // PegaAno(): int
    // PegaPreco(): double
    // DiminuiPreco(porc double): double
    // ----------------- //
        public void AlteraModelo(string novoModelo) {
            modelo = novoModelo;
        }
        public void AlteraAno(int novoAno) {
            ano = novoAno;
        }
        public void AlteraPreco(double novoPreco) {
            preco = novoPreco;
        }
        public string PegaModelo() {
            return modelo;
        }
        public int PegaAno() {
            return ano;
        }
        public double PegaPreco() {
            return preco;
        }
        public double DiminuiPreco(double porc) {
            preco -= porc;
            return preco;
        }

    }
}
