﻿namespace proje19_hastane_
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnolustur = new System.Windows.Forms.Button();
            this.rchduyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtbrans = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnrandevuliste = new System.Windows.Forms.Button();
            this.btnbranspanel = new System.Windows.Forms.Button();
            this.btndoktorpanel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtdoktor = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbrans)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgileri";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(123, 79);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(87, 23);
            this.lbladsoyad.TabIndex = 3;
            this.lbladsoyad.Text = "Null Null";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(118, 40);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(142, 23);
            this.lbltc.TabIndex = 2;
            this.lbltc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnolustur);
            this.groupBox2.Controls.Add(this.rchduyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnolustur
            // 
            this.btnolustur.Location = new System.Drawing.Point(13, 249);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(270, 36);
            this.btnolustur.TabIndex = 1;
            this.btnolustur.Text = "Oluştur";
            this.btnolustur.UseVisualStyleBackColor = true;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // rchduyuru
            // 
            this.rchduyuru.Location = new System.Drawing.Point(13, 39);
            this.rchduyuru.Name = "rchduyuru";
            this.rchduyuru.Size = new System.Drawing.Size(270, 197);
            this.rchduyuru.TabIndex = 0;
            this.rchduyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntemizle);
            this.groupBox3.Controls.Add(this.btnkaydet);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.msktc);
            this.groupBox3.Controls.Add(this.cmbdoktor);
            this.groupBox3.Controls.Add(this.cmbbrans);
            this.groupBox3.Controls.Add(this.msksaat);
            this.groupBox3.Controls.Add(this.msktarih);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(317, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 463);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(117, 418);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(145, 37);
            this.btntemizle.TabIndex = 16;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(117, 375);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(145, 37);
            this.btnkaydet.TabIndex = 14;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(115, 342);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 27);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Durum";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(117, 297);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(145, 29);
            this.msktc.TabIndex = 12;
            this.msktc.ValidatingType = typeof(int);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(117, 247);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(145, 31);
            this.cmbdoktor.TabIndex = 11;
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(117, 197);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(145, 31);
            this.cmbbrans.TabIndex = 10;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(116, 147);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(146, 29);
            this.msksaat.TabIndex = 9;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(117, 97);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(145, 29);
            this.msktarih.TabIndex = 8;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(117, 47);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(145, 29);
            this.txtid.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "TC No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Saat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtbrans);
            this.groupBox4.Location = new System.Drawing.Point(669, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 263);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dtbrans
            // 
            this.dtbrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtbrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtbrans.Location = new System.Drawing.Point(3, 25);
            this.dtbrans.Name = "dtbrans";
            this.dtbrans.Size = new System.Drawing.Size(558, 235);
            this.dtbrans.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnrandevuliste);
            this.groupBox6.Controls.Add(this.btnbranspanel);
            this.groupBox6.Controls.Add(this.btndoktorpanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 481);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(624, 91);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnrandevuliste
            // 
            this.btnrandevuliste.Location = new System.Drawing.Point(305, 28);
            this.btnrandevuliste.Name = "btnrandevuliste";
            this.btnrandevuliste.Size = new System.Drawing.Size(141, 44);
            this.btnrandevuliste.TabIndex = 2;
            this.btnrandevuliste.Text = "Randevu Liste";
            this.btnrandevuliste.UseVisualStyleBackColor = true;
            this.btnrandevuliste.Click += new System.EventHandler(this.btnrandevuliste_Click);
            // 
            // btnbranspanel
            // 
            this.btnbranspanel.Location = new System.Drawing.Point(169, 28);
            this.btnbranspanel.Name = "btnbranspanel";
            this.btnbranspanel.Size = new System.Drawing.Size(130, 44);
            this.btnbranspanel.TabIndex = 1;
            this.btnbranspanel.Text = "Branş Paneli";
            this.btnbranspanel.UseVisualStyleBackColor = true;
            this.btnbranspanel.Click += new System.EventHandler(this.btnbranspanel_Click);
            // 
            // btndoktorpanel
            // 
            this.btndoktorpanel.Location = new System.Drawing.Point(25, 28);
            this.btndoktorpanel.Name = "btndoktorpanel";
            this.btndoktorpanel.Size = new System.Drawing.Size(138, 44);
            this.btndoktorpanel.TabIndex = 0;
            this.btndoktorpanel.Text = "Doktor Paneli";
            this.btndoktorpanel.UseVisualStyleBackColor = true;
            this.btndoktorpanel.Click += new System.EventHandler(this.btndoktorpanel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtdoktor);
            this.groupBox5.Location = new System.Drawing.Point(669, 281);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(564, 291);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dtdoktor
            // 
            this.dtdoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtdoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtdoktor.Location = new System.Drawing.Point(3, 25);
            this.dtdoktor.Name = "dtdoktor";
            this.dtdoktor.Size = new System.Drawing.Size(558, 263);
            this.dtdoktor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1245, 602);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtbrans)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtdoktor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnolustur;
        private System.Windows.Forms.RichTextBox rchduyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtbrans;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtdoktor;
        private System.Windows.Forms.Button btnrandevuliste;
        private System.Windows.Forms.Button btnbranspanel;
        private System.Windows.Forms.Button btndoktorpanel;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button button1;
    }
}