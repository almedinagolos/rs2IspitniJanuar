using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class frmPregledNarudzbi : Form
    {
        APIService _proizvodiService = new APIService("Proizvodi");
        APIService _narudzbeService = new APIService("Narudzbe");
        APIService _pregledNarudzbiService = new APIService("PregledNarudzbi");

        public frmPregledNarudzbi()
        {
            InitializeComponent();
            dgvPregledNarudzbi.AutoGenerateColumns = false;

        }

        private async void frmPregledNarudzbi_Load(object sender, EventArgs e)
        {
            await UcitajProizvode();
            await UcitajNarudzbe();
        }

        private async Task UcitajProizvode()
        {
            var list = await _proizvodiService.GetAll<List<Model.Proizvodi>>(null);

            cmbProizvodi.DataSource = list;
            cmbProizvodi.DisplayMember = "Naziv";
            cmbProizvodi.ValueMember = "ProizvodId";
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await UcitajNarudzbe();
        }

        private async Task UcitajNarudzbe()
        {
            var request = new Model.Requests.NarudzbeSearchRequest
            {
                ProizvodiId = int.Parse(cmbProizvodi.SelectedValue.ToString()),
                MinIznosNarudzbe = int.Parse(txtIznos.Text),
                DatumDo = dtpDo.Value,
                DatumOd = dtpOd.Value
            };

            var list = await _narudzbeService.GetAll<List<Model.Narudzbe>>(request);
            dgvPregledNarudzbi.DataSource = list;
            lblSuma.Text = $"Suma: {list.Sum(x=>x.UkupanIznos).ToString("0.00")} KM";
        }

        private async void btnPohrani_Click(object sender, EventArgs e)
        {
            await UnesiPregledNarudzbi();
        }

        private async Task UnesiPregledNarudzbi()
        {
          var list = dgvPregledNarudzbi.DataSource as List<Model.Narudzbe>;
            foreach (var item in list)
            {
                var request = new Model.Requests.PregledNarudzbiInsertRequest
                {
                    BrojNarudzbe = item.BrojNarudzbe,
                    DatumDo = dtpDo.Value,
                    DatumOd = dtpOd.Value,
                    IznosNarudzbe = item.UkupanIznos,
                    KupciId = item.KupacId,
                    MinIznosNarudzbe = int.Parse(txtIznos.Text),
                    ProizvodiId = int.Parse(cmbProizvodi.SelectedValue.ToString())
                };
                await _pregledNarudzbiService.Insert<Model.PregledNarudzbi>(request);
            }
            MessageBox.Show("Podaci uneseni u bazu!");
        }
    }
}
