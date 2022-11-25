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

namespace Rezervacija_stola_u_restoranu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //button to confirm the reservation
        private void btnrezervisi_Click(object sender, EventArgs e)
        {
            if (tbimeprezime.Text == "" || tbvreme.Text=="" )
            {
                MessageBox.Show("Morate popuniti sva polja", "Rezervacija nije uspela", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbimeprezime.Focus();
            }
            else if (tbimeprezime.Text != "" && tbvreme.Text!="" && rb1.Checked || rb2.Checked || rb3.Checked || rb4.Checked || rb5.Checked || rb6.Checked || rb7.Checked || rb8.Checked || rb9.Checked)
            {
                /*If the name and time were entered and one radio button is checked,
                  the reservation is successful.
                  The reservation is entered in the database*/

                MessageBox.Show($"Uspešno ste obavili rezervaciju za datum {dateTimePicker2.Value} u {tbvreme.Text}.   Datum i vreme rezervacije: {DateTime.Now}", "Rezervacija uspela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                string imeprezime = tbimeprezime.Text;
                string vreme = tbvreme.Text;
                
                string ConnectionString = "Data Source=NIKOLA\\SQLEXPRESS;Initial Catalog=RezervacijaStola;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                
                con.Open();
                
                string Querry = "INSERT INTO Rezervacijeeee(ImePrezime, DatumVremeRezervacije, ZaKadRezervisano, Vreme) VALUES('" + imeprezime + "', '" + DateTime.Now + "', '" + dateTimePicker2.Text + "', '" + vreme + "')";
                SqlCommand cmd = new SqlCommand(Querry, con);
                cmd.ExecuteNonQuery();
                
                con.Close();

                tbimeprezime.Clear();
                tbvreme.Clear();
                dateTimePicker2.ResetText();
                
            }

        }

        //button "Cancel"
        private void btnponisti_Click(object sender, EventArgs e)
        {
            tbimeprezime.Clear();
            tbvreme.Clear();
            dateTimePicker2.ResetText();
        }

        // a button that leads to a new form for canceling the reservation
        private void btnodjavi_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            
        }

        // a button that leads to a new form for viewing all reservation
        private void btnpogledajrez_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Refresh();
        }
    }
}
