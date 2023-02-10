using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ai_Saldumi_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Saldumi_daudzums_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Saldumi_aprekinat_button_Click(object sender, EventArgs e)
        {
            aprekinasana_kopa(0);
            aprekinasana_kiegelitis(0);
            aprekinasana_jura(0);
            aprekinasana_specialas(0);
        } 
        void aprekinasana_kopa(double daudzums_kopa)
         {
            double kiegelitis_kopa;
            double jura_kopa;
            double specialas_kopa;

            aprekinasana_kiegelitis(0);
            aprekinasana_jura(0);
            aprekinasana_specialas(0);
            kiegelitis_kopa = Convert.ToDouble(rezultats_kiegelitis_textbox.Text);
            jura_kopa = Convert.ToDouble(rezultats_jura_textbox.Text);
            specialas_kopa = Convert.ToDouble(rezultats_specialas_textbox.Text);
            daudzums_kopa = kiegelitis_kopa + jura_kopa + specialas_kopa;
            this.kopa_rezultats_textbox.Text = daudzums_kopa.ToString();
        }
            void aprekinasana_kiegelitis(double Kiegelitis_daudzums)
            {
            if (kiegelitis_nauda_textbox.Text == "" || kiegelitis_nauda_textbox.Text == null || kiegelitis_nauda_textbox.Text == " ")
            {
                Kiegelitis_daudzums = 0;
                this.rezultats_kiegelitis_textbox.Text = Kiegelitis_daudzums.ToString();
            }
            else
            {
                double Naudas_daudzums_eur = Convert.ToDouble(this.kiegelitis_nauda_textbox.Text);
                Kiegelitis_daudzums = Naudas_daudzums_eur / 5;
                Kiegelitis_daudzums = Math.Round(Kiegelitis_daudzums, 2);
                this.rezultats_kiegelitis_textbox.Text = Kiegelitis_daudzums.ToString();
            }
            }
            void aprekinasana_jura(double Jura_daudzums)
            {
            if (jura_nauda_textbox.Text == "" || kiegelitis_nauda_textbox.Text == null || kiegelitis_nauda_textbox.Text == " ")
            {
                Jura_daudzums = 0;
                this.rezultats_jura_textbox.Text = Jura_daudzums.ToString();
            }
            else
            {
                double Naudas_daudzums_eur = Convert.ToDouble(this.jura_nauda_textbox.Text);
                Jura_daudzums = Naudas_daudzums_eur / 10;
                Jura_daudzums = Math.Round(Jura_daudzums, 2);
                this.rezultats_jura_textbox.Text = Jura_daudzums.ToString();
            }
        }
            void aprekinasana_specialas(double Specialas_daudzums)
            {
            if (specialas_nauda_textbox.Text == "" || kiegelitis_nauda_textbox.Text == null || kiegelitis_nauda_textbox.Text == " ")
            {
                Specialas_daudzums = 0;
                this.rezultats_specialas_textbox.Text = Specialas_daudzums.ToString();
            }
            else
            {
                double Naudas_daudzums_eur = Convert.ToDouble(this.specialas_nauda_textbox.Text);
                Specialas_daudzums = Naudas_daudzums_eur / 20;
                Specialas_daudzums = Math.Round(Specialas_daudzums, 2);
                this.rezultats_specialas_textbox.Text = Specialas_daudzums.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kiegelitis_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
