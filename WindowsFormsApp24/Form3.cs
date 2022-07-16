using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp24
{
    public partial class Form3 : Form
    {
        SqlConnection kon = new SqlConnection(Konekcija.konekcija);
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            comboBox4.Items.Add("0 - 30000");
            comboBox4.Items.Add("30001 - 60000");
            comboBox4.Items.Add("60001 - 90000");
            comboBox4.Items.Add("preko 90000");

            popuniCombo1();
            popuniCombo2();
            popuniCombo3();

        }
        public void popuniCombo1()
        {
            SqlCommand komanda = new SqlCommand("select Naziv from Proizvodjac", kon);
            SqlDataReader citac = null;
            try
            {
                kon.Open();
                citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    comboBox1.Items.Add(citac[0].ToString()) ;
                    
                }
                if (kon.State == ConnectionState.Open)
                {
                    kon.Close();
                }
            }
            catch (Exception a)
            {
                if (kon.State == ConnectionState.Open)
                {
                    kon.Close();
                }
                MessageBox.Show(a.Message);
            }

        }
        public void popuniCombo2()
        {
            SqlCommand komanda = new SqlCommand("select Naziv from Boja", kon);
            SqlDataReader citac = null;
            try
            {
                kon.Open();
                citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    comboBox2.Items.Add(citac[0].ToString());

                }
                if (kon.State == ConnectionState.Open)
                {
                    kon.Close();
                }
            }
            catch (Exception a)
            {
                if (kon.State == ConnectionState.Open)
                {
                    kon.Close();
                }
                MessageBox.Show(a.Message);
            }
        }
        public void popuniCombo3()
        {
            SqlCommand komanda = new SqlCommand("select Naziv from Gorivo", kon);
            SqlDataReader citac = null;
            try
            {
                kon.Open();
                citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    comboBox3.Items.Add(citac[0].ToString());

                }
                if (kon.State == ConnectionState.Open)
                {
                    kon.Close();
                }
            }
            catch (Exception a)
            {
                if (kon.State == ConnectionState.Open)
                {
                    kon.Close();
                }
                MessageBox.Show(a.Message);
            }
        }

        public DataTable popuni()
        {

            DataTable dt = new DataTable();
            SqlCommand komanda = null;
            if (comboBox4.Text=="preko 90000")
            {
                komanda = new SqlCommand("select Registracija, GodinaProizvodnje from Vozilo join Boja on(Boja.BojaID=Vozilo.BojaID) join Gorivo on(Gorivo.GorivoID=Vozilo.GorivoID) join Model on (Model.ModelID=Vozilo.ModelID) join Proizvodjac on (Proizvodjac.ProizvodjacID=Model.ProizvodjacID) where Proizvodjac.Naziv='" + comboBox1.Text + "' and Boja.Naziv='" + comboBox2.Text + "' and Gorivo.Naziv='" + comboBox3.Text + "' and Vozilo.PredjenoKM>90000 order by Registracija asc, GodinaProizvodnje desc", kon);

            }
            else
            {
                komanda = new SqlCommand("select Registracija, GodinaProizvodnje from Vozilo join Boja on(Boja.BojaID=Vozilo.BojaID) join Gorivo on(Gorivo.GorivoID=Vozilo.GorivoID) join Model on (Model.ModelID=Vozilo.ModelID) join Proizvodjac on (Proizvodjac.ProizvodjacID=Model.ProizvodjacID) where Proizvodjac.Naziv='" + comboBox1.Text + "' and Boja.Naziv='" + comboBox2.Text + "' and Gorivo.Naziv='" + comboBox3.Text + "' and Vozilo.PredjenoKM between " + comboBox4.Text.Split('-')[0] + " and " + comboBox4.Text.Split('-')[1] + " order by Registracija asc, GodinaProizvodnje desc", kon);

            }
            SqlDataReader citac = null;
            try
            {
                kon.Open();
                citac = komanda.ExecuteReader();
                dt.Load(citac);
                if (kon.State == ConnectionState.Open)
                {
                    kon.Close();
                }
            }
            catch (Exception a)
            {
                if (kon.State == ConnectionState.Open)
                {
                    kon.Close();
                }
                MessageBox.Show(a.Message);
            }
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = popuni();
        }
    }
}


