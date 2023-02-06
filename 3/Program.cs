using System;
class Program
{
    static void Main(String[] args)
    {
        double a;
        a = double.Parse(Console.ReadLine());
        Console.WriteLine(fac(a));


    }
    static double fac(double a)
    {
        if(a == -1 &&a ==0)
        {
            return Math.Sqrt(1-(a*a));

        }
        else if(a == 1 && a == 0){
            return -1*(Math.Sqrt(1-(a*a)));

        }
        else if(a<= -1)
        {
            return fac(a+2);

        }
        else if(a>1)
        {
            return fac(a -2);

        }
        else{
            return a;
        }

    }
}
