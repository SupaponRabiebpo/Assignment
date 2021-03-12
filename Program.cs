using System;

namespace HWS3
{
    class Program
    {
        static void Main(string[] args)
        {

            string mode;
            mode = Console.ReadLine();
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x >= 0)
            {
                switch (mode)
                {
                    case "time":
                        Console.WriteLine("{0},{1}", x, Math.Pow(x - 1, 2));
                        break;
                    case "price":
                        Console.WriteLine("{0},{1}", Math.Sqrt(y) + 1, y);
                        break;
                    default:
                        Console.WriteLine("Invalid mode");
                        break;
                }

            }
            else { Console.WriteLine("Invalid mouse position"); }



        }
	}
}
