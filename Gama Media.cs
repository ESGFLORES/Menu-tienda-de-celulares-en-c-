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
    public partial class Gama_Media : Form
    {
        public Gama_Media()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureGAmamedia.Image = Formulario_MenuStrip.Properties.Resources.REDMI_NOTE_8;
            lblgm.Text = "$ 280.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureGAmamedia.Image = Formulario_MenuStrip.Properties.Resources.GALAXY_M51;
            lblgm.Text = "$ 300.00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureGAmamedia.Image = Formulario_MenuStrip.Properties.Resources.HUAWEY_P40_LITE;
            lblgm.Text = "$ 360.00";
        }
    }
}
