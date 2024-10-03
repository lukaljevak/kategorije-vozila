using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kategorije_vozila
{
    public partial class Form1 : Form
    {
        List<Vozilo> voziloList = new List<Vozilo>();
        private int brojMotocikala = 0;
        private int brojAutomobila = 0;
        private int brojKamiona = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            txtModel.Clear();
            txtBrojkotaca.Clear();
            txtGodinaproizvodnje.Clear();
            txtModel.Focus();
            try
            {
                Vozilo novoVozilo = new Vozilo(txtModel.Text, int.Parse(txtGodinaproizvodnje.Text), int.Parse(txtBrojkotaca.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void ModelVozila(Vozilo vozilo)
        {
            if (vozilo.Broj_kotača == 2 && vozilo.Broj_kotača % 2 == 0)
            {
                vozilo.Model = "Motocikl";
                brojMotocikala++;
            }
            else if (vozilo.Broj_kotača == 4 && vozilo.Broj_kotača % 2 == 0)
            {
                vozilo.Model = "Automobil";
                brojAutomobila++;
            }
            else if (vozilo.Broj_kotača > 4 && vozilo.Broj_kotača % 2 == 0)
            {
                vozilo.Model = "Kamion";
                brojKamiona++;
            }
            else
            {
                throw new Exception("Neispravan broj kotača.");
            }

            txtIspis.AppendText("Kategorija: " + vozilo.Model + Environment.NewLine);

        }
        string putanjaDoDatoteke = "C:\\Users\\Ucenik\\Documents\\kategorijaVozila\\vozilo.csv";
        private void btnIspis_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(putanjaDoDatoteke))
                {
                    sw.WriteLine("Model,Godina proizvodnje, Broj kotača");
                    foreach(Vozilo vozilo in voziloList)
                    {
                        sw.WriteLine(vozilo.ToString());
                    }
                }
                MessageBox.Show("Podatci su uspješno spremljeni u CSV datoteku!", "Uspjeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Došlo je do pogreške prilikom spremanja podataka: " + ex.Message,
                    "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
    }
}