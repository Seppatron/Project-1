namespace project1
{
    partial class frmIngeven
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
            this.naarOverzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProductNaam = new System.Windows.Forms.Label();
            this.blbexl = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.rdbbtw6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbbtw21 = new System.Windows.Forms.RadioButton();
            this.rdbbtn12 = new System.Windows.Forms.RadioButton();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naarOverzichtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // naarOverzichtToolStripMenuItem
            // 
            this.naarOverzichtToolStripMenuItem.Name = "naarOverzichtToolStripMenuItem";
            this.naarOverzichtToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.naarOverzichtToolStripMenuItem.Text = "Afrekenen";
            this.naarOverzichtToolStripMenuItem.Click += new System.EventHandler(this.naarOverzichtToolStripMenuItem_Click);
            // 
            // lblProductNaam
            // 
            this.lblProductNaam.AutoSize = true;
            this.lblProductNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNaam.Location = new System.Drawing.Point(13, 40);
            this.lblProductNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductNaam.Name = "lblProductNaam";
            this.lblProductNaam.Size = new System.Drawing.Size(145, 18);
            this.lblProductNaam.TabIndex = 3;
            this.lblProductNaam.Text = "Naam van product";
            // 
            // blbexl
            // 
            this.blbexl.AutoSize = true;
            this.blbexl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbexl.Location = new System.Drawing.Point(13, 94);
            this.blbexl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blbexl.Name = "blbexl";
            this.blbexl.Size = new System.Drawing.Size(155, 18);
            this.blbexl.TabIndex = 6;
            this.blbexl.Text = "Prijs exclusief BTW";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantal.Location = new System.Drawing.Point(13, 149);
            this.lblAantal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(54, 18);
            this.lblAantal.TabIndex = 7;
            this.lblAantal.Text = "Aantal";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(16, 61);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(198, 22);
            this.txtNaam.TabIndex = 8;
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(16, 115);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(107, 22);
            this.txtPrijs.TabIndex = 9;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(16, 170);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(107, 22);
            this.txtAantal.TabIndex = 10;
            // 
            // rdbbtw6
            // 
            this.rdbbtw6.AutoSize = true;
            this.rdbbtw6.Location = new System.Drawing.Point(16, 33);
            this.rdbbtw6.Name = "rdbbtw6";
            this.rdbbtw6.Size = new System.Drawing.Size(49, 21);
            this.rdbbtw6.TabIndex = 11;
            this.rdbbtw6.TabStop = true;
            this.rdbbtw6.Text = "6%";
            this.rdbbtw6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbbtw21);
            this.groupBox1.Controls.Add(this.rdbbtw6);
            this.groupBox1.Controls.Add(this.rdbbtn12);
            this.groupBox1.Location = new System.Drawing.Point(217, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 124);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BTW";
            // 
            // rdbbtw21
            // 
            this.rdbbtw21.AutoSize = true;
            this.rdbbtw21.Location = new System.Drawing.Point(16, 87);
            this.rdbbtw21.Name = "rdbbtw21";
            this.rdbbtw21.Size = new System.Drawing.Size(57, 21);
            this.rdbbtw21.TabIndex = 13;
            this.rdbbtw21.TabStop = true;
            this.rdbbtw21.Text = "21%";
            this.rdbbtw21.UseVisualStyleBackColor = true;
            // 
            // rdbbtn12
            // 
            this.rdbbtn12.AutoSize = true;
            this.rdbbtn12.Location = new System.Drawing.Point(16, 60);
            this.rdbbtn12.Name = "rdbbtn12";
            this.rdbbtn12.Size = new System.Drawing.Size(57, 21);
            this.rdbbtn12.TabIndex = 12;
            this.rdbbtn12.TabStop = true;
            this.rdbbtn12.Text = "12%";
            this.rdbbtn12.UseVisualStyleBackColor = true;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(16, 224);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(121, 54);
            this.btnOpslaan.TabIndex = 13;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // frmIngeven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 302);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.blbexl);
            this.Controls.Add(this.lblProductNaam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmIngeven";
            this.Text = "Ingeven";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem naarOverzichtToolStripMenuItem;
        private System.Windows.Forms.Label lblProductNaam;
        private System.Windows.Forms.Label blbexl;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.RadioButton rdbbtw6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbbtw21;
        private System.Windows.Forms.RadioButton rdbbtn12;
        private System.Windows.Forms.Button btnOpslaan;
    }
}