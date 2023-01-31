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
            double Naudas_daudzums_eur = Convert.ToDouble(this.Nauda_daudzums_textbox.Text);
            double Rezultats_eur = 0;
            Rezultats_eur = Naudas_daudzums_eur / 9.88;
            Rezultats_eur = Math.Round(Rezultats_eur, 2);
            this.Saldumi_rezultats_textbox.Text = Rezultats_eur.ToString();
        }
    }
}
