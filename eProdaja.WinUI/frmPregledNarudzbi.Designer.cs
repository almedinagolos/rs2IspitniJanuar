
namespace eProdaja.WinUI
{
    partial class frmPregledNarudzbi
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
            this.dgvPregledNarudzbi = new System.Windows.Forms.DataGridView();
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupanIznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProizvodi = new System.Windows.Forms.ComboBox();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledNarudzbi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledNarudzbi
            // 
            this.dgvPregledNarudzbi.AllowUserToAddRows = false;
            this.dgvPregledNarudzbi.AllowUserToDeleteRows = false;
            this.dgvPregledNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledNarudzbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kupac,
            this.BrojNarudzbe,
            this.Datum,
            this.UkupanIznos});
            this.dgvPregledNarudzbi.Location = new System.Drawing.Point(28, 41);
            this.dgvPregledNarudzbi.Name = "dgvPregledNarudzbi";
            this.dgvPregledNarudzbi.ReadOnly = true;
            this.dgvPregledNarudzbi.Size = new System.Drawing.Size(739, 174);
            this.dgvPregledNarudzbi.TabIndex = 0;
            // 
            // Kupac
            // 
            this.Kupac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kupac.DataPropertyName = "Kupac";
            this.Kupac.HeaderText = "Ime i prezime";
            this.Kupac.Name = "Kupac";
            this.Kupac.ReadOnly = true;
            // 
            // BrojNarudzbe
            // 
            this.BrojNarudzbe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojNarudzbe.DataPropertyName = "BrojNarudzbe";
            this.BrojNarudzbe.HeaderText = "Broj narudzbe";
            this.BrojNarudzbe.Name = "BrojNarudzbe";
            this.BrojNarudzbe.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // UkupanIznos
            // 
            this.UkupanIznos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UkupanIznos.DataPropertyName = "UkupanIznos";
            this.UkupanIznos.HeaderText = "Ukupan iznos";
            this.UkupanIznos.Name = "UkupanIznos";
            this.UkupanIznos.ReadOnly = true;
            // 
            // cmbProizvodi
            // 
            this.cmbProizvodi.FormattingEnabled = true;
            this.cmbProizvodi.Location = new System.Drawing.Point(28, 14);
            this.cmbProizvodi.Name = "cmbProizvodi";
            this.cmbProizvodi.Size = new System.Drawing.Size(121, 21);
            this.cmbProizvodi.TabIndex = 1;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(156, 14);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 20);
            this.dtpOd.TabIndex = 2;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(362, 14);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDo.TabIndex = 3;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(569, 14);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(117, 20);
            this.txtIznos.TabIndex = 4;
            this.txtIznos.Text = "0";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(692, 12);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 5;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnPohrani
            // 
            this.btnPohrani.Location = new System.Drawing.Point(692, 221);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(75, 23);
            this.btnPohrani.TabIndex = 6;
            this.btnPohrani.Text = "Pohrani";
            this.btnPohrani.UseVisualStyleBackColor = true;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(28, 230);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(0, 13);
            this.lblSuma.TabIndex = 7;
            // 
            // frmPregledNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 350);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnPohrani);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.cmbProizvodi);
            this.Controls.Add(this.dgvPregledNarudzbi);
            this.Name = "frmPregledNarudzbi";
            this.Text = "frmPregledNarudzbi";
            this.Load += new System.EventHandler(this.frmPregledNarudzbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledNarudzbi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledNarudzbi;
        private System.Windows.Forms.ComboBox cmbProizvodi;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kupac;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupanIznos;
    }
}