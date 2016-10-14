using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormReturnObject
{
    public partial class FrmCar : Form
    {
        private Car _car = new Car("Volvo", "V60");

        public FrmCar()
        {
            InitializeComponent();
        }

        private void FrmCar_Load(object sender, EventArgs e)
        {
            //initialisation des champs text
            setCarValue(this._car);
        }

        private void setCarValue(Car carToSet)
        {
            txtBBrand.Text = carToSet.brand;
            txtBModel.Text = carToSet.model;
        }

        private void cmdUpdateCar_Click(object sender, EventArgs e)
        {
            //mise à jour des valeurs en appelant un formulaire modal
            FrmEditCar frmEditCar = new FrmEditCar(this._car);

            if (frmEditCar.ShowDialog(this) == DialogResult.OK)
            {
                this._car = frmEditCar.car;
            }
            //on libère le formulaire "edit car"
            frmEditCar.Dispose();

            //on met à jour les données de la voiture
            setCarValue(this._car);
        }
    }
}
