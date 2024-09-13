using System;
// ----------------- //
// Conta
// ----------------- //
// dono: String = “Fulano”
// numero: int = 123
// saldo: double = 0
// limite: double = 100
// ----------------- //
// Conta()
// Saque(quantidade: double): void
// Deposita(quantidade: double): void
// VerificaSaldo(): double
// VerificaLimite(): double
// AlteraLimite(novoLimite: double): void
// AumentaLimite(quantidade: double): void
// DiminuiLimite(quantidade: double): void
// ----------------- //

namespace Name
{
    public class Conta{
        public string dono;
        public int numero;
        public double saldo, limite;
        public Conta(){
            dono = "";
            numero = 0;
            saldo = 0;
            limite = 0;
        }
        public Conta(string dono, int numero, double saldo, double limite){
            this.dono = dono;
            this.numero = numero;
            this.saldo = saldo;
            this.limite = limite;
        }
        public void Saque(double quantidade){
            saldo -= quantidade;
        }
        public void Deposita(double quantidade){
            saldo += quantidade;
        }
        public double VerificaSaldo(){
            return saldo;
        }
        public double VerificaLimite(){
            return limite;
        }
        public void AlteraLimite(double novoLimite){
            limite = novoLimite;
        }
        public void AumentaLimite(double quantidade){
            limite += quantidade;
        }
        public void DiminuiLimite(double quantidade){
            limite -= quantidade;
        }
    }
}