using System;
class Program {
    private static void Main() {
        Console.Clear();
        Funkcje funkcje = new();
        int[] values = new int[4];

        Console.WriteLine("<<< Fibonaci >>>\n");
            values[0] = funkcje.input("Podaj n: ");
                Console.Clear();
       
        Console.WriteLine("<<< Potęga >>>\n");
            values[1] = funkcje.input("Podaj n: ");
            values[2] = funkcje.input("Podaj x: ");
                Console.Clear();

        Console.WriteLine("<<< DecToBin >>>\n");
            values[3] = funkcje.input("Podaj liczbę diesiętną: ");
                Console.Clear();
         

        
        Console.WriteLine("Wyniki:\n");
        Console.WriteLine($"Fibonaci: F{values[0]}="+funkcje.fibonaci(values[0]));
        Console.WriteLine($"Potęga: {values[1]}^{values[2]}="+funkcje.potega(values[1],values[2]));
        Console.WriteLine($"DecToBin: dec={values[3]} bin="+funkcje.DecToBin(values[3]));
        Console.ReadKey();
    }
}

public class Funkcje {
    public int input(string textToPrint) {
        Console.Write(textToPrint);
        return int.Parse(Console.ReadLine());
    }

    public int fibonaci(int n) {
        if(n == 0) return 0;
        if(n == 1) return 1;
        
        return fibonaci(n-1) +fibonaci(n-2); 
    } 

    public int potega(int n,int x) {
        if (x==0)
            return 1;
        return n=n*potega(n,--x);
    }

    public string DecToBin(int n, string data="") {
        if(n==0)
            return data;
        data = n%2 + data; 
        return DecToBin(n/2, data);
    } 
}