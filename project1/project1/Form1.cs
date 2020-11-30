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
    public partial class frmOverzicht : Form
    {
        public frmOverzicht()
        {
            InitializeComponent();
        }
        String[] naam;
        double[] prijseklbtw;
        int[] aantal;
        double[] subtotaal;
        int bovengrens;
        double totaal;

        frmIngeven frmIngeven = new frmIngeven();
        Form2 frmafrekenen = new Form2();
        private void VerkoopsgegevensIngevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngeven frmGegevens_instantie = new frmIngeven();
            frmGegevens_instantie.Show();
        }

        private void AuteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("Dit programma is geshcreven doot Sepp Degroote");
        }

        private void eindeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmOverzicht_Activated(object sender, EventArgs e)
        {
            bovengrens = frmIngeven.i + 1;
            naam = frmIngeven.naam;
            prijseklbtw = frmIngeven.prijseklbtw;
            aantal = frmIngeven.aantal;
            subtotaal = frmIngeven.subtotaal;
            if (bovengrens == -1)
            {
                BtnAfrekenen.Enabled = false;
                btnVerwijderen.Enabled = false;
            }
            else
            {
                BtnAfrekenen.Enabled = true;
                btnVerwijderen.Enabled = true;

                for (int i = 0; i < bovengrens; i++)
                {
                    lstNaamProduct.Items.Add(naam[i]);
                    lstPrijsBtw.Items.Add(prijseklbtw[i]);
                    lstAantal.Items.Add(aantal[i]);
                    lstSubtotaal.Items.Add(subtotaal[i]);
                }
            }

        }

        private void BtnAfrekenen_Click(object sender, EventArgs e)
        {
            totaal = 0;
            for (int i = 0; i < subtotaal.Length; i++)
            {
                totaal = totaal + subtotaal[i];
            }
            lblTotaal.Text = Convert.ToString(totaal);
        }
        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            int j = lstNaamProduct.SelectedIndex;
            for (int x = 0; x < lstNaamProduct.Items.Count; x++)
            {
                if (lstNaamProduct.GetSelected(x) == true)
                {
                    lstNaamProduct.Items.Remove(lstNaamProduct.SelectedItem);
                    lstPrijsBtw.Items.Remove(lstPrijsBtw.SelectedItem);
                    lstAantal.Items.Remove(lstAantal.SelectedItem);
                    lstSubtotaal.Items.Remove(lstSubtotaal.SelectedItem);
                    naam[j - 1] = naam[x];
                    naam[x] = "";
                    prijseklbtw[x] = 0;
                    aantal[x] = 0;
                    subtotaal[x] = 0;

                }
            }
        }

        private void afrekenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totaal = 0;
            for (int i = 0; i < subtotaal.Length; i++)
            {
                totaal = totaal + subtotaal[i];
            }
            lblTotaal.Text = Convert.ToString(totaal);
        }

        private void lstNaamProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstNaamProduct_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < lstNaamProduct.Items.Count; x++)
            {
                if (lstNaamProduct.GetSelected(x) == true)
                {
                    lstNaamProduct.SetSelected(x, true);
                    lstPrijsBtw.SetSelected(x, true);
                    lstAantal.SetSelected(x, true);
                    lstSubtotaal.SetSelected(x, true);
                }
            }
        }

        private void lstPrijsBtw_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < lstNaamProduct.Items.Count; x++)
            {
                if (lstPrijsBtw.GetSelected(x) == true)
                {
                    lstNaamProduct.SetSelected(x, true);
                    lstPrijsBtw.SetSelected(x, true);
                    lstAantal.SetSelected(x, true);
                    lstSubtotaal.SetSelected(x, true);
                }
            }
        }

        private void lstAantal_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < lstNaamProduct.Items.Count; x++)
            {
                if (lstAantal.GetSelected(x) == true)
                {
                    lstNaamProduct.SetSelected(x, true);
                    lstPrijsBtw.SetSelected(x, true);
                    lstAantal.SetSelected(x, true);
                    lstSubtotaal.SetSelected(x, true);
                }
            }
        }

        private void lstSubtotaal_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < lstNaamProduct.Items.Count; x++)
            {
                if (lstAantal.GetSelected(x) == true)
                {
                    lstNaamProduct.SetSelected(x, true);
                    lstPrijsBtw.SetSelected(x, true);
                    lstAantal.SetSelected(x, true);
                    lstSubtotaal.SetSelected(x, true);
                }
            }
        }
    }
}
