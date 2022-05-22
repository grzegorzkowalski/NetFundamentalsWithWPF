﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamentals
{
    internal class Tasks
    {
        internal void Task2()
        {
            Console.WriteLine("Jak masz na imię?");
            var name = Console.ReadLine();
            Console.WriteLine(name);
        }

        internal void Task3()
        {
            int result = 5 + 9;
            Console.WriteLine(result); 
        }

        //Napisz program, któy oblicza objętość kuli o promieniu `r`. Wartość promienia `r` wprowadzamy z kawiatury.
        //W programie należy przyjąć, że zmienne promień `r` i `objetosc` są typu `double`. 
        //Dla tych zmiennych należy przyjąć formatwyświetlania ich na ekranie z dokładnością do dwóhc miejsc po przecinku.
        internal void Task4()
        {
            double r, objetosc;

            Console.WriteLine("Podaj promień");
            r = double.Parse(Console.ReadLine());

            objetosc = 4.0 * Math.PI * r * r * r / 3;

            Console.WriteLine($"Objętość kuli o r {r} wynosi {Math.Round(objetosc, 2)}");

        }
    }
}
