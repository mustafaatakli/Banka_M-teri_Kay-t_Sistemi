using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Liste_Ad = new List<string>();
        List<string> Liste_Soyad = new List<string>();
        List<string> Liste_Adres = new List<string>();
        List<string> Liste_Kimlik = new List<string>();
        List<string> Liste_Meslek = new List<string>();
        List<string> Liste_Telefon = new List<string>();
        List<string> Liste_Dtarihi = new List<string>();

        private void kaydetbox_Click(object sender, EventArgs e)
        {
            string deger = adbox.Text + " | " + soyadbox.Text + " | " + adresbox.Text
            + " | " + kimlikbox.Text + " | " + meslekbox.Text + " | " + telbox.Text;
            listBox1.Items.Add(deger);
            comboBox1.Items.Add(deger);

            Liste_Ad.Add(adbox.Text);
            Liste_Soyad.Add(soyadbox.Text);
            Liste_Adres.Add(adresbox.Text);
            Liste_Dtarihi.Add(dtarihibox.Text);
            Liste_Kimlik.Add(kimlikbox.Text);
            Liste_Meslek.Add(meslekbox.Text);
            Liste_Telefon.Add(telbox.Text);
        }

        private void temizlebox_Click(object sender, EventArgs e)
        {
            adbox.Clear();
            soyadbox.Clear();
            adresbox.Clear();
            dtarihibox.Clear();
            kimlikbox.Clear();
            meslekbox.Clear();
            telbox.Clear();
        }

        private void kayýtsilbox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void ekranýtemizle_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sorgubutton_Click(object sender, EventArgs e)
        {
            int sonuc = Liste_Ad.Where(abc => abc.Contains(sorgubox.Text)).Count();
            MessageBox.Show("Aradýðýnýz isimden listede " + sonuc + " adet bulunmaktadýr.");
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            sorgubox.Clear();
        }




    
        
    }
}















       

