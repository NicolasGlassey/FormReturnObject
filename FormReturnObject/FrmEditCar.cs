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
    public partial class FrmEditCar : Form
    {
        private Car _car = null;
        public FrmEditCar()
        {
            InitializeComponent();
        }

        //constructeur intégrant un paramètre de type car
        public FrmEditCar(Car carToUpdate)
        {
            InitializeComponent();
            //on initialise l'objet car local
            this._car = carToUpdate;
        }

        private void FrmEditCar_Load(object sender, EventArgs e)
        {
            //initialisation des champs texte
            setCarValue(this._car);
        }

        private void setCarValue(Car carToSet)
        {
            txtBBrand.Text = carToSet.brand;
            txtBModel.Text = carToSet.model;
        }

        public Car car
        {
            get { return this._car; }
        }

        private void cmdUpdateCar_Click(object sender, EventArgs e)
        {
            //on met à jour les données de la voiture en fonction de la saisie de l'utilisateur
            this._car.brand = txtBBrand.Text;
            this._car.model = txtBModel.Text;
        }
    }
}
