using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralVw.Views
{
    public partial class mdMessageBox : Form
    {
        
        public typeMessage? tpMessage;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);
        public mdMessageBox()
        {
            InitializeComponent();
            
        }

        private void mdMessageBox_Load(object sender, EventArgs e)
        {
            FadeTransition.ShowAsyc(this);
        }

        private void FadeTransition_TransitionEnd(object sender, EventArgs e)
        {
            timeIcon.Start();
            iconMessage.Enabled = true;
        }

        private void timeIcon_Tick(object sender, EventArgs e)
        {
            iconMessage.Enabled = false;
            FadeTransition.HideAsyc(this, true);
            timeIcon.Stop();
            if (tpMessage != null)
                if (tpMessage == typeMessage.Dialog)
                    this.Close();
        }

        public enum typeMessage
        {
            Dialog,
            DialogOk,
            DialogYesNo,
            DialogAcceptCancel
        }

        public enum typeIcon
        {
            Information,
            Warning,
            Succes,
            Error,
            Delete,
            Edit,
            logOut,
            Notification
        }

        private void InitButtons(typeMessage tpMessage)
        {

            try
            {
                switch (tpMessage)
                {
                    case typeMessage.Dialog:

                        break;
                    case typeMessage.DialogAcceptCancel:
                        btnPrincipal.Visible = true;
                        btnSecondary.Visible = true;
                        btnPrincipal.Text = "Aceptar";
                        btnSecondary.ButtonText = "Cancelar";
                        break;
                    case typeMessage.DialogOk:
                        btnPrincipal.Visible = true;
                        btnPrincipal.Text = "Aceptar";
                        btnPrincipal.Location = btnSecondary.Location;
                        break;
                    case typeMessage.DialogYesNo:
                        btnPrincipal.Visible = true;
                        btnSecondary.Visible = true;
                        btnPrincipal.Text = "Si";
                        btnSecondary.ButtonText = "No";
                        break;
                }
            }
            catch { }
        }

        private void InitIcon(typeIcon icon)
        {
            switch (icon)
            {
                case typeIcon.Delete:
                    iconMessage.Image = Properties.Resources.delete;
                    break;
                case typeIcon.Edit:
                    iconMessage.Image = Properties.Resources.Edit;
                    break;
                case typeIcon.Error:
                    iconMessage.Image = Properties.Resources.Error;
                    break;
                case typeIcon.Information:
                    iconMessage.Image = Properties.Resources.Information;
                    break;
                case typeIcon.Succes:
                    iconMessage.Image = Properties.Resources.check_circle1;
                    break;
                case typeIcon.Warning:
                    iconMessage.Image = Properties.Resources.Warning_;
                    break;
                case typeIcon.logOut:
                    iconMessage.Image = Properties.Resources.LogOut;
                    break;
                case typeIcon.Notification:
                    iconMessage.Image = Properties.Resources.notifications;
                    break;
            }
        }

        private Size MessageSize(string message, mdMessageBox mdMessageBoxObject, typeMessage button)
        {
            Graphics g = mdMessageBoxObject.CreateGraphics();
            int width = 337;
            int height = 214;

            SizeF size = g.MeasureString(message, new System.Drawing.Font("Microsoft Sans Serif", 14));

            if(size.Width > 337)
            {
                string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
                int lines = groups.Length + 1;
                //width = (int)size.Width/* + 20*/;

                if ((int)size.Width <= 1000)
                {
                    width = ((int)size.Width > 900 ? 800 : (int)size.Width);
                }
                else
                {
                    width = 1200;
                }


                if (button != typeMessage.Dialog)
                    height += ((int)(size.Height + 0) * lines) + 44;
            }
            else
            {
                string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
                int lines = groups.Length + 1;
                if(button != typeMessage.Dialog)
                    height += ((int)(size.Height + 0) * lines) + 44;
            }


            //if (message.Length < 50)
            //{
            //    if ((int)size.Width > 350)
            //    {
            //        width = (int)size.Width;
            //    }
            //}
            //else
            //{
            //    string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
            //    int lines = groups.Length + 1;
            //    if ((int)size.Width <= 1000)
            //    {
            //        width = ((int)size.Width > 900 ? 800 : (int)size.Width);
            //    }
            //    else
            //    {
            //        width = 1200;
            //    }
            //    height += (int)(size.Height + 0) * lines;
            //}
            return new Size(width, height);
        }

        public static mdMessageBox messageBox(IWin32Window owner, string message, string tittle, typeMessage buttons, typeIcon icon)
        {
            
            MessageBeep(0);
            mdMessageBox mdMessage = new mdMessageBox();
            mdMessage.tpMessage = buttons;
            mdMessage.ShowInTaskbar = false;
            mdMessage.lblTypeMessage.Text = tittle;
            mdMessage.lblMessage.Text = message;

            mdMessage.InitButtons(buttons);
            mdMessage.InitIcon(icon);
            mdMessage.Size = mdMessage.MessageSize(message, mdMessage, buttons);
            mdMessage.ShowDialog(/*owner*/);

            return mdMessage;
        }
    }
}
