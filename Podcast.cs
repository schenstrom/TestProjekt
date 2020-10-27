using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Podcast
{
    public class Podcast
    {
        public string URL { get; set; }

        public string Uppdaterinsgfrekvens { get; set; }

        public string Kategori { get; set; }

        public int AntalAvsnitt { get; set; }

        public string Namn { get; set; }
    }

    public Podcast(string _URL, string _kategori, int _uppdateringsFrekvens, int _antalAvsnitt, string _namn)
    {
        URL = _URL;
        Kategori = _kategori;
        Uppdateringsfrekvens = _uppdateringsFrekvens;
        AntalAvsnitt = _antalAvsnitt;
        Namn = _namn;
    }

    public Podcast() 
    { 

    }
}
