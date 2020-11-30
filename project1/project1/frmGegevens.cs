using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace project1
{
    public partial class frmIngeven : Form
    {
        public frmIngeven()
        {
            InitializeComponent();
        }
        public static String[] naam = new String[100];
        public static double[] prijseklbtw = new double[100];
        public static int[] aantal = new int[100];
        public static double[] subtotaal = new double[100];
        public static int i = -1;
        private void naarOverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            //tellerke
            i++;
            //Foutcontrole op naam en in de array steken
            string name;
            if (txtNaam.Text=="")
            {
                Interaction.MsgBox("De naam moet ingevuld zijn!!");
            }
            else 
            {
                naam[i]= txtNaam.Text;
            }
            //Foutcontrole op prijs en in de array steken
            double prijs;
            if (txtPrijs.Text == "")
            {
                Interaction.MsgBox("De prijs moet ingevuld zijn!!");
            }
            else if (!double.TryParse(txtPrijs.Text, out prijs)) 
            {
                Interaction.MsgBox("De prijs moet een getal zijn!!");
            }
            else
            {
                prijseklbtw[i] = prijs;
            }
            //Foutcontrole op aantal en in de array steken
            int hoeveel;
            if (txtAantal.Text == "")
            {
                Interaction.MsgBox("Het aantal moet ingevuld zijn!");
            }
            else if (!int.TryParse(txtAantal.Text, out hoeveel))
            {
                Interaction.MsgBox("Het aantal moet een getal zijn!");
            }
            else
            {
                aantal[i] = hoeveel;
            }
            //Foutcontrole op de radio buttons
            if (rdbbtw6.Checked == false && rdbbtn12.Checked == false && rdbbtw21.Checked == false)
            {
                Interaction.MsgBox("De BTW moet geselecteerd worden!");
            }
            //Aan de hand van de radio buttons al prijs incl BTW berekenen en in array steken
            if (rdbbtw6.Checked == true)
            {
                prijseklbtw[i] = prijseklbtw[i] * 0.06 + prijseklbtw[i];
            }
            else if (rdbbtn12.Checked == true)
            {
                prijseklbtw[i] = prijseklbtw[i] * 0.12 + prijseklbtw[i];
            }
            else if (rdbbtw21.Checked == true)
            {
                prijseklbtw[i] = prijseklbtw[i] * 0.21 + prijseklbtw[i];
            }
            //All
            subtotaal[i] = prijseklbtw[i] * aantal[i];
            //Alles leeg maken en klaar zetten voor volgend product
            txtNaam.Clear();
            txtPrijs.Clear();
            txtAantal.Clear();
            txtNaam.Focus();
        }
    }
}
