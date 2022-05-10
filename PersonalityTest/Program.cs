using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmik värv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romatiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {UserColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string UserColor = Console.ReadLine();

            if (UserColor == "punane")
            {
                Console.WriteLine("Oled romantiline");
            }
            else if (UserColor == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }
            else if (UserColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber");
            }
            else
            {
                Console.WriteLine($"Oled {UserColor} ükssarvik");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
