using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Formulario_MenuStrip
{
    public partial class fusuario2 : Form
    {
        public fusuario2()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fusuario2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.tusuario' Puede moverla o quitarla según sea necesario.
            this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);

        }
    }
}
