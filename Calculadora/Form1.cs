using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private bool activarM = false;
        private bool activarD = false;
        private bool activarS = false;
        private bool activarR = false;
        private double total = 0;
        private int valor1 = 0;
        private int valor2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
                txtPantalla.Text = Convert.ToString(Convert.ToString(txtPantalla.Text)+"1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = Convert.ToString(Convert.ToString(txtPantalla.Text)+"2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = Convert.ToString(Convert.ToString(txtPantalla.Text) + "3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = Convert.ToString(Convert.ToString(txtPantalla.Text) + "4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = Convert.ToString(Convert.ToString(txtPantalla.Text) + "5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = Convert.ToString(Convert.ToString(txtPantalla.Text) + "6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = Convert.ToString(Convert.ToString(txtPantalla.Text) + "7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = Convert.ToString(Convert.ToString(txtPantalla.Text) + "8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = Convert.ToString(Convert.ToString(txtPantalla.Text) + "9");
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = Convert.ToString(Convert.ToString(txtPantalla.Text) + "0");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                valor1 = Convert.ToInt32(txtPantalla.Text);
                txtPantalla.Text = "";
                activarM = true;
            }
            else
            {
                txtPantalla.Text = "";
            }
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                valor1 = Convert.ToInt32(txtPantalla.Text);
                txtPantalla.Text = "";
                activarD = true;
            }
            else
            {
                txtPantalla.Text = "";
            }

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                valor1 = Convert.ToInt32(txtPantalla.Text);
                txtPantalla.Text = "";
                activarR = true;
            }
            else
            {
                txtPantalla.Text = "";
            }

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                valor1 = Convert.ToInt32(txtPantalla.Text);
                txtPantalla.Text = "";
                activarS = true;
            }
            else
            {
                txtPantalla.Text = "";
            }

        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (activarM)
            {
                valor2 = Convert.ToInt32(txtPantalla.Text);
                total = valor1 * valor2;
                txtPantalla.Text = Convert.ToString(total);
                activarM = false;
            }
            if (activarD)
            {
                valor2 = Convert.ToInt32(txtPantalla.Text);
                if (valor2 != 0)
                {
                    total = valor1 / valor2;
                    txtPantalla.Text = Convert.ToString(total);
                    activarD = false;
                }
                else
                {
                    txtPantalla.Text = "Error..";
                }
                
            }
            if (activarS)
            {
                valor2 = Convert.ToInt32(txtPantalla.Text);
                total = valor1 + valor2;
                txtPantalla.Text = Convert.ToString(total);
                activarS = false;
            }
            if (activarR)
            {
                valor2 = Convert.ToInt32(txtPantalla.Text);
                total = valor1 - valor2;
                txtPantalla.Text = Convert.ToString(total);
                activarR = false;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
            total = 0;
            valor1 = 0;
            valor2 = 0;
        }
    }
}
