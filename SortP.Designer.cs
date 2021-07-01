
namespace SortPlan
{
    partial class SortP
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tresultado = new System.Windows.Forms.TextBox();
            this.Nameb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sorteado = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(554, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "Salvar Nome";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantidade de vezes ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 23);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tresultado
            // 
            this.tresultado.Location = new System.Drawing.Point(499, 193);
            this.tresultado.Multiline = true;
            this.tresultado.Name = "tresultado";
            this.tresultado.Size = new System.Drawing.Size(200, 67);
            this.tresultado.TabIndex = 14;
            this.tresultado.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Nameb
            // 
            this.Nameb.Location = new System.Drawing.Point(18, 83);
            this.Nameb.Name = "Nameb";
            this.Nameb.Size = new System.Drawing.Size(164, 23);
            this.Nameb.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(479, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 80);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sortear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sorteio de Nomes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Digite o nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(509, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorteio";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Sorteado
            // 
            this.Sorteado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.Sorteado.FullRowSelect = true;
            this.Sorteado.GridLines = true;
            this.Sorteado.HideSelection = false;
            this.Sorteado.Location = new System.Drawing.Point(18, 128);
            this.Sorteado.Name = "Sorteado";
            this.Sorteado.Size = new System.Drawing.Size(164, 176);
            this.Sorteado.TabIndex = 22;
            this.Sorteado.UseCompatibleStateImageBehavior = false;
            this.Sorteado.View = System.Windows.Forms.View.Details;
            this.Sorteado.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nomes";
            this.columnHeader1.Width = 150;
            // 
            // SortP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 382);
            this.Controls.Add(this.Sorteado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tresultado);
            this.Controls.Add(this.Nameb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SortP";
            this.Text = "SortP";
            this.Load += new System.EventHandler(this.SortP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tresultado;
        private System.Windows.Forms.TextBox Nameb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView Sorteado;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}