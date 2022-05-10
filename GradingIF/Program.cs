using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai;
            //kui kasutaja sai 'A', konsool kuvab "Suurepärane";
            //kui kasutaja sai 'B', konsool kuvab "Väga hea";
            //kui kasutaja sai 'C', konsool kuvab "Hea";
            //kui kasutaja sai 'D', konsool kuvab "Rahuldav";
            //kui kasutaja sai 'E', konsool kuvab "Kasin";
            //kui kasutaja sai 'F', konsool kuvab "Puudulik";
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus";

            //kasutame IF

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char UserResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (UserResult == 'A')
            {
                Console.WriteLine("Suurepärane");
            }
            else if (UserResult == 'B')
            {
                 Console.WriteLine("Väga hea");
            }
            else if (UserResult == 'C')
            {
                 Console.WriteLine("Hea");
            }
            else if (UserResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (UserResult == 'E')
            {
                Console.WriteLine("Kasin");
            }
            else if (UserResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine($"vale väärtus");
            }


        }
    }
}
