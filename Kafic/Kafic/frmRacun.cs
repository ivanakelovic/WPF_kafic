using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kafic
{
    public partial class frmRacun : Form
    {
        //Konstruktor nove forme je promjenjen, dodato mu je da prihvata dva ulazna parametra.
        //Prvi ulazni parametar je string (Ime i prezime prijavljenog konobar-a/ice), drugi je slika konobar-a/ice
        public frmRacun(string konobarIme, Image konobarSlika)
        {
            InitializeComponent();

            //U labeli se ispisuje ime i prezime konobara dostavljeno preko konstruktora
            lblKonobarIme.Text = konobarIme;
            //U PictureBox-u se postavlja slika dobijena preko konstruktora
            pictureBox1.Image = konobarSlika;
            //Postavlja se naslov forme u kome stoji ime i prezime prijavljenog konobara
            this.Text = "Račun - " + konobarIme;

            //Kreira se niz artikala
            Artikal[] stavke = { new Artikal("Kafa", 1.5f), new Artikal("Sok", 2f), new Artikal("Kisela", 1f), new Artikal("Pivo", 2.5f) };

            //Prolazi se kroz svaku stavku iz niza
            foreach (Artikal artikal in stavke)
                lsbPonuda.Items.Add(artikal);//svaka stavka se dodaje na listbox pomoću funkcije Add
        }

        //Dodavanje stavke na listu klikom na taster Dodaj (>>)
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //Ispituje se da li je selektovana i jedna stavka na listi
            if (lsbPonuda.SelectedIndex >= 0)
                lsbRacun.Items.Add(lsbPonuda.SelectedItem);//Na listu Račun dodaje se seletovani artikal sa liste Ponuda
            else //Ako nije označeno ništa obavještava se korisnik
                MessageBox.Show("Nije označeno ništa iz ponude", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Uklanjanje stavke sa liste klikom na taster Ukloni
        private void btnUkloni_Click(object sender, EventArgs e)
        {
            //Ispituje se da li je selektovana i jedna stavka na listi
            if (lsbRacun.SelectedIndex >= 0)
                lsbRacun.Items.Remove(lsbRacun.SelectedItem);//Sa liste Račun uklanja se seletovani artikal na listi Račun
            else //Ako nije označeno ništa obavještava se korisnik
                MessageBox.Show("Nije označeno ništa na računu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            //Realaizacija izuzetka, da ne dođe do pucanja aplikacije prilikom poziva ove funkcije
            try
            {
                Test();
            }
            catch 
            {
                MessageBox.Show("Funkcija test nije realizovana!", "Greška");
            }

            //string promjenljiva koja će se štampati u MessageBox-u (stavke računa sa headerom i footerom
            string racun = "Račun:\n";
            //Promjenljiva ukupno u kojoj će se čuvati zbir svih cijena sa računa
            float ukupno = 0;
            racun += "------------------------------------\n";
            //Prolazi se kroz sve artikle u listbox-u lstRacun
            foreach (Artikal stavkaSaRacuna in lsbRacun.Items)
            {
                racun += stavkaSaRacuna.ToString() + "\n"; //Dodaje se svaki artikl i novi red na kraju
                ukupno += stavkaSaRacuna.cijenaArtikla; //ažurira se vrijednost promjenljive ukupno i uvećava se za cijenu svakog artikla na računu
            }
            //Kada se prođe kroz sve artikle dodaje se linija i ukupno stringu koji se štampa
            racun += "------------------------------------\n";
            racun += "Ukupno:\t\t" + ukupno.ToString("F2") + " KM";
            //Prikazuje se poruka sa podacima sa računa koji su prilagođeni gore iznad
            MessageBox.Show(racun, "Račun");
            //Nakon izdavanja računa zatvara se forma za izdavanje računa
            this.Close();
        }

        //Funkcija zadata u zadatku
        void Test() { throw new NotImplementedException(); }
    }
}
