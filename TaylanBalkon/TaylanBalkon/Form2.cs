using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaylanBalkon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Kadıköy")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Sahilde bira sonra beyran");
                comboBox2.Items.Add("Şule ile Dorock XL'de bira");
                comboBox2.Items.Add("Dimooo");
                comboBox2.Items.Add("Caddeye akış");
            }

            else if (comboBox1.Text=="Beşiktaş")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Akaretlerde Fotoğraf");
                comboBox2.Items.Add("Maçka parkında bira");
                comboBox2.Items.Add("Palmiye'de Nargile");
            }

            else if (comboBox1.Text == "Ataşehir")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bulvar216'nın terasında takılma");
                comboBox2.Items.Add("Metropol AVM'de dolaşma");
                comboBox2.Items.Add("Watergarden'da havuz gösterisi izleme");
            }

            else
            {
                MessageBox.Show("Lütfen yapmak istediğiniz şekili seçiniz.");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas=0;
            yas = Convert.ToInt32(label4.Text);

            if (yas<18)
            {
                switch (comboBox2.Text)
                {
                    case "Sahilde bira sonra beyran":
                    default:
                        break;
                }
            }
        }
    }
}
