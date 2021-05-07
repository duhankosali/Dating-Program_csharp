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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==false)
            {
                MessageBox.Show("Lütfen Üyelik sözleşmesini okuyun ve onaylayınız.");
                this.Close();
            }
            Form2 f2 = new Form2();

            f2.Show();
            this.Hide();

            f2.label2.Text = textBox1.Text;
            f2.label4.Text = textBox2.Text;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Turkey") 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İstanbul");
                comboBox2.Items.Add("Ankara");
                comboBox2.Items.Add("İzmir");
            }

           else  if (comboBox1.Text=="England")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Manchester");
                comboBox2.Items.Add("Londra");
                comboBox2.Items.Add("Birmingham");
            }

            else if (comboBox1.Text == "USA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("New York");
                comboBox2.Items.Add("Florida");
                comboBox2.Items.Add("Cincinnati");
                comboBox2.Items.Add("Chicago");
            }
             else if (comboBox1.Text == "Germany")
             {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Berlin");
                 comboBox2.Items.Add("Hamburg");
                 comboBox2.Items.Add("Frankfurt");
             }

            else
            {
                MessageBox.Show("Lütfen bir ülke seçiniz.");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
  
            if (comboBox2.Text == "İstanbul")
            {
                f2.comboBox1.Items.Clear();
                f2.comboBox1.Items.Add("Kadıköy");
                f2.comboBox1.Items.Add("Ataşehir");
                f2.comboBox1.Items.Add("Beşiktaş");
            }

            else if (comboBox2.Text=="Ankara")
            {
                f2.comboBox1.Items.Clear();
                f2.comboBox1.Items.Add("Kızılay");
                f2.comboBox1.Items.Add("Çankaya");
                f2.comboBox1.Items.Add("Beypazarı");
            }

            else if (comboBox2.Text=="İzmir")
            {
                f2.comboBox1.Items.Clear();
                f2.comboBox1.Items.Add("Karşıyaka");
                f2.comboBox1.Items.Add("Göztepe");
                f2.comboBox1.Items.Add("Bornova");
            }

            else
            {
                MessageBox.Show("Lütfen bir şehir seçiniz!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            comboBox1.Items.Add("Turkey");
            comboBox1.Items.Add("England");
            comboBox1.Items.Add("Germany");
            comboBox1.Items.Add("USA");

            comboBox3.Items.Add("Erkek");
            comboBox3.Items.Add("Kadın");
        }
    }
}
