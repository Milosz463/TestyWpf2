using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Obliczenia
    {
        public static int sumaCyfr(int liczba)
        {
            return liczba + liczba;
        }
        public static int liczbaBlizniacza(int liczba)
        {

            return liczba;
            //liczba jest blizniacza jezeli jest liczba pierwsza i istnieje liczba pierwsza o 2 wieksza 
            //11,13
            //17->19
            //jezeli nie bedzie liczby blizniaczej zwraca -1
        }
        public static int potega(int podstawa,int wykladnik)
        {
            int wynik=0;
            for (int i = 0; i < wykladnik; i++)
            {
                wynik =podstawa*podstawa;
            }
            return podstawa;
           
        }
        public static int zamienZSystemu(string liczbaWSystemie, int system)
        {
            return system;  
        }
    }
}
