using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Formulario_MenuStrip
{
    public partial class fconsultas : Form
    {
        public string conexion_cadena = "Database=misempleados;Data Source=localhost;User Id=admin;Password=admin";
        public fconsultas()
        {
            InitializeComponent();
        } 

        private void fconsultas_Load(object sender, EventArgs e)
        {

            try
            {
                string consulta = "SELECT * FROM empleados";
                MySqlConnection conexion = new MySqlConnection(conexion_cadena);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "misempleados");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "misempleados";
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string consult = "SELECT * From empleados WHERE idempleado = " + textBox1.Text + "";
                MySqlConnection coneccion = new MySqlConnection(conexion_cadena);
                MySqlDataAdapter comand = new MySqlDataAdapter(consult, coneccion);

                System.Data.DataSet ds = new System.Data.DataSet();

                comand.Fill(ds, "misempleados");

                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "misempleados";

                MySqlConnection myConnetion = new MySqlConnection(conexion_cadena);
                string myInsertQuery = "select * from empleados where idempleado = " + textBox1.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnetion);

                myCommand.Connection = myConnetion;
                myConnetion.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    MessageBox.Show("Usuario encontrado con éxito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myReader.Close();
                myConnetion.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda esta vacio", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
      

    private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
