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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //button that returns to the main menu
        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        // button that deletes the reservation from the database
        private void button1_Click(object sender, EventArgs e)
        {
            string odjava = textBox1.Text;
            string vremeodjave = tbvremeodjave.Text;
            
            string ConnectionString = "Data Source=NIKOLA\\SQLEXPRESS;Initial Catalog=RezervacijaStola;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
           
            con.Open();
            
            string Querry = " DELETE FROM Rezervacijeeee WHERE ImePrezime='"+odjava+"' AND Vreme='"+vremeodjave+"'";
            
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            
            con.Close();

            // MessageBox confirming that it was succesfully deleted
            MessageBox.Show($"Uspešno ste otkazali rezervaciju na ime:  {odjava} koja je bila zakazana za {vremeodjave}", "Rezervacija otkazana", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            tbvremeodjave.Clear();
        }
    }
}
