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
    public partial class Login : Form
    {
        private IStaffMemberRepository staffMemberRepository;
        public Login()
        {
            staffMemberRepository = new StaffMemberRepository();
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            StaffMember? staffMember = staffMemberRepository.GetStaffMember(txtEmail.Text, txtPassword.Text);

            if (staffMember != null)
            {
                if (staffMember.Role != 1)
                {
                    MessageBox.Show("You have no permission to access this function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AirConditionerManagement airConditionerManagement = new AirConditionerManagement();
                {
                };
                this.Hide();
                airConditionerManagement.ShowDialog();
                this.Visible = true;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Incorrect email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
