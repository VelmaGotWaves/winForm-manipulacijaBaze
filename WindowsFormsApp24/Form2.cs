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
    public partial class Form2 : Form
    {
        SqlConnection kon = new SqlConnection(Konekcija.konekcija);
        public Form2()
        {
            InitializeComponent();
            listView1.View = View.Details;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komanda = new SqlCommand("insert into Gorivo values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", kon);

            try
            {
                kon.Open();
                komanda.ExecuteNonQuery();
                MessageBox.Show("Uspesno ubacen benzin");
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
            popuniListView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            popuniListView();
        }
        public void popuniListView()
        {

            listView1.Clear();

            SqlCommand komanda = new SqlCommand("select GorivoID, Naziv, Opis from Gorivo order by GorivoID", kon);
            SqlDataReader citac = null;
            try
            {
                kon.Open();
                citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    listView1.Columns.Add("GorivoID", 120);
                    listView1.Columns.Add("Naziv", 120);
                    listView1.Columns.Add("Opis", 120);

                    string[] info = { citac[0].ToString(), citac[1].ToString(), citac[2].ToString() };

                    ListViewItem lv = new ListViewItem(info);

                    listView1.Items.Add(lv);
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komanda = new SqlCommand("delete from Gorivo where GorivoID='" + textBox1.Text + "'", kon);

            try
            {
                kon.Open();
                komanda.ExecuteNonQuery();
                MessageBox.Show("Uspesno si obrisao gorivo");
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
            popuniListView();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            SqlCommand komanda = new SqlCommand("update Gorivo set Naziv ='"+ textBox2.Text+ "', Opis ='" + textBox2.Text + "' where GorivoID='" + textBox1.Text + "'", kon);

            try
            {
                kon.Open();
                komanda.ExecuteNonQuery();
                MessageBox.Show("Uspesno si promenio podatak");
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
            popuniListView();
        }
    }
}
