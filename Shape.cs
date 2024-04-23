using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp27;

internal class Shape
{
    public double a;
    public double b;
    public double c;
    public double d;
    public string koxm1;
    public string koxm2;
    public string koxm3;
    public string koxm4;
    public double p;
    public double s;

    public void Koxm()
    {
        Console.WriteLine("Grel 1 koxmy");

        do
        {
            koxm1 = Console.ReadLine();
            if (double.TryParse(koxm1.ToString(), out a) && a > 0)
            {
                Console.WriteLine($"a = {koxm1}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);

        Console.WriteLine("Grel 2 koxmy");

        do
        {
            koxm2 = Console.ReadLine();
            if (double.TryParse(koxm2.ToString(), out b) && b > 0)
            {
                Console.WriteLine($"b = {koxm2}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);

        Console.WriteLine("Grel 3 koxmy");

        do
        {
            koxm3 = Console.ReadLine();
            if (double.TryParse(koxm3.ToString(), out c) && c > 0)
            {
                Console.WriteLine($" c = {koxm3}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);

    }

    public void Koxm4()
    {
        Console.WriteLine("Grel 4 koxmy");
        do

        {
            koxm4 = Console.ReadLine();
            if (double.TryParse(koxm4.ToString(), out d) && d > 0)
            {
                Console.WriteLine($" d = {koxm4}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);
    }
    public virtual void P()
    {
       
        p = a + b + c;
           
    }
    public virtual void S()
    {
   
        s = Math.Sqrt((((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)));
        
    }
}

