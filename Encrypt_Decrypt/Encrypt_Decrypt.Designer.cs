
namespace Common
{
    partial class Encrypt_Decrypt
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
            this.grpEncrypt = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtOutputEncrypt = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtInputEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDecrypt = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtOutputDecrypt = new System.Windows.Forms.RichTextBox();
            this.txtInputDecrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnReadme = new System.Windows.Forms.Button();
            this.grpEncrypt.SuspendLayout();
            this.grpDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEncrypt
            // 
            this.grpEncrypt.Controls.Add(this.label3);
            this.grpEncrypt.Controls.Add(this.rtxtOutputEncrypt);
            this.grpEncrypt.Controls.Add(this.btnEncrypt);
            this.grpEncrypt.Controls.Add(this.txtInputEncrypt);
            this.grpEncrypt.Controls.Add(this.label1);
            this.grpEncrypt.Location = new System.Drawing.Point(12, 24);
            this.grpEncrypt.Name = "grpEncrypt";
            this.grpEncrypt.Size = new System.Drawing.Size(890, 182);
            this.grpEncrypt.TabIndex = 7;
            this.grpEncrypt.TabStop = false;
            this.grpEncrypt.Text = "Encrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "output";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtxtOutputEncrypt
            // 
            this.rtxtOutputEncrypt.Location = new System.Drawing.Point(11, 76);
            this.rtxtOutputEncrypt.Name = "rtxtOutputEncrypt";
            this.rtxtOutputEncrypt.Size = new System.Drawing.Size(849, 83);
            this.rtxtOutputEncrypt.TabIndex = 10;
            this.rtxtOutputEncrypt.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(780, 26);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtInputEncrypt
            // 
            this.txtInputEncrypt.Location = new System.Drawing.Point(41, 28);
            this.txtInputEncrypt.Name = "txtInputEncrypt";
            this.txtInputEncrypt.Size = new System.Drawing.Size(715, 20);
            this.txtInputEncrypt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "input";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpDecrypt
            // 
            this.grpDecrypt.Controls.Add(this.label4);
            this.grpDecrypt.Controls.Add(this.rtxtOutputDecrypt);
            this.grpDecrypt.Controls.Add(this.txtInputDecrypt);
            this.grpDecrypt.Controls.Add(this.label2);
            this.grpDecrypt.Controls.Add(this.btnDecrypt);
            this.grpDecrypt.Location = new System.Drawing.Point(12, 233);
            this.grpDecrypt.Name = "grpDecrypt";
            this.grpDecrypt.Size = new System.Drawing.Size(890, 221);
            this.grpDecrypt.TabIndex = 8;
            this.grpDecrypt.TabStop = false;
            this.grpDecrypt.Text = "Decrypt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "output";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtxtOutputDecrypt
            // 
            this.rtxtOutputDecrypt.Location = new System.Drawing.Point(6, 114);
            this.rtxtOutputDecrypt.Name = "rtxtOutputDecrypt";
            this.rtxtOutputDecrypt.Size = new System.Drawing.Size(849, 83);
            this.rtxtOutputDecrypt.TabIndex = 12;
            this.rtxtOutputDecrypt.Text = "";
            // 
            // txtInputDecrypt
            // 
            this.txtInputDecrypt.Location = new System.Drawing.Point(41, 28);
            this.txtInputDecrypt.Name = "txtInputDecrypt";
            this.txtInputDecrypt.Size = new System.Drawing.Size(819, 20);
            this.txtInputDecrypt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "input";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(780, 67);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnReadme
            // 
            this.btnReadme.Location = new System.Drawing.Point(831, 502);
            this.btnReadme.Name = "btnReadme";
            this.btnReadme.Size = new System.Drawing.Size(75, 23);
            this.btnReadme.TabIndex = 9;
            this.btnReadme.Text = "Readme";
            this.btnReadme.UseVisualStyleBackColor = true;
            this.btnReadme.Click += new System.EventHandler(this.btnReadme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 537);
            this.Controls.Add(this.btnReadme);
            this.Controls.Add(this.grpDecrypt);
            this.Controls.Add(this.grpEncrypt);
            this.Name = "Form1";
            this.Text = "Encrypt_Decrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEncrypt.ResumeLayout(false);
            this.grpEncrypt.PerformLayout();
            this.grpDecrypt.ResumeLayout(false);
            this.grpDecrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtOutputEncrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtInputEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtOutputDecrypt;
        private System.Windows.Forms.TextBox txtInputDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnReadme;
    }
}

