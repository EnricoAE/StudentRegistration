using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {

        public frmConfirmation()
        {
            InitializeComponent();
        }
        public void EmptyFormControls(Control control)
        {
            if (control is TextBox)
            {
                ((TextBox)control).Text = string.Empty;
            }

            for (int i = 0; i < control.Controls.Count; i++)
            {
                EmptyFormControls(control.Controls[i]);
            }
            frmRegistration obj = new frmRegistration();
            EmptyFormControls(obj);
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName;
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblBirtday.Text = StudentInformationClass.SetBirthday;
            lblGender.Text = StudentInformationClass.SetGender;
            lblContactNo.Text = StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Submitted!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
