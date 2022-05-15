using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_04.B_01 // Zadanie 1 z pliku 04_zadaniaB
{
    class Liczby
    {
        public void Opis_programu()
        {
            Console.WriteLine("Program oblicza średnią z podanych liczb,");
            Console.WriteLine("a następnie wyświetla wynik na ekranie.");
            Console.WriteLine();

            Console.WriteLine("===========================================");
            Console.WriteLine("Naciśnij dowolny klawisz aby przejść dalej.");
            Console.ReadKey(true);

        }

        static void Main(string[] args)
        {
            int i, rozmiar;
            double suma = 0, srednia;
            
            Liczby liczby = new Liczby();

            liczby.Opis_programu();
            Console.WriteLine();

            Console.Write("Podaj ile liczb chcesz wprowadzić do obliczeń: ");
            while (!(int.TryParse(Console.ReadLine(), out rozmiar)) || rozmiar < 2)
            {
                Console.WriteLine("Błędna wartość.");
                Console.Write("Podaj długość ciągu liczb: ");
            }
            Console.WriteLine();

            double[] tablica = new double[rozmiar];
            
            for (i = 0; i < rozmiar; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                tablica[i] = double.Parse(Console.ReadLine());
                suma += tablica[i];
            }
            Console.WriteLine();

            Console.Write("Średnia z liczb: ");
            for (i = 0; i < tablica.Length; i++)
            {
                if (i < tablica.Length - 1)
                {
                    Console.Write(tablica[i] + ", ");
                }
                else
                {
                    Console.Write(tablica[i] + " ");
                }
            }

            srednia = suma / rozmiar;

            Console.WriteLine($" wynosi: {srednia:##.##}");
            
            Console.WriteLine();

            Console.WriteLine("Naciśnij dowolny klawisz...");
            Console.WriteLine("===========================");
            Console.ReadKey();
        }
    }
}
