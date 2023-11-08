using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kafic
{
    class Artikal
    {
        //Potrebno je napraviti dva public atributa za naziv i cijenu, koji se kasnije mogu koristiti u aplikaciji
        public string nazivArtikla { get; set; }
        public float cijenaArtikla { get; set; }

        //U konstruktoru se proslijeđuje naziv i cijena
        public Artikal(string naziv, float cijena)
        {
            //Dobijeni naziv i cijena se dodjeljuju public atributima za svaki objekat
            this.nazivArtikla = naziv;
            this.cijenaArtikla = cijena;
        }

        //Kod poziva funkcije ToString nad objektom Artikl koristiće se izmjenja verzija koja je prilagođena uslovima zadatka (override)
        public override string ToString()
        {
            //"Naziv  cijena KM" [\t - TAB]; ["F2" - float prikazati kao broj sa dvije decimale]
            return nazivArtikla + "\t\t" + cijenaArtikla.ToString("F2") + " KM";
        }
    }
}
