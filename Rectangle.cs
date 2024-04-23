namespace ConsoleApp27;

internal class Rectangle : Shape
{   

    public override void P()
    {
      p = a + b + c + d;
    }
    public override void S() 
    {
        s = a * b;
    }

    public void Uxankyun()
                           //  |--------------|
                          // a |              | d
                           //  |              | 
                           //  |______________|
                           //        b
    {
        do
        {
            if ((a == d) && (c == b))
            {

                
                Console.WriteLine($"P = {p}");
                
                Console.WriteLine($"S = {s}");
                break;
            }
            else
            {
                Console.WriteLine("Sxal koxmer en nermucvac");
                Koxm();
                Koxm4();

            }
        }
        while (true);
    }
}
