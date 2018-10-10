using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GeneralVw.Views;

namespace ERP.Views
{
    public partial class frmPrincipal : Form
    {

        #region Variables
        private bool maximized = false;
        #endregion
        public frmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void openForm(object form)
        {
            if (Container.Controls.Count > 0)
                this.Container.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Container.Controls.Add(frm);
            frm.Show();
        }

        private void ButtonGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                sidePanel.Height = btn.Height;
                sidePanel.Top = btn.Top;

                switch (btn.Name)
                {
                    case "btnUsuarios":
                        mdGridView md = new mdGridView();
                        openForm(md);
                        
                        break;
                    case "btnCerrarSesion":
                        //mdLoading loading = new mdLoading();
                        mdMessageBox.messageBox(this, "¿Desea cerras sesión ?", "Delete", mdMessageBox.typeMessage.DialogOk, mdMessageBox.typeIcon.logOut);
                        //loading.ShowDialog();
                        break;
                    case "btnHome":
                        frmDatosTienda datosTienda = new frmDatosTienda();
                        openForm(datosTienda);
                        break;
                }

                
            }
            catch { }
        }
        
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (!maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                maximized = true;
                btnMaximize.Image = Properties.Resources.restart;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximized = false;
                btnMaximize.Image = Properties.Resources.maximize1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void header2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            mdMessageBox.messageBox(this, "Operación realizada con éxito.", "Success", mdMessageBox.typeMessage.Dialog, mdMessageBox.typeIcon.Succes);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            mdMessageBox.messageBox(this, "Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. No sólo sobrevivió 500 años, sino que tambien ingresó como texto de relleno en documentos electrónicos, quedando esencialmente igual al original. Fue popularizado en los 60s con la creación de las hojas Letraset, las cuales contenian pasajes de Lorem Ipsum, y más recientemente con software de autoedición, como por ejemplo Aldus PageMaker, el cual incluye versiones de Lorem Ipsum. ", "Warning", mdMessageBox.typeMessage.DialogOk, mdMessageBox.typeIcon.Warning);

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            mdMessageBox.messageBox(this, "¿Desear editar el registro?.", "Editar", mdMessageBox.typeMessage.DialogAcceptCancel, mdMessageBox.typeIcon.Edit);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            mdMessageBox.messageBox(this, "No puede realizar la acción.", "Delete", mdMessageBox.typeMessage.DialogYesNo, mdMessageBox.typeIcon.Delete);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //frmDatosTienda frm = new frmDatosTienda();
            //openForm(frm);
        }
    }
}
