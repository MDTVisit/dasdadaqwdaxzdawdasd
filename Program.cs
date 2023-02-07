using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        float C0 = float.Parse(Console.ReadLine());
        float P0 = float.Parse(Console.ReadLine());
        float C1 = float.Parse(Console.ReadLine());
        float P1 = float.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        for(int m=1 ;m <= n;m++){

            if (m%4 == 1){C1 = C1- (2*Math.Abs(C1-C0) );}

            else if (m%4 == 2) {P1 = P1 - (2*Math.Abs(P1-P0) );}

            else if (m%4 == 3) {C1 = C1 + (2*Math.Abs(C1-C0) );}

            else{P1 = P1+(2*Math.Abs(P1-P1));}

             
            C0 = (C0+C1)/2;
            P0 = (P0+P1)/2;
        }
        Console.WriteLine(C0);
        Console.WriteLine(P0);
        Console.WriteLine(C1);
        Console.WriteLine(P1);
    }
    
}
