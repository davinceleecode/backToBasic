using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace BackToBasic
{
    public partial class frmCryptography : Telerik.WinControls.UI.RadForm
    {
        public frmCryptography()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;
        }
       

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            this.txtEncrypted.Text = myCryptography.Encrypt(this.txtString.Text, this.txtPassword.Text);
            //this.txtEncrypted.Text = myCryptography2.EncryptString(this.txtString.Text, this.txtPassword.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            this.txtDecrypted.Text = myCryptography.Decrypt(this.txtEncrypted.Text, this.txtPassword.Text);
            //this.txtDecrypted.Text = myCryptography2.DecryptString(this.txtEncrypted.Text, this.txtPassword.Text);
        }

        private void frmCryptography_Load(object sender, EventArgs e)
        {
            //this.radWaitingBar1.WaitingStep = 1;
            //this.radWaitingBar1.WaitingSpeed = 1;
            //radWaitingBar1.StopWaiting();
            radWaitingBar1.StartWaiting();

        }
    }
}
