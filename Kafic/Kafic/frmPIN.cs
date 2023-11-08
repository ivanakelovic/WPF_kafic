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
    public partial class frmPIN : Form
    {
        public frmPIN()
        {
            InitializeComponent();

            //Postavljanje KeyPreview atributa na true na formi se omogućava detekcija događaje KeyPress i KeyDown
            this.KeyPreview = true;
            //Prilikom startovanja aplikacije button-i Clear i Enter su Disable (onemogućeni)
            btnClear.Enabled = false;
            btnEnter.Enabled = false;
            //Prilikom startovanja aplikacije u statusnoj liniji ispisuje se trenutni datum i vrijeme
            lblDatum.Text = DateTime.Now.ToString("dddd, dd.MMMM.yyyy HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Na svaki otkucaj Timer-a ažurira se prikaz datuma i vremena u statusnoj liniji
            lblDatum.Text = DateTime.Now.ToString("dddd, dd.MMMM.yyyy HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Provjerava se da li u polju za unos PIN-a već ima 8 znakova. Moguće unijeti samo 8 znakova (uslov zadatka).
            if (txtPIN.Text.Length < 8)
            {
                //sender je objekat koji je pozvao ovaj događaj. Od njega se pravi Button
                Button pritisnutiBroj = (Button)sender;
                //U polje za unos PIN koda se dodaje (+= nadovezuje se na postojeći sadržaj) Text sa button-a koji je pritisnut.
                txtPIN.Text += pritisnutiBroj.Text;
            }
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            //Tek kada u polju za unos PIN koda ima nešto uneseno taster Clear će biti omogućen (Enable)
            if (txtPIN.Text.Length > 0)
                btnClear.Enabled = true;
            else
                btnClear.Enabled = false;

            //Tek kada u polju za unos PIN koda ima 4 ili više znakova btnEnter je omogućen (Enable)
            if (txtPIN.Text.Length >= 4)
                btnEnter.Enabled = true;
            else
                btnEnter.Enabled = false;
        }

        //Pritiskom na taster Clear briše se sadržaj polja txtPIN
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPIN.Clear();//Može se pozvati funkcija Clear
            //txtPIN.Text = "";//Ili se može postaviti vrijednost na prazan string (isto je značenje)
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Prvo se ispituje koji taster je pritisnut, i ako je neki od brojeva 0-9 prolazi se kroz sve kontrole
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                //Prolazi se kroz sve kontrole koje se nalaze u tableLayoutPanel-u
                foreach (Control kontrola in tableLayoutPanel1.Controls)
                {
                    //Ako je kontrola na koju se naiđe pri prolazu kroz petlju tipa button (traži se button)
                    if (kontrola is Button)
                    {
                        Button btnBroj = (Button)kontrola;//Od te kontrole se kreira novi button
                        //Kada se pronađe button koji ima Text atribut isti kao i pritisnuti karakter "pritisnee se taj taster" (Pozove se funkcija PerformClick
                        if (btnBroj.Text == e.KeyChar.ToString())
                            btnBroj.PerformClick();//Simunlira se pritisak na pronađeni taster
                    }
                }
            }
            //Ovim se aplikaciji govori da je događaj KeyPress već hendlovan (obrađen)
            //Ukoliko se ne postavi na true i txtPIN kontrola će da obradi ovaj događaj pa će se upisati 2 broja u textbox
            e.Handled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Ako je pritisnut Enter (KeyCode svakog pritisnutog tastera se nalazi u varijabli Keys) 
            if (e.KeyCode == Keys.Enter)
                btnEnter.PerformClick();//Ako je pritisnut Enter poziva se funkcija PerformClick nad tasterom btnEnter
            else if (e.KeyCode == Keys.Delete)
                btnClear.PerformClick();//Ako je pritisnut Clear poziva se funkcija PerformClick nad tasterom btnClear
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPIN.Text == "1234")
            {
                //Prvo se sakrije OVA forma (forma za unos PIN koda)
                this.Hide();
                //Očisti se sadržaj polja za unos PIN koda da bi kada se zatvori forma račun ponovo bilo spremno za unos
                txtPIN.Clear();
                //Prvo se napravi novi objekat tipa frmRacun (poziva se konstruktor nove forme)
                //Konstruktoru se prosleđuju 2 parametra. Prvi tipa string, drugi tipa Image
                //Slike se prvo importuju u Resources, pa se odatle mogu učitati bilo gdje u aplikaciji
                frmRacun formaRacun = new frmRacun("Petar Petrović", Properties.Resources.konobar);
                formaRacun.ShowDialog();
                //Kada se zatvori nova forma ponovo se prikazuje forma za logovanje
                this.Show();
            }
            else if (txtPIN.Text == "4321")
            {
                this.Hide();
                txtPIN.Clear();
                frmRacun formaRacun = new frmRacun("Ivana Ivanović", Properties.Resources.konobarica);
                formaRacun.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Neipravan PIN!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
