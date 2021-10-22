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
    public partial class Dialogos : Form
    {
        public Dialogos()
        {
            InitializeComponent();
        }

        private void menu1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 f2 = new AboutBox1();
            f2.ShowDialog();

        }

        private void ayudaToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ayuda ayuda = new ayuda();
            ayuda.ShowDialog();
        }

        private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gama_alta celulares = new Gama_alta();
            celulares.ShowDialog();
        }

        private void cuadrosDeDialogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mensajes mensajes = new Mensajes();
            mensajes.ShowDialog();
        }

        private void Dialogos_Load(object sender, EventArgs e)
        {
            
        }

        private void oPcion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gama_Media gama_Media = new Gama_Media();
            gama_Media.ShowDialog();
        }

        private void opcion3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureGama_baja gama_Baja= new pictureGama_baja();
            gama_Baja.ShowDialog();
        }

        private void menu1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sucursales sucursales = new Sucursales();
            sucursales.ShowDialog();
        }

        private void oPcion1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pago_con_tarjeta pago_Con_Tarjeta = new pago_con_tarjeta();
            pago_Con_Tarjeta.ShowDialog();
        }

        private void opcion1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Envios_a_Domicilio envios_A_Domicilio = new Envios_a_Domicilio();
            envios_A_Domicilio.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
            Login principal = new Login();
            principal.Show();
            this.Hide();

        }
        private void opcion2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Envios_internacionales envios = new Envios_internacionales();
            envios.ShowDialog();
        }
    }
}
