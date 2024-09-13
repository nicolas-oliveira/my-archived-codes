using System;
namespace Fazenda {
  public class Animal {
    public virtual void Speak() {
      Console.WriteLine("");
    }
  }
  public class Pato : Animal {
    public override void Speak() {
      Console.WriteLine("Quack");
    }
  }
  public class Vaca : Animal {
    public override void Speak() {
      Console.WriteLine("Muuu");
    }
  }
  public class Porco : Animal {
    public override void Speak() {
      Console.WriteLine("Oinc");
    }
  }
  public class Fazenda {
    static void Main() {
      // Polimorfismo
		  Animal animal = new Animal();
			animal = new Pato();
      animal.Speak();
			animal = new Vaca();
      animal.Speak();
			animal = new Porco();
      animal.Speak();
    }
  }
}