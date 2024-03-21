using BusinessObjects.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirConditionerShop_StudentName
{
    public partial class AirConditionerManagement : Form
    {
        private IAirConditionerRepository airConditionerRepository;
        private ISupplierCompanyRepository supplierCompanyRepository;

        public AirConditioner airConditioner { get; set; }
        public bool isAdd { get; set; }

        public AirConditionerManagement()
        {
            airConditionerRepository = new AirConditionerRepository();
            supplierCompanyRepository = new SupplierCompanyRepository();
            InitializeComponent();
            LoadAirConditionerList();
        }

        private void LoadAirConditionerList()
        {
            var airConditioners = airConditionerRepository.GetAllAirConditioners();

            var allSupplierCompanies = supplierCompanyRepository.GetAllSupplierCompanies();

            var supplierNamesDictionary = allSupplierCompanies.ToDictionary(s => s.SupplierId, s => s.SupplierName);

            var airConditionerList = airConditioners.Select(x => new
            {
                x.AirConditionerId,
                x.AirConditionerName,
                x.Warranty,
                x.SoundPressureLevel,
                x.FeatureFunction,
                x.Quantity,
                x.DollarPrice,
                SupplierName = supplierNamesDictionary.ContainsKey(x.SupplierId) ? supplierNamesDictionary[x.SupplierId] : ""
            }).ToList();

            dgvAirConditioner.DataSource = airConditionerList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAirConditioner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an air conditioner to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int airConditionerId = Convert.ToInt32(dgvAirConditioner.SelectedRows[0].Cells[0].Value);
            airConditionerRepository.DeleteAirConditioner(airConditionerId);
            LoadAirConditionerList();
        }   

        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbFeatureFunction.Checked)
            {
                dgvAirConditioner.DataSource = txtSearch.Text.Equals(string.Empty) ?
                    airConditionerRepository.GetAllAirConditioners() :
                    airConditionerRepository.GetAllAirConditioners()
                        .Where(c => c.FeatureFunction.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                        .ToList();
            }
            else if (rbQuantity.Checked)
            {
                int searchQuantity;
                if (!int.TryParse(txtSearch.Text, out searchQuantity))
                {
                    searchQuantity = 0;
                }

                dgvAirConditioner.DataSource = txtSearch.Text.Equals(string.Empty) ?
                    airConditionerRepository.GetAllAirConditioners() :
                    airConditionerRepository.GetAllAirConditioners()
                        .Where(c => c.Quantity == searchQuantity)
                        .ToList();
            }
            else
            {
                LoadAirConditionerList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvAirConditioner.CurrentRow.Index;
            DataGridViewRow row = dgvAirConditioner.Rows[currentIndex];
            AirConditionerForm airConditionerForm = new AirConditionerForm()
            {
                Text = "Update Air Conditioner",
                isAdd = false,
                airConditioner = new AirConditioner()
                {
                    AirConditionerId = (int)row.Cells[0].Value,
                    AirConditionerName = (string)row.Cells[1].Value,
                    Warranty = (string)row.Cells[2].Value,
                    SoundPressureLevel = (string)row.Cells[3].Value,
                    FeatureFunction = (string)row.Cells[4].Value,
                    Quantity = (int)row.Cells[5].Value,
                    DollarPrice = (double)row.Cells[6].Value,
                    SupplierId = supplierCompanyRepository.GetAllSupplierCompanies().FirstOrDefault(s => s.SupplierName == row.Cells[7].Value.ToString()).SupplierId
                }
            };
            airConditionerForm.ShowDialog();
            LoadAirConditionerList();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            int lastIndex = dgvAirConditioner.Rows.Count - 1;
            AirConditionerForm airConditionerForm = new AirConditionerForm()
            {
                Text = "Add Air Conditioner",
                isAdd = true,
                generatedId = (int)dgvAirConditioner.Rows[lastIndex].Cells[0].Value + 1
            };
            airConditionerForm.ShowDialog();
            LoadAirConditionerList();
        }

    }
}
