using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MenuStrip
{
    public partial class Gama_alta : Form
    {
        public Gama_alta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureGamaalta.Image = Formulario_MenuStrip.Properties.Resources.Galaxy_s21_ultra;
            label2.Text = "$ 1,549.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureGamaalta.Image = Formulario_MenuStrip.Properties.Resources.iphone_12_pro_max;
            label2.Text = " $ 1,250.00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureGamaalta.Image = Formulario_MenuStrip.Properties.Resources.Xiaomi__Mi_11_Ultra;
            label2.Text = "$ 500.00";
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }
    }
    }

