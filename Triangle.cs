namespace ConsoleApp27;

internal class Triangle : Shape
{
    public void Erankyun()
    {
        do
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
               
                Console.WriteLine($"p = {p}");

               

                Console.WriteLine($"S =  {s}");
                break;
            }
            else
            {
                Console.WriteLine("Sxal koxmer en nermucavc");
                Koxm();

            }
        }
        while (true);

    }
}
