using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneralVw.Views;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace ERP.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_MouseDown(object sender, MouseEventArgs e)
        {
            lblUser.Visible = true;
        }

        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            lblUser.Visible = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //mdGridView md = new mdGridView();
            //md.Show();
            frmPrincipal frm = new frmPrincipal();
            frm.Show(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            
        }
    }
}
