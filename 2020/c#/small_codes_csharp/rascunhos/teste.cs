
using System;
namespace Aluno {
  public class MyInt {
    private int myint;
    public int _myint 
    { 
      get { return _myint; } 
      set { myint = value; }
    }
  }

  public class nule {
    static void Main() {
      MyInt myclass = new MyInt();
      myclass._myint = 1;
      Console.WriteLine(myclass._myint);
    }
  }
}
