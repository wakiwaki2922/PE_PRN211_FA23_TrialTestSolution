using BusinessObjects.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirConditionerShop_StudentName
{
    public partial class AirConditionerForm : Form
    {
        private IAirConditionerRepository airConditionerRepository;
        private ISupplierCompanyRepository supplierCompanyRepository;

        public Boolean isAdd { get; set; }
        public int generatedId { get; set; }
        public AirConditioner airConditioner { get; set; }
        public AirConditionerForm()
        {
            airConditionerRepository = new AirConditionerRepository();
            supplierCompanyRepository = new SupplierCompanyRepository();
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) ||
                string.IsNullOrEmpty(txtProductWarranty.Text) ||
                string.IsNullOrEmpty(txtProductSPL.Text) ||
                string.IsNullOrEmpty(txtProductFF.Text) ||
                string.IsNullOrEmpty(txtProductQuantity.Text) ||
                string.IsNullOrEmpty(txtProductPrice.Text) ||
                cbProductSupplier.SelectedValue == null)
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal dollarPrice;
            if (!decimal.TryParse(txtProductPrice.Text, out dollarPrice) ||
                dollarPrice < 0 || dollarPrice >= 4000000)
            {
                MessageBox.Show("Value for Price must be greater than or equal to 0 and less than 4,000,000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity;
            if (!int.TryParse(txtProductQuantity.Text, out quantity) ||
                quantity < 0 || quantity >= 4000000)
            {
                MessageBox.Show("Value for Quantity must be greater than or equal to 0 and less than 4,000,000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string airConditionerName = txtProductName.Text;
            if (airConditionerName.Length < 5 || airConditionerName.Length > 90 ||
                !char.IsUpper(airConditionerName[0]) ||
                !Regex.IsMatch(airConditionerName, @"^[A-Za-z0-9\s\.\,\-]+$"))
            {
                MessageBox.Show("AirConditionerName must be in the range of 5 - 90 characters, begin with a capital letter, and only contain alphanumeric characters, spaces, periods, commas, and hyphens.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isAdd)
            {
                airConditioner = new AirConditioner
                {
                    AirConditionerId = int.Parse(txtProductId.Text),
                    AirConditionerName = txtProductName.Text,
                    Warranty = txtProductWarranty.Text,
                    SoundPressureLevel = txtProductSPL.Text,
                    FeatureFunction = txtProductFF.Text,
                    Quantity = int.Parse(txtProductQuantity.Text),
                    DollarPrice = double.Parse(txtProductPrice.Text),
                    SupplierId = cbProductSupplier.SelectedValue.ToString()
                };
                airConditionerRepository.AddAirConditioner(airConditioner);
            }
            else
            {
                airConditioner.AirConditionerId = int.Parse(txtProductId.Text);
                airConditioner.AirConditionerName = txtProductName.Text;
                airConditioner.Warranty = txtProductWarranty.Text;
                airConditioner.SoundPressureLevel = txtProductSPL.Text;
                airConditioner.FeatureFunction = txtProductFF.Text;
                airConditioner.Quantity = int.Parse(txtProductQuantity.Text);
                airConditioner.DollarPrice = double.Parse(txtProductPrice.Text);
                airConditioner.SupplierId = cbProductSupplier.SelectedValue.ToString();
                airConditionerRepository.UpdateAirConditioner(airConditioner);
            }

            this.Close();
        }

        private void cbProductSupplier_Click(object sender, EventArgs e)
        {
            cbProductSupplier.DataSource = supplierCompanyRepository.GetAllSupplierCompanies();
            cbProductSupplier.DisplayMember = "SupplierName";
            cbProductSupplier.ValueMember = "SupplierId";
        }

        private void AirConditionerForm_Load(object sender, EventArgs e)
        {
            txtProductId.Text = generatedId.ToString();

            cbProductSupplier.DataSource = supplierCompanyRepository.GetAllSupplierCompanies();
            cbProductSupplier.DisplayMember = "SupplierName";
            cbProductSupplier.ValueMember = "SupplierId";

            if (airConditioner != null)
            {
                txtProductId.Text = airConditioner.AirConditionerId.ToString();
                txtProductName.Text = airConditioner.AirConditionerName;
                txtProductWarranty.Text = airConditioner.Warranty.ToString();
                txtProductSPL.Text = airConditioner.SoundPressureLevel.ToString();
                txtProductFF.Text = airConditioner.FeatureFunction;
                txtProductQuantity.Text = airConditioner.Quantity.ToString();
                txtProductPrice.Text = airConditioner.DollarPrice.ToString();

                cbProductSupplier.SelectedValue = airConditioner.SupplierId;
            }
        }

    }
}
