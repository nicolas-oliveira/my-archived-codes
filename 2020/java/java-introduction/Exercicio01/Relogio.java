package Exercicio01;
public class Relogio {
  boolean ligado;
  int horas;
  int minutos;
  int segundos;
  void ligar(int horas,int minutos,int segundos) {
    this.ligado = true;
    this.horas = horas;
    this.minutos = minutos;
    this.segundos = segundos;
  }
  void desligar() {
    this.ligado = false;
  }
  void verHorario() {
    if(ligado) {
      System.out.println(horas + ":" + minutos + ":" + segundos);
    }
  }
}