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
    public partial class pictureGama_baja : Form
    {
        public pictureGama_baja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureGamabaja.Image = Formulario_MenuStrip.Properties.Resources.MOTO_G9_PLAY;
            lbmgb.Text = "$ 259.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureGamabaja.Image = Formulario_MenuStrip.Properties.Resources.GALAXY_A02s;
            lbmgb.Text = "$ 169.00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureGamabaja.Image = Formulario_MenuStrip.Properties.Resources.HUAWEY_Y7_PRIME;
            lbmgb.Text = "$ 239.00";
        }
    }
    }

