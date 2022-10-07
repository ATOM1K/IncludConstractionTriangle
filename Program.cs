using System;

namespace IncludConstractionTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
        Restart://point of the restart if program catch some trouble
            Console.WriteLine("Enter Triangle scale:");
            try
            {
                int triangleScale = int.Parse(Console.ReadLine());
                for (int fCounter = 0; fCounter < triangleScale; fCounter++)    //painting triangle
                {
                    for (int sCounter = 0; sCounter <= fCounter; sCounter++)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int fCounter = 0; fCounter < triangleScale; fCounter++)
                {
                    for (int sCounter = triangleScale; sCounter > fCounter; sCounter--)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int fCounter = 0; fCounter < triangleScale; fCounter++)    //painting triangle
                {
                    for (int sCounter = triangleScale; sCounter > fCounter; sCounter--)
                    {
                        Console.Write(" ");
                    }
                    for (int sCounter = 0; sCounter <= fCounter; sCounter++)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int fCounter = 0; fCounter < triangleScale; fCounter++)    //painting triangle
                {
                    for (int sCounter = triangleScale; sCounter > fCounter; sCounter--)
                    {
                        Console.Write(" ");
                    }
                    for (int sCounter = 0; sCounter <= fCounter; sCounter++)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            catch (Exception)
            {
                Console.WriteLine("You need enter number, not another symbols!");
                goto Restart; // use this for restart program and not stop process until we haven't result.
            }
        }
    }
}
