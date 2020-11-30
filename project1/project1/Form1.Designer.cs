namespace project1
{
    partial class frmOverzicht
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verkoopsgegevensIngevenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afrekenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eindeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNaamProduct = new System.Windows.Forms.ListBox();
            this.lblProductNaam = new System.Windows.Forms.Label();
            this.lstPrijsBtw = new System.Windows.Forms.ListBox();
            this.lstAantal = new System.Windows.Forms.ListBox();
            this.blbInc = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.BtnAfrekenen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lstSubtotaal = new System.Windows.Forms.ListBox();
            this.lblTitIstotaal = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verkoopsgegevensIngevenToolStripMenuItem,
            this.afrekenenToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verkoopsgegevensIngevenToolStripMenuItem
            // 
            this.verkoopsgegevensIngevenToolStripMenuItem.Name = "verkoopsgegevensIngevenToolStripMenuItem";
            this.verkoopsgegevensIngevenToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.verkoopsgegevensIngevenToolStripMenuItem.Text = "Verkoopsgegevens ingeven";
            this.verkoopsgegevensIngevenToolStripMenuItem.Click += new System.EventHandler(this.VerkoopsgegevensIngevenToolStripMenuItem_Click);
            // 
            // afrekenenToolStripMenuItem
            // 
            this.afrekenenToolStripMenuItem.Name = "afrekenenToolStripMenuItem";
            this.afrekenenToolStripMenuItem.Size = new System.Drawing.Size(90, 34);
            this.afrekenenToolStripMenuItem.Text = "Afrekenen";
            this.afrekenenToolStripMenuItem.Click += new System.EventHandler(this.afrekenenToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auteurToolStripMenuItem,
            this.eindeToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 34);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // auteurToolStripMenuItem
            // 
            this.auteurToolStripMenuItem.Name = "auteurToolStripMenuItem";
            this.auteurToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.auteurToolStripMenuItem.Text = "Auteur";
            this.auteurToolStripMenuItem.Click += new System.EventHandler(this.AuteurToolStripMenuItem_Click);
            // 
            // eindeToolStripMenuItem
            // 
            this.eindeToolStripMenuItem.Name = "eindeToolStripMenuItem";
            this.eindeToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.eindeToolStripMenuItem.Text = "Einde";
            this.eindeToolStripMenuItem.Click += new System.EventHandler(this.eindeToolStripMenuItem_Click);
            // 
            // lstNaamProduct
            // 
            this.lstNaamProduct.FormattingEnabled = true;
            this.lstNaamProduct.ItemHeight = 16;
            this.lstNaamProduct.Location = new System.Drawing.Point(13, 61);
            this.lstNaamProduct.Margin = new System.Windows.Forms.Padding(4);
            this.lstNaamProduct.Name = "lstNaamProduct";
            this.lstNaamProduct.Size = new System.Drawing.Size(177, 180);
            this.lstNaamProduct.TabIndex = 1;
            this.lstNaamProduct.Click += new System.EventHandler(this.lstNaamProduct_Click);
            this.lstNaamProduct.SelectedIndexChanged += new System.EventHandler(this.lstNaamProduct_SelectedIndexChanged);
            // 
            // lblProductNaam
            // 
            this.lblProductNaam.AutoSize = true;
            this.lblProductNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNaam.Location = new System.Drawing.Point(13, 38);
            this.lblProductNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductNaam.Name = "lblProductNaam";
            this.lblProductNaam.Size = new System.Drawing.Size(145, 18);
            this.lblProductNaam.TabIndex = 2;
            this.lblProductNaam.Text = "Naam van product";
            // 
            // lstPrijsBtw
            // 
            this.lstPrijsBtw.FormattingEnabled = true;
            this.lstPrijsBtw.ItemHeight = 16;
            this.lstPrijsBtw.Location = new System.Drawing.Point(198, 61);
            this.lstPrijsBtw.Margin = new System.Windows.Forms.Padding(4);
            this.lstPrijsBtw.Name = "lstPrijsBtw";
            this.lstPrijsBtw.Size = new System.Drawing.Size(177, 180);
            this.lstPrijsBtw.TabIndex = 3;
            this.lstPrijsBtw.Click += new System.EventHandler(this.lstPrijsBtw_Click);
            // 
            // lstAantal
            // 
            this.lstAantal.FormattingEnabled = true;
            this.lstAantal.ItemHeight = 16;
            this.lstAantal.Location = new System.Drawing.Point(386, 61);
            this.lstAantal.Margin = new System.Windows.Forms.Padding(4);
            this.lstAantal.Name = "lstAantal";
            this.lstAantal.Size = new System.Drawing.Size(177, 180);
            this.lstAantal.TabIndex = 4;
            this.lstAantal.Click += new System.EventHandler(this.lstAantal_Click);
            // 
            // blbInc
            // 
            this.blbInc.AutoSize = true;
            this.blbInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbInc.Location = new System.Drawing.Point(196, 38);
            this.blbInc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blbInc.Name = "blbInc";
            this.blbInc.Size = new System.Drawing.Size(151, 18);
            this.blbInc.TabIndex = 5;
            this.blbInc.Text = "Prijs inclusief BTW";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantal.Location = new System.Drawing.Point(382, 38);
            this.lblAantal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(54, 18);
            this.lblAantal.TabIndex = 6;
            this.lblAantal.Text = "Aantal";
            // 
            // BtnAfrekenen
            // 
            this.BtnAfrekenen.Location = new System.Drawing.Point(13, 249);
            this.BtnAfrekenen.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAfrekenen.Name = "BtnAfrekenen";
            this.BtnAfrekenen.Size = new System.Drawing.Size(179, 52);
            this.BtnAfrekenen.TabIndex = 9;
            this.BtnAfrekenen.Text = "Afrekenen";
            this.BtnAfrekenen.UseVisualStyleBackColor = true;
            this.BtnAfrekenen.Click += new System.EventHandler(this.BtnAfrekenen_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(200, 249);
            this.btnVerwijderen.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(179, 52);
            this.btnVerwijderen.TabIndex = 10;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // lstSubtotaal
            // 
            this.lstSubtotaal.FormattingEnabled = true;
            this.lstSubtotaal.ItemHeight = 16;
            this.lstSubtotaal.Location = new System.Drawing.Point(616, 61);
            this.lstSubtotaal.Margin = new System.Windows.Forms.Padding(4);
            this.lstSubtotaal.Name = "lstSubtotaal";
            this.lstSubtotaal.Size = new System.Drawing.Size(177, 180);
            this.lstSubtotaal.TabIndex = 12;
            this.lstSubtotaal.Click += new System.EventHandler(this.lstSubtotaal_Click);
            // 
            // lblTitIstotaal
            // 
            this.lblTitIstotaal.AutoSize = true;
            this.lblTitIstotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitIstotaal.Location = new System.Drawing.Point(613, 249);
            this.lblTitIstotaal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitIstotaal.Name = "lblTitIstotaal";
            this.lblTitIstotaal.Size = new System.Drawing.Size(97, 18);
            this.lblTitIstotaal.TabIndex = 13;
            this.lblTitIstotaal.Text = "Totale prijs:";
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaal.Location = new System.Drawing.Point(622, 283);
            this.lblTotaal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(0, 18);
            this.lblTotaal.TabIndex = 14;
            // 
            // frmOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 326);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lblTitIstotaal);
            this.Controls.Add(this.lstSubtotaal);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.BtnAfrekenen);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.blbInc);
            this.Controls.Add(this.lstAantal);
            this.Controls.Add(this.lstPrijsBtw);
            this.Controls.Add(this.lblProductNaam);
            this.Controls.Add(this.lstNaamProduct);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOverzicht";
            this.Text = "Overzicht";
            this.Activated += new System.EventHandler(this.frmOverzicht_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verkoopsgegevensIngevenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afrekenenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eindeToolStripMenuItem;
        private System.Windows.Forms.ListBox lstNaamProduct;
        private System.Windows.Forms.Label lblProductNaam;
        private System.Windows.Forms.ListBox lstPrijsBtw;
        private System.Windows.Forms.ListBox lstAantal;
        private System.Windows.Forms.Label blbInc;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Button BtnAfrekenen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.ListBox lstSubtotaal;
        private System.Windows.Forms.Label lblTitIstotaal;
        private System.Windows.Forms.Label lblTotaal;
    }
}

