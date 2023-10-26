namespace odev2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label3 = new Label();
            dtarihibox = new MaskedTextBox();
            temizlebox = new Button();
            kaydetbox = new Button();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            meslekbox = new TextBox();
            kimlikbox = new TextBox();
            adresbox = new TextBox();
            soyadbox = new TextBox();
            adbox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            telbox = new MaskedTextBox();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            ekranıtemizle = new Button();
            label11 = new Label();
            label10 = new Label();
            kayıtsilbox = new Button();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            groupBox4 = new GroupBox();
            temizlebutton = new Button();
            sorgubutton = new Button();
            label12 = new Label();
            sorgubox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtarihibox);
            groupBox1.Controls.Add(temizlebox);
            groupBox1.Controls.Add(kaydetbox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(meslekbox);
            groupBox1.Controls.Add(kimlikbox);
            groupBox1.Controls.Add(adresbox);
            groupBox1.Controls.Add(soyadbox);
            groupBox1.Controls.Add(adbox);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(telbox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 440);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Banka Müşteri Kayıt Sistemi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 97);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 25;
            label3.Text = "Adres :";
            // 
            // dtarihibox
            // 
            dtarihibox.Location = new Point(155, 118);
            dtarihibox.Mask = "00/00/0000";
            dtarihibox.Name = "dtarihibox";
            dtarihibox.Size = new Size(100, 23);
            dtarihibox.TabIndex = 24;
            dtarihibox.ValidatingType = typeof(DateTime);
            // 
            // temizlebox
            // 
            temizlebox.BackColor = Color.Turquoise;
            temizlebox.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            temizlebox.Location = new Point(16, 266);
            temizlebox.Name = "temizlebox";
            temizlebox.Size = new Size(100, 56);
            temizlebox.TabIndex = 22;
            temizlebox.Text = "TEMİZLE";
            temizlebox.UseVisualStyleBackColor = false;
            temizlebox.Click += temizlebox_Click;
            // 
            // kaydetbox
            // 
            kaydetbox.BackColor = Color.LightPink;
            kaydetbox.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            kaydetbox.Location = new Point(155, 266);
            kaydetbox.Name = "kaydetbox";
            kaydetbox.Size = new Size(100, 56);
            kaydetbox.TabIndex = 21;
            kaydetbox.Text = "KAYDET";
            kaydetbox.UseVisualStyleBackColor = false;
            kaydetbox.Click += kaydetbox_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 126);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 18;
            label9.Text = "Doğum Tarihi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 216);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 12;
            label6.Text = "Telefon No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 187);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Meslek :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 158);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 10;
            label4.Text = "Kimlik No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 68);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 8;
            label2.Text = "Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 37);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 7;
            label1.Text = "Ad :";
            // 
            // meslekbox
            // 
            meslekbox.Location = new Point(155, 179);
            meslekbox.Name = "meslekbox";
            meslekbox.PlaceholderText = "Mesleğinizi Giriniz";
            meslekbox.Size = new Size(100, 23);
            meslekbox.TabIndex = 6;
            // 
            // kimlikbox
            // 
            kimlikbox.Location = new Point(155, 150);
            kimlikbox.Name = "kimlikbox";
            kimlikbox.PlaceholderText = "***********";
            kimlikbox.Size = new Size(100, 23);
            kimlikbox.TabIndex = 5;
            // 
            // adresbox
            // 
            adresbox.Location = new Point(155, 89);
            adresbox.Name = "adresbox";
            adresbox.PlaceholderText = "Şehir / İlçe";
            adresbox.Size = new Size(100, 23);
            adresbox.TabIndex = 4;
            // 
            // soyadbox
            // 
            soyadbox.Location = new Point(155, 60);
            soyadbox.Name = "soyadbox";
            soyadbox.PlaceholderText = "Soyadınızı Giriniz";
            soyadbox.Size = new Size(100, 23);
            soyadbox.TabIndex = 3;
            // 
            // adbox
            // 
            adbox.Location = new Point(155, 31);
            adbox.Name = "adbox";
            adbox.PlaceholderText = "Adınızı Giriniz";
            adbox.Size = new Size(100, 23);
            adbox.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 410);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // telbox
            // 
            telbox.Location = new Point(155, 208);
            telbox.Mask = "(999) 000-0000";
            telbox.Name = "telbox";
            telbox.Size = new Size(100, 23);
            telbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(311, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 288);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kayıt Görüntüle";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.WhiteSmoke;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(437, 244);
            listBox1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(ekranıtemizle);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(kayıtsilbox);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Location = new Point(783, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 440);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kayıt Sil";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(108, 410);
            label7.Name = "label7";
            label7.Size = new Size(84, 16);
            label7.TabIndex = 26;
            label7.Text = "DesingBank®";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // ekranıtemizle
            // 
            ekranıtemizle.BackColor = Color.OrangeRed;
            ekranıtemizle.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ekranıtemizle.Location = new Point(6, 82);
            ekranıtemizle.Name = "ekranıtemizle";
            ekranıtemizle.Size = new Size(79, 56);
            ekranıtemizle.TabIndex = 4;
            ekranıtemizle.Text = "TÜM KAYITLARI TEMİZLE";
            ekranıtemizle.UseVisualStyleBackColor = false;
            ekranıtemizle.Click += ekranıtemizle_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(6, 200);
            label11.Name = "label11";
            label11.Size = new Size(195, 17);
            label11.TabIndex = 3;
            label11.Text = "LİSTEDEN SEÇİP BUTONA BASINIZ!";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(6, 183);
            label10.Name = "label10";
            label10.Size = new Size(158, 17);
            label10.TabIndex = 2;
            label10.Text = "*SİLMEK İSTEDİĞİNİZ KAYDI";
            // 
            // kayıtsilbox
            // 
            kayıtsilbox.BackColor = Color.Red;
            kayıtsilbox.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            kayıtsilbox.Location = new Point(121, 82);
            kayıtsilbox.Name = "kayıtsilbox";
            kayıtsilbox.Size = new Size(71, 56);
            kayıtsilbox.TabIndex = 1;
            kayıtsilbox.Text = "KAYIT SİL";
            kayıtsilbox.UseVisualStyleBackColor = false;
            kayıtsilbox.Click += kayıtsilbox_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 23);
            comboBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(980, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(temizlebutton);
            groupBox4.Controls.Add(sorgubutton);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(sorgubox);
            groupBox4.Location = new Point(311, 306);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(449, 146);
            groupBox4.TabIndex = 66;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aranan İsimde Kayıtlı Kullanıcı Sayısı Sorgu Ekranı";
            // 
            // temizlebutton
            // 
            temizlebutton.BackColor = Color.MediumSeaGreen;
            temizlebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            temizlebutton.Location = new Point(210, 76);
            temizlebutton.Name = "temizlebutton";
            temizlebutton.Size = new Size(66, 51);
            temizlebutton.TabIndex = 10;
            temizlebutton.Text = "TEMİZLE";
            temizlebutton.UseVisualStyleBackColor = false;
            temizlebutton.Click += temizlebutton_Click;
            // 
            // sorgubutton
            // 
            sorgubutton.BackColor = Color.Tan;
            sorgubutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            sorgubutton.Location = new Point(306, 76);
            sorgubutton.Name = "sorgubutton";
            sorgubutton.Size = new Size(137, 51);
            sorgubutton.TabIndex = 9;
            sorgubutton.Text = "SORGULA";
            sorgubutton.UseVisualStyleBackColor = false;
            sorgubutton.Click += sorgubutton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 38);
            label12.Name = "label12";
            label12.Size = new Size(171, 15);
            label12.TabIndex = 8;
            label12.Text = "Aramak İstediğiniz İsmi Giriniz :";
            // 
            // sorgubox
            // 
            sorgubox.Location = new Point(306, 35);
            sorgubox.Name = "sorgubox";
            sorgubox.PlaceholderText = "...........................................";
            sorgubox.Size = new Size(137, 23);
            sorgubox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1004, 464);
            Controls.Add(groupBox4);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox meslekbox;
        private TextBox kimlikbox;
        private TextBox adresbox;
        private TextBox soyadbox;
        private TextBox adbox;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox telbox;
        private Label label9;
        private Button temizlebox;
        private Button kaydetbox;
        private ListBox listBox1;
        private GroupBox groupBox3;
        private Button kayıtsilbox;
        private ComboBox comboBox1;
        private Label label11;
        private Label label10;
        private MaskedTextBox dtarihibox;
        private Label label3;
        private Button ekranıtemizle;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label8;
        private GroupBox groupBox4;
        private Label label12;
        private TextBox sorgubox;
        private Button sorgubutton;
        private Button temizlebutton;
    }
}