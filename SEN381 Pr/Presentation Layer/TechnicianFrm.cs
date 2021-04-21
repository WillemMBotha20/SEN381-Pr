using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Pr
{
    public partial class TechnicianFrm : Form
    {
        ADOMethodController Con = new ADOMethodController();
        private string _id;

        public TechnicianFrm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void TechnicianFrm_Load(object sender, EventArgs e)
        {            
            dgvTechnician.DataSource = Con.LoadTechData();
            dgvTechnician.DataMember = "Table";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {          
            Con.InsertTechData(dgvTechnician,txtName.Text,txtSurname.Text,txtNumber.Text);            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.UpdateTechData(dgvTechnician, txtName.Text, txtSurname.Text, txtNumber.Text, int.Parse(_id));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {         
               Con.DeleteTechData(dgvTechnician,  int.Parse(_id));                      
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void dgvTechnician_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTechnician.CurrentRow;
            if (!row.IsNewRow)
            {
                _id = row.Cells[0].Value.ToString();               
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtNumber.Text = row.Cells["Number"].Value.ToString();
                txtSurname.Text = row.Cells["Surname"].Value.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
