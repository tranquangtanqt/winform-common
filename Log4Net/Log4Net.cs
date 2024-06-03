using log4net;
using System;
using System.IO;
using System.Windows.Forms;

namespace Log4Net
{
    public partial class Log4Net : Form
    {
        public Log4Net()
        {
            InitializeComponent();
        }

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private void Form1_Load(object sender, EventArgs e)
        {
            log.Debug("Debug");
            log.Info("Info");
            log.Warn("Warn");
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
            RichMessageBox.Width = 500;

            RichMessageBox.Controls.Add(rtbMessage);
            RichMessageBox.ShowDialog();
        }
    }
}
