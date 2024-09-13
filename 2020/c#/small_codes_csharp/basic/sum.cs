// Soma dos digitos em c#
using System;  
public class SumExample  
{  
    public static void Main(string[] args)  
    {  
        int  n,sum = 0, m;

        Console.Write("Digite um numero: ");      
        n = int.Parse(Console.ReadLine());

        while(n > 0){      
            m = n % 10;      
            sum = sum + m;      
            n= n / 10;      
        }      
        
        Console.Write("A soma é = " + sum);
    }  
}  