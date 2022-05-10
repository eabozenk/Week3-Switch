using System;

namespace PersonalityTestSwitch
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
            string UserColor = Console.ReadLine().ToLower();

            //Punane, Sinine, Roheline

            switch (UserColor)
            {
                case "punane": //if (UserColor == "punane")
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {UserColor} ükssarvik");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
