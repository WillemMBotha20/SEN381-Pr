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
    public partial class ServicesFrm : Form
    {
        ADOMethodController Con = new ADOMethodController();

        public ServicesFrm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Con.InsertService(dgvServices, txtID.Text, txtName.Text, txtDescription.Text, textLevel.Text, int.Parse(textDur.Text), textSLA.Text, chkEquipment.Checked);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.UpdateService(dgvServices, txtID.Text, txtName.Text, txtDescription.Text, textLevel.Text, int.Parse(textDur.Text), textSLA.Text, chkEquipment.Checked);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Con.DeleteService(dgvServices, txtID.Text, txtName.Text, txtDescription.Text, textLevel.Text, int.Parse(textDur.Text), textSLA.Text, chkEquipment.Checked);
        }

        private void ServicesFrm_Load(object sender, EventArgs e)
        {
            Con.LoadServices(dgvServices);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvServices.CurrentRow;
            if (!row.IsNewRow)
            {
                txtID.Text = row.Cells["ServiceId"].Value.ToString();
                txtName.Text = row.Cells["ServiceName"].Value.ToString();
                txtDescription.Text = row.Cells["ServiceDescription"].Value.ToString();
                textLevel.Text = row.Cells["ServiceLevel"].Value.ToString();
                textDur.Text = row.Cells["ResolutionPeriod"].Value.ToString();
                textSLA.Text = row.Cells["ServiceLevelAgreement"].Value.ToString();
                chkEquipment.Checked = Convert.ToBoolean(row.Cells["IsEquipment"].Value);

            }
        }
    }
}
