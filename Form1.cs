using System;
using System.Windows.Forms;

namespace Calculadora_completa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public static class Global
        {
            public static int x, y, valor;
            public static String oper;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            btnZero.Text = "0";
            textBox2.Text += "0";
            textBox1.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {

            btnUm.Text = "1";
            textBox2.Text += "1";
            textBox1.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            btnDois.Text = "2";
            textBox2.Text += "2";
            textBox1.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            btnTres.Text = "3";
            textBox2.Text += "3";
            textBox1.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            btnQuatro.Text = "4";
            textBox2.Text += "4";
            textBox1.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            btnCinco.Text = "5";
            textBox2.Text += "5";
            textBox1.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            btnSeis.Text = "6";
            textBox2.Text += "6";
            textBox1.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            btnSete.Text = "7";
            textBox2.Text += "7";
            textBox1.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            btnOito.Text = "8";
            textBox2.Text += "8";
            textBox1.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            btnNove.Text = "9";
            textBox2.Text += "9";
            textBox1.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Global.x = int.Parse(textBox2.Text);
            textBox1.Text += " + ";
            Global.oper = "+";
            textBox2.Clear();

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            Global.x = int.Parse(textBox2.Text);
            textBox1.Text += " - ";
            Global.oper = "-";
            textBox2.Clear();

        }

        private void btnMultiplic_Click(object sender, EventArgs e)
        {
            Global.x = int.Parse(textBox2.Text);
            textBox1.Text += " * ";
            Global.oper = "*";
            textBox2.Clear();

        }

        private void btnDivis_Click(object sender, EventArgs e)
        {
            Global.x = int.Parse(textBox2.Text);
            textBox1.Text += " / ";
            Global.oper = "/";
            textBox2.Clear();

        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            Global.y = int.Parse(textBox2.Text);

            switch (Global.oper)
            {
                case ("+"):
                    Global.valor = Global.x + Global.y;
                    textBox1.Text += " = " + Global.valor;
                    textBox2.Clear();
                    textBox2.Text = Global.valor.ToString();
                    break;

                case ("-"):
                    Global.valor = Global.x - Global.y;
                    textBox1.Text += " = " + Global.valor;
                    textBox2.Clear();
                    textBox2.Text = Global.valor.ToString();
                    break;

                case ("*"):
                    Global.valor = Global.x * Global.y;
                    textBox1.Text += " = " + Global.valor;
                    textBox2.Clear();
                    textBox2.Text = Global.valor.ToString();
                    break;

                case ("/"):
                    Global.valor = Global.x / Global.y;
                    textBox1.Text += " = " + Global.valor;
                    textBox2.Clear();
                    textBox2.Text = Global.valor.ToString();
                    break;
            }
        }
        private void btnLimp_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
