﻿namespace rehberProjesi_Dosya
{
    partial class RehberdenSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RehberdenSil));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBx_AdListesi = new System.Windows.Forms.ComboBox();
            this.txtBx_Ad = new System.Windows.Forms.TextBox();
            this.txtBx_Soyad = new System.Windows.Forms.TextBox();
            this.txtBx_Tel = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Vazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADA GÖRE ARA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFON";
            // 
            // cmbBx_AdListesi
            // 
            this.cmbBx_AdListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_AdListesi.FormattingEnabled = true;
            this.cmbBx_AdListesi.Location = new System.Drawing.Point(106, 6);
            this.cmbBx_AdListesi.Name = "cmbBx_AdListesi";
            this.cmbBx_AdListesi.Size = new System.Drawing.Size(127, 21);
            this.cmbBx_AdListesi.TabIndex = 4;
            this.cmbBx_AdListesi.SelectedIndexChanged += new System.EventHandler(this.cmbBx_AdListesi_SelectedIndexChanged);
            // 
            // txtBx_Ad
            // 
            this.txtBx_Ad.Location = new System.Drawing.Point(106, 33);
            this.txtBx_Ad.Name = "txtBx_Ad";
            this.txtBx_Ad.Size = new System.Drawing.Size(127, 20);
            this.txtBx_Ad.TabIndex = 5;
            // 
            // txtBx_Soyad
            // 
            this.txtBx_Soyad.Location = new System.Drawing.Point(106, 59);
            this.txtBx_Soyad.Name = "txtBx_Soyad";
            this.txtBx_Soyad.Size = new System.Drawing.Size(127, 20);
            this.txtBx_Soyad.TabIndex = 6;
            // 
            // txtBx_Tel
            // 
            this.txtBx_Tel.Location = new System.Drawing.Point(106, 85);
            this.txtBx_Tel.Name = "txtBx_Tel";
            this.txtBx_Tel.Size = new System.Drawing.Size(127, 20);
            this.txtBx_Tel.TabIndex = 7;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(12, 122);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Vazgec.Location = new System.Drawing.Point(158, 122);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(75, 23);
            this.btn_Vazgec.TabIndex = 9;
            this.btn_Vazgec.Text = "İPTAL";
            this.btn_Vazgec.UseVisualStyleBackColor = true;
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // RehberdenSil
            // 
            this.AcceptButton = this.btn_Sil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Vazgec;
            this.ClientSize = new System.Drawing.Size(245, 157);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.txtBx_Tel);
            this.Controls.Add(this.txtBx_Soyad);
            this.Controls.Add(this.txtBx_Ad);
            this.Controls.Add(this.cmbBx_AdListesi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RehberdenSil";
            this.Text = "Rehberden Sil";
            this.Load += new System.EventHandler(this.RehberdenSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBx_AdListesi;
        private System.Windows.Forms.TextBox txtBx_Ad;
        private System.Windows.Forms.TextBox txtBx_Soyad;
        private System.Windows.Forms.TextBox txtBx_Tel;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Vazgec;
    }
}