using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Szyfr
    {
        public static string szyfrujPrzestawieniowo(string slowo)
        {
            string zaszyfrowaneSlowo = "";
            for(int i = 0; i < slowo.Length-1; i=i+ 2)
            {
                zaszyfrowaneSlowo = zaszyfrowaneSlowo + slowo[i + 1] + slowo[i];
                
            }
            if (slowo.Length % 2 == 1)
            {
                zaszyfrowaneSlowo = zaszyfrowaneSlowo + slowo[slowo.Length - 1];
            }
            return zaszyfrowaneSlowo;
        }
        public static string szyfrujGaderypoluki(string slowoDoSzyfrowania, string klucz)
        {
            string zaszyfrowane = "";
            for (int i = 0; i < slowoDoSzyfrowania.Length; i++)
            {
                char literka = slowoDoSzyfrowania[i];
                int indeksWkluczu=klucz.IndexOf(literka);
                if (indeksWkluczu == -1)
                {
                    zaszyfrowane += literka;
                }else if (indeksWkluczu % 2 == 0)
                {
                    zaszyfrowane += klucz[indeksWkluczu + 1];
                }
                else
                {
                    zaszyfrowane += klucz[indeksWkluczu - 1];
                }
            }
            return zaszyfrowane;
        }
    }
}
