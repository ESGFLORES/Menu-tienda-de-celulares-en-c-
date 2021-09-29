using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Formulario_MenuStrip
{
    public partial class fusuario1 : Form
    {
        public fusuario1()
        {
            InitializeComponent();
        }
        SqlConnection conex = new SqlConnection("server=LAPTOP-FLORES-H;database= tusuario; integrated security = true");

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fusuario1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bSQmenuprincipal_Click(object sender, EventArgs e)
        {
            conex.Open();
            string consult = "select * from usuarios where usuarios ='" + txtusuariof1.Text + "'and pass= '" + txtclavef1.Text + "'";
            SqlCommand comand = new SqlCommand(consult,conex);
            SqlDataReader lector;
            lector = comand.ExecuteReader();
            
            if (lector.HasRows==true)
            {
                MessageBox.Show("Bienvenido");

            }
            else
            {
                MessageBox.Show(" usuario o contraseña incorrectos");
            }
            conex.Close();
        }
    }
}
