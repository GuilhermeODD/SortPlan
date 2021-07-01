using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SortPlan
{
    public partial class Sorteio : Form
    {
        public Sorteio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("Erro adicione a quantidade a ser sorteada", "Erro"); }
            else
            {
                Random Rdm = new Random();
            int min = Convert.ToInt32(textBox1.Text);
            int max = Convert.ToInt32(textBox2.Text);
            int qnt = Convert.ToInt32(textBox4.Text);
            int sort;
            int[] VV = new int[100];
            string res = "";
            
             
            for (int s = 0; s<=qnt -1; s++)
            {

                init:
                sort = Rdm.Next(min, max + 1);

                for(int a = 0; a <= qnt - 1; a++)
                {
                    if(VV[a] == sort)
                    {
                        goto init;
                    }
                }
                res = res + "" + sort;
                textBox3.Text = res;
                VV[s] = sort;
            }
            }


        }

        private void Sorteio_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortP sort = new SortP();
            this.Hide();
            sort.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
