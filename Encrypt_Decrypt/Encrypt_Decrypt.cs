using Common.Core.Utility.Security;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public partial class Encrypt_Decrypt : Form
    {
        public Encrypt_Decrypt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInputEncrypt.Text = @"server=localhost\MSSQLSERVER01;database=DATABASE_NAME;User Id=sa;Password=654321";
            txtInputDecrypt.Text = "k3+ZZXSQDtfYtG9nywVa5wInLOtpMUjvoAUIj60KWOPVMACkTuwOznZXcXsCmVsvr5KTCVXcNrHiG+XagAs2qGnPgWmpzeIrh+rGvv90QMFgHuQH4weL86yiD5D8gAc6";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            rtxtOutputEncrypt.Text = SymmetricAlgorithmHelper.Encrypt(SymmetricAlgorithmType.AES256, "test", txtInputEncrypt.Text);
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            rtxtOutputDecrypt.Text = SymmetricAlgorithmHelper.Decrypt(SymmetricAlgorithmType.AES256, "test", txtInputDecrypt.Text);
        }

        private void btnReadme_Click(object sender, EventArgs e)
        {
            ShowRichMessageBox("Readme", File.ReadAllText("readme.txt"));
        }

        /// <summary>
        /// Shows a Rich Text Message Box
        /// </summary>
        /// <param name="title">Title of the box</param>
        /// <param name="message">Message of the box</param>
        private void ShowRichMessageBox(string title, string message)
        {
            RichTextBox rtbMessage = new RichTextBox();
            rtbMessage.Text = message;
            rtbMessage.Dock = DockStyle.Fill;
            rtbMessage.ReadOnly = true;
            rtbMessage.BorderStyle = BorderStyle.None;

            Form RichMessageBox = new Form();
            RichMessageBox.Text = title;
            RichMessageBox.StartPosition = FormStartPosition.CenterScreen;

            RichMessageBox.Controls.Add(rtbMessage);
            RichMessageBox.ShowDialog();
        }
    }
}
