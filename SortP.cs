using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SortPlan
{
    public partial class SortP : Form
    {

        public SortP()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SortP_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nameb.Text) || string.IsNullOrWhiteSpace(Nameb.Text))
            {
                MessageBox.Show("Escreva algum nome", "Irregular ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Sorteado.Items.Add(Nameb.Text);
                Nameb.Clear();
                groupBox1.Enabled = true;

            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpar o valor do resultado 
            tresultado.Clear();
            Random rw = new Random();
            int qnt = Convert.ToInt32(textBox4.Text);
            string sorteado;
            string[] VV = new string[100];
            for (int s = 0; s <= qnt - 1;)
            {
                init:
                sorteado = Sorteado.Items[rw.Next(0, Sorteado.Items.Count - 1)].Text; //faz o sorteio
                VV[s] = sorteado;  //coloca o valor do numero sorteado na variavel

                for (int a = 0; a <= qnt - 1;)  //percorrer os valores da variavel
                {
                    if (VV[a] == sorteado) {  //ve se o valor da variavel e igual ao sorteado
                        if (a != s)  //ve se o numero do indice da variavel é diferente do numero da variavel principal  (senão fica no loop)
                        {
                            goto init;  //e igual escolhe outro
                        }
                    }
                    a = a + 1;  //aumenta do valor de a
                } 
                    tresultado.Text = tresultado.Text + " " + sorteado;  //preenche a variavel

                //aumenta o valor de s
                s = s + 1;
            }
        }
    }
}

