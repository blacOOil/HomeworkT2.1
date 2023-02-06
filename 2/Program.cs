using System;
class Program{
    static void Main(string[] args)
    {
        double c0,c1,p0,p1;
        int n;
        Console.Write("C0 is : ");
        c0 = double.Parse(Console.ReadLine());
        Console.Write("C1 is : ");
        c1 = double.Parse(Console.ReadLine());
        Console.Write("P0 is : ");
        p0 = double.Parse(Console.ReadLine());
        Console.Write("P1 is : ");
        p1 = double.Parse(Console.ReadLine());
         Console.Write(" n is : ");
        n = int.Parse(Console.ReadLine());

        for(int x =1;x<=n;x++)
        {
            if(x%4==1)
            {
                p0 -= 2*(Math.Abs(p0-c0));
            }
            else if(x%4==2){
                p1 -= 2*(Math.Abs(p1-c1));
            }
            else if(x%4==3){
                 p0 += 2*(Math.Abs(p0-c0));

            }
            else{
                p1 +=  2*(Math.Abs(p1-c1));
            }
            c0 = (c0 + p1)/2;
            c1 = (c1+p1)/2;

        }
        Console.WriteLine(c0);
        Console.WriteLine(c1);
        Console.WriteLine(p0);
        Console.WriteLine(p1);




    }
   
}