namespace GeneralVw.Views
{
    partial class mdMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdMessageBox));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.timeIcon = new System.Windows.Forms.Timer(this.components);
            this.lblTypeMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnPrincipal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSecondary = new Bunifu.Framework.UI.BunifuThinButton2();
            this.iconMessage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FadeTransition
            // 
            this.FadeTransition.Delay = 0;
            this.FadeTransition.TransitionEnd += new System.EventHandler(this.FadeTransition_TransitionEnd);
            // 
            // timeIcon
            // 
            this.timeIcon.Interval = 4000;
            this.timeIcon.Tick += new System.EventHandler(this.timeIcon_Tick);
            // 
            // lblTypeMessage
            // 
            this.lblTypeMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTypeMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTypeMessage.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblTypeMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblTypeMessage.Location = new System.Drawing.Point(12, 101);
            this.lblTypeMessage.Name = "lblTypeMessage";
            this.lblTypeMessage.Size = new System.Drawing.Size(313, 38);
            this.lblTypeMessage.TabIndex = 1;
            this.lblTypeMessage.Text = "Información";
            this.lblTypeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblMessage.Location = new System.Drawing.Point(12, 139);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(313, 38);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrincipal.BorderRadius = 5;
            this.btnPrincipal.ButtonText = "Aceptar";
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipal.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrincipal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrincipal.Iconimage = null;
            this.btnPrincipal.Iconimage_right = null;
            this.btnPrincipal.Iconimage_right_Selected = null;
            this.btnPrincipal.Iconimage_Selected = null;
            this.btnPrincipal.IconMarginLeft = 0;
            this.btnPrincipal.IconMarginRight = 0;
            this.btnPrincipal.IconRightVisible = true;
            this.btnPrincipal.IconRightZoom = 0D;
            this.btnPrincipal.IconVisible = true;
            this.btnPrincipal.IconZoom = 90D;
            this.btnPrincipal.IsTab = false;
            this.btnPrincipal.Location = new System.Drawing.Point(12, 167);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrincipal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrincipal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrincipal.selected = false;
            this.btnPrincipal.Size = new System.Drawing.Size(147, 35);
            this.btnPrincipal.TabIndex = 3;
            this.btnPrincipal.Text = "Aceptar";
            this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrincipal.Textcolor = System.Drawing.Color.White;
            this.btnPrincipal.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.Visible = false;
            // 
            // btnSecondary
            // 
            this.btnSecondary.ActiveBorderThickness = 1;
            this.btnSecondary.ActiveCornerRadius = 5;
            this.btnSecondary.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSecondary.ActiveForecolor = System.Drawing.Color.Gray;
            this.btnSecondary.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSecondary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecondary.BackColor = System.Drawing.Color.White;
            this.btnSecondary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecondary.BackgroundImage")));
            this.btnSecondary.ButtonText = "Cancelar";
            this.btnSecondary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecondary.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondary.ForeColor = System.Drawing.Color.Gray;
            this.btnSecondary.IdleBorderThickness = 1;
            this.btnSecondary.IdleCornerRadius = 5;
            this.btnSecondary.IdleFillColor = System.Drawing.Color.White;
            this.btnSecondary.IdleForecolor = System.Drawing.Color.Gray;
            this.btnSecondary.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSecondary.Location = new System.Drawing.Point(175, 161);
            this.btnSecondary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSecondary.Name = "btnSecondary";
            this.btnSecondary.Size = new System.Drawing.Size(147, 44);
            this.btnSecondary.TabIndex = 12;
            this.btnSecondary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSecondary.Visible = false;
            // 
            // iconMessage
            // 
            this.iconMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMessage.Enabled = false;
            this.iconMessage.Image = global::GeneralVw.Properties.Resources.check_circle;
            this.iconMessage.Location = new System.Drawing.Point(12, 1);
            this.iconMessage.Name = "iconMessage";
            this.iconMessage.Size = new System.Drawing.Size(313, 97);
            this.iconMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMessage.TabIndex = 0;
            this.iconMessage.TabStop = false;
            // 
            // mdMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 214);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.btnSecondary);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTypeMessage);
            this.Controls.Add(this.iconMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdMessageBox";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.Load += new System.EventHandler(this.mdMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FadeTransition;
        private System.Windows.Forms.PictureBox iconMessage;
        private System.Windows.Forms.Timer timeIcon;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTypeMessage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMessage;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrincipal;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSecondary;
    }
}