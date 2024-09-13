package Aula04;
public class Caneta {
  public String modelo;
  public String cor;
  private float ponta;
  protected int carga;
  protected boolean tampada;

  public void status() {
    System.out.println("Modelo " + this.modelo);
    System.out.println("Uma caneta " + this.modelo);
    System.out.println("Ponta " + this.ponta);
    System.out.println("Carga " + this.carga);
    System.out.println("Está tampada? " + this.tampada);
  }

  public void rabiscar() {
    if(this.tampada) {
      System.out.println("Erro: a caneta está tampada");
    } else {
      System.out.println("Estou rabiscando...");
    }
  }

  public void tampar() {
    this.tampada = true;
  }
  
  public void destampar() {
    this.tampada = false;
  }
}