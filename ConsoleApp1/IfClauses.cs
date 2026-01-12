using System;
using System.Collections.Generic;
using System.Text;

namespace DaveLernt
{
    internal class IfClauses
    {
        public void ShowIfClauses()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hallo, {name}");
            Console.Write("Geburtsjahr: ");
            int geburtsjahr = int.Parse(Console.ReadLine());
            int aktuellesJahr = DateTime.Now.Year;
            int alter = aktuellesJahr - geburtsjahr;
            bool istVolljährig = alter > 17;
            bool istRentner = alter > 67;
            if (istVolljährig && !istRentner)
            {
                Console.WriteLine("Geil volljährig");
            }
            else if(istRentner)
            {
                Console.WriteLine("Gönn dir");
            }
            else
            {
                Console.WriteLine("Sorry illegal");
            }
        }
    }
}
