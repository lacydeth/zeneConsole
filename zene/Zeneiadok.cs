using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace zene
{
    public class Zeneiadok
    {
        byte sorszam;
        List<Zenek> zeneLista;

        public Zeneiadok(byte sorszam)
        {
            this.sorszam = sorszam;
            this.zeneLista = new List<Zenek>();
        }

        internal List<Zenek> ZeneLista { get => zeneLista; set => zeneLista = value; }

        public string ElteltIdo(string eloado)
        {
            int elsoIndex = zeneLista.FindIndex(x => x.Eloado == eloado && sorszam == 1);
            int utolsoIndex = zeneLista.FindLastIndex(x => x.Eloado == eloado && sorszam == 1);

            int osszegzettHossz = 0;
            for (int i = elsoIndex; i <= utolsoIndex; i++)
            {
                osszegzettHossz += zeneLista[i].Hossz;
            }

            TimeSpan eltelt_ido = TimeSpan.FromSeconds(osszegzettHossz);
            return string.Format("{0}:{1:D2}:{2:D2}", eltelt_ido.Hours, eltelt_ido.Minutes, eltelt_ido.Seconds);
        }
        public int MikorKezdodott(string eloado, string szamcime)
        {
            var hanyadik = zeneLista.FindIndex(x => x.Eloado == eloado && x.Cim == szamcime);
            int kezdes = 0;
            for (int i = 0; i < hanyadik; i++)
            {
                kezdes += zeneLista[i].Hossz;
            }
            return kezdes;
        }
        public string MiMentEkkor(int mikorMp)
        {

        }
    }
}
