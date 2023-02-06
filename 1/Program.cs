using System;
class Program
{
    static void Main(string[] args)
    {
        double a ; 
        a = double.Parse(Console.ReadLine());
        Console.WriteLine(fac(a));


    }
    static double fac(double a){
        double Ans;
        if((a*a) <=4)
        {
            return 2;
        }
        else if((a*a) > 4)
        {
          Ans =  1 + fac(a-(4*Math.Abs(a))/a);
          return Ans;

        }
        else{
            return a;
        }

    }

}
