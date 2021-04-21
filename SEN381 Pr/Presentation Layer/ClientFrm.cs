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
    public partial class ClientFrm : Form
    {
        public ClientFrm()
        {
            InitializeComponent();
        }

        private void btnClientAdd_MouseEnter(object sender, EventArgs e)
        {
            btnClientAdd.BackColor = Color.MediumSpringGreen;
            btnClientAdd.ForeColor = Color.White;
        }

        private void btnClientAdd_MouseLeave(object sender, EventArgs e)
        {
            btnClientAdd.BackColor = SystemColors.ButtonFace;
            btnClientAdd.ForeColor = SystemColors.ControlText;

        }
        private void btnClientEdit_MouseEnter(object sender, EventArgs e)
        {
            btnClientEdit.BackColor = Color.MediumSpringGreen;
            btnClientEdit.ForeColor = Color.White;
        }

        private void btnClientEdit_MouseLeave(object sender, EventArgs e)
        {
            btnClientEdit.BackColor = SystemColors.ButtonFace;
            btnClientEdit.ForeColor = SystemColors.ControlText;
        }

        private void btnClientDel_MouseEnter(object sender, EventArgs e)
        {
            btnClientDel.BackColor = Color.MediumSpringGreen;
            btnClientDel.ForeColor = Color.White;
        }

        private void btnClientDel_MouseLeave(object sender, EventArgs e)
        {
            btnClientDel.BackColor = SystemColors.ButtonFace;
            btnClientDel.ForeColor = SystemColors.ControlText;
        }

        ADOMethodController Con = new ADOMethodController();

        private void ClientFrm_Load(object sender, EventArgs e)
        {
            Con.LoadCallClients(dgvClients);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new MenuFrm()).Show();
            this.Hide();
        }

    }
}
