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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        //button that returns to the main menu
        private void btn_nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rezervacijaStolaDataSet.Rezervacijeeee' table. You can move, or remove it, as needed.
            this.rezervacijeeeeTableAdapter.Fill(this.rezervacijaStolaDataSet.Rezervacijeeee);

        }

        private void prikazToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rezervacijeeeeTableAdapter.Prikaz(this.rezervacijaStolaDataSet.Rezervacijeeee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rezervacijeeeeTableAdapter.FillBy(this.rezervacijaStolaDataSet.Rezervacijeeee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
