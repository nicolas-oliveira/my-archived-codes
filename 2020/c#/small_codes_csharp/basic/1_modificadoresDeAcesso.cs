//  Altere os Modificadores de Acesso/Visibilidade de TODAS as classes dos exercícios
// desenvolvidos até o momento...
//     - Alterar a visibilidade das Classes para “Publica” (public)
//     - Alterar a visibilidade dos Atributos das classes para “Privado” (private)
//     - Alterar a visibilidade dos Métodos das classes para “Publico” (public) ou
// “Protegido” (protected )

using System;
namespace Name
{
    public class Conta {
        private string dono;
        private int numero;
        private double saldo, limite;
        public Conta() {
            dono = "";
            numero = 0;
            saldo = 0;
            limite = 0;
        }
        public Conta(string dono, int numero, double saldo, double limite) {
            this.dono = dono;
            this.numero = numero;
            this.saldo = saldo;
            this.limite = limite;
        }
        protected void Saque(double quantidade) {
            saldo -= quantidade;
        }
        protected void Deposita(double quantidade) {
            saldo += quantidade;
        }
        protected double VerificaSaldo() {
            return saldo;
        }
        protected double VerificaLimite() {
            return limite;
        }
        protected void AlteraLimite(double novoLimite) {
            limite = novoLimite;
        }
        protected void AumentaLimite(double quantidade) {
            limite += quantidade;
        }
        protected void DiminuiLimite(double quantidade) {
            limite -= quantidade;
        }
    }
     public class Retangulo {
            public double lado1, lado2, area;

            public Retangulo() {
                lado1 =  0;
                lado2 = 0;
            }
            public Retangulo(double lado1, double lado2) {
                this.lado1 = lado1;
                this.lado2 = lado2;
            }
            public void calculaArea() {
                area = lado1 * lado2;
            }
            public double calculaPerimetro() {
                return 2*(lado1 + lado2);
            }
    }
     public class Pessoa {
        private string nome;
        private int idade;
        private double peso, altura;

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
        protected void AlteraNome(string novoNome) {
            nome = novoNome;
        }
        protected void AlteraIdade(int novaIdade) {
            idade = novaIdade;
        }
        protected void AlteraPeso(double novoPeso) {
            peso = novoPeso;
        }
        protected void AlteraAltura(double novaAltura) {
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
        protected int AumentaIdade(int aumento) {
            idade += aumento;
            return idade;
        }
    }
     public class Veiculo {
        private string modelo;
        private int ano;
        private double preco;

        public Veiculo() {
            modelo = "";
            ano = 0;
            preco = 0;
        }
        public Veiculo(string modelo, int ano, double preco) {
            this.modelo = modelo;
            this.ano = ano;
            this.preco = preco;
        }
        public void AlteraModelo(string novoModelo) {
            modelo = novoModelo;
        }
        public void AlteraAno(int novoAno) {
            ano = novoAno;
        }
        protected void AlteraPreco(double novoPreco) {
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
        protected double DiminuiPreco(double porc) {
            preco -= porc;
            return preco;
        }
}