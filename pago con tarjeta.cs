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
    public partial class pago_con_tarjeta : Form
    {
        public pago_con_tarjeta()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su pago fue realizado correctamente", "Transferido");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btntrans.Enabled = true;
        }
    }
}
