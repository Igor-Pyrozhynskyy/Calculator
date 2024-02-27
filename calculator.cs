using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektNr1_Ihor_Pyrozhynskyy_70146

{
    internal class Program
    {
        static void Main(string[] args)
        {//deklaracaja zmiennej dla przechowania kodu wciśniętego klawisza przez Użytkownika programu
            ConsoleKeyInfo WybranaFunkcjonalność;
            //Tytyl i MENU Projektu Nr 1
            do //powtarzaj aż do naciśnięcia klawisza 'X'
            {
                // zresetowanie (wyczyszczenie) okno konsoli
                Console.Clear();
                //Wpisanie tytułu i przeznaczenie programu
                Console.WriteLine("\n\n\n\t\t\t\tProjekt_Nr1_Ihor_Pyrozhynskyy_70146\n\n\n");
                //Wypisanie MENU
                Console.WriteLine("\n\t\tMenu funkcjonalnr programu: \n");
                Console.WriteLine("\t\tA. Kalkulator laboratoryjny");
                Console.WriteLine("\t\tB.  Kalkulator indywidualny");
                Console.WriteLine("\t\tX.Zakończenie (Wyjście z ) programu ");
                //podpowidz dla użytkownika
                Console.Write("\n\n\t\tNaciśnięciem odpowidniego klawisza (A lub B lub X) wybierz   \n\t\t jendą z funcjonalności: ");
                //wszytanie"wyboru" Użytkownika
                WybranaFunkcjonalność = Console.ReadKey();
                //rozpoznanie wybranej funcjonalności z zastosowaniem instrukcji 'if-else'
                if (WybranaFunkcjonalność.Key == ConsoleKey.A)
                    // wywolanie kalkulatora laborytoryjnego
                    KalkulatorLaboratoryjny();
                else
                    if (WybranaFunkcjonalność.Key == ConsoleKey.B)
                    KalkulatorIndywidualny();
                else
                    if (WybranaFunkcjonalność.Key == ConsoleKey.X)
                {
                    //jest bląd, to go sygnalizujemy
                    Console.WriteLine("\n\n\t\tERROR: nacieśnełeś niedozwolony klawisz (znak)!!!!");
                }
                //chwilowe zarzymanie  wykonania programu
                Console.Write("\n\t\tDlakontynuacji dalszego dzialania programu naciśnij dowolny klawisz: ");
                Console.ReadKey();
                // "zamknięcie"instrucji 'do'
            }
            while (WybranaFunkcjonalność.Key != ConsoleKey.X);
            // będzimy tutaj , gdy Użytkownik wieberze funcjonalność 'X' (naciśnąl klawisz 'X')
            Console.WriteLine("\n\n\t\tAutor ptojektu Nr 1 :Ihor_Pyrozhynskyy_70146");
            //data urochomienia i testowania programu
            Console.WriteLine("\n\t\tDzisiejsza data : (0}", DateTime.Now);
            // chwilowe zatrzymanie wykonywania programu
            Console.Write("\n\t\tDlakontynuacji dalszego dzialania programu naciśnij dowolny klawisz: ");
            Console.ReadKey();
        }
        // deklaracje metod implementacji Kalkulatorów
        static void KalkulatorLaboratoryjny()
        {

            ConsoleKeyInfo WybranaFuncjonalność;
            //powtarzanie obliczeń kalkulatora laboratoryjnego
            do
            {
                //czyszenie konsoli
                Console.Clear();
                Console.WriteLine("\n\t\t MENU kalkulatora laboratoryjnego:");
                Console.WriteLine("\t\tA. Obliczenie sumy wyrazów ciągu liczbowego:");
                Console.WriteLine("\t\tB. Obliczenie iloczynu wyrazów ciągu liczbowego");
                Console.WriteLine("\t\tC. Obliczenie śriedniej arytmetycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\t\tD. Obliczenie pierwiastków równania kwadratowego");
                Console.WriteLine("\t\tE. obliczenie wartości wielomianu n-tego stopnia");
                Console.WriteLine("\t\tF. Konwerscja znakowego zapisu liczby naturalnej na wartość");
                Console.WriteLine("\t\tX. Zakonczenie dzialinia (Wyjście z ) kalkulatora laboratoryjnego");
                // podpowiedz dla użytkownika
                Console.Write("\n\n\t\tNacieśnięciem odpowidniego klawisza (A lub B lub . . . X) wybierz  " + " \n\t\t jedną z funkcjonalnośći:");
                //wczytanie "wyboru" Użytkownika
                WybranaFuncjonalność = Console.ReadKey();
                //rozpoznanie wybranej fucjonalności z zastosowaniem instrukcji 'switch'
                switch (WybranaFuncjonalność.Key)
                {
                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.B:
                        break;
                    case ConsoleKey.C:
                        break;
                    case ConsoleKey.D:
                        break;
                    case ConsoleKey.E:
                        break;
                    case ConsoleKey.F:
                        break;
                    case ConsoleKey.X:
                        break;
                    default:
                        Console.WriteLine("\n\n\t\tERROR: nacieśnełeś niedozwolony klawisz (znak)!!!!");
                        break;
                }
                Console.Write("\n\t\tSprawdż wyniki i dla kontynacji dalszego dzialania programu naciśnij dowolny klawisz:");
                Console.ReadKey();
            }
            while (WybranaFuncjonalność.Key != ConsoleKey.X);
            //chwilowe zatrzymanie wykonywania programu
            Console.Write("\n\t\tWYJŚCIE Z KALKULATORA LABORATORYJNEGO: dla kontynuacji dalszego dzialania programu naciśnij dowolny klawisz: ");
            Console.ReadKey();
        }
        static void KalkulatorIndywidualny()
        {
            Console.WriteLine("\n\t\tPRZEPRASZAMY,ale jestem w trakcie projektowania:nazywam się : KalkulatorIndywidualny");
            //chwilowe zatrymanie wykonania programu
            Console.Write("\n\t\tWYJŚCIE Z KALKULATORA INDYWIDUALNEGO: dla kontynuacji dalszego dzialania programu naciśnij dowolny klawisz:");
            Console.ReadKey();
        }



    }   }
