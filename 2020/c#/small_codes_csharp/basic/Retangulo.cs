using System;

namespace Name
{
    public class Retangulo {
            public double lado1, lado2, area;

            public Retangulo() {
                lado1 =  0;
                lado2 = 0;
            }
            public Retangulo(double lado1, double lado2){
                this.lado1 = lado1;
                this.lado2 = lado2;
            }
            public void calculaArea()  {
                area = lado1 * lado2;
            }
            public double calculaPerimetro() {
                return 2*(lado1 + lado2);
            }
    }
    public class testaRetangulo {
        Retangulo R1 = new Retangulo();
        public static void Main(string[] args){
            Retangulo R1 = new Retangulo();
            
            R1.lado1 = 10;
            R1.lado2 = 5;
            R1.calculaArea();
            Console.WriteLine(R1.area);
            Console.WriteLine(R1.calculaPerimetro());
        }
    }     
}
   
