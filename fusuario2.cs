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
        //   Crear la variable…….para la conexión
        public OleDbConnection miconexion;

        //   Crear la variable…….para saber cuál actualizar
        public string usuario_modificar;
        public fusuario2()
        {
            //Crear cadena de conexion a la base
            miconexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Sistema\sistema.accdb ");

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

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.Enabled = false;

            this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveFirst();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MovePrevious();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveNext();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "Seleccione nivel";
            textBox1.Focus();
            button2.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            
                OleDbCommand guardar = new OleDbCommand();
                miconexion.Open();
                guardar.Connection = miconexion;
                guardar.CommandType = CommandType.Text;

                guardar.CommandText = "INSERT INTO tusuario ([Nombre], [Clave], [Nivel])Values(" + textBox1.Text.ToString() + ", " + 
                    textBox2.Text.ToString() + "," + comboBox1.Text.ToString() + ")";

                guardar.ExecuteNonQuery();
                miconexion.Close();

                button2.Visible = true;
                button3.Visible = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                comboBox1.Enabled = false;
                button2.Focus();

                MessageBox.Show("Usuario agregado con éxito", "Ok",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);
                this.tusuarioBindingSource.MoveLast();
                }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox1.Enabled = true;
            textBox1.Focus();
            button7.Visible = false;
            button8.Visible = true;

            usuario_modificar = textBox1.Text.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;

                string nombre = textBox1.Text.ToString();
                string clave = textBox2.Text.ToString();
                string nivel = comboBox1.Text;

                actualizar.CommandText = "UPDATE tusuario SET nombre = " + nombre + ", clave = " +
                    clave + ", nivel = " + nivel + "WHERE nombre = " + usuario_modificar + "";

                actualizar.ExecuteNonQuery();
                miconexion.Close();

                button7.Visible = true;
                button8.Visible = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                comboBox1.Enabled = false;

                MessageBox.Show("Usuario actualizado con éxito", "Ok",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand eliminar = new OleDbCommand();
                miconexion.Open();
                eliminar.Connection = miconexion;
                eliminar.CommandType = CommandType.Text;

                eliminar.CommandText = "DELETE FROM tusuario WHERE nombre = " + 
                    textBox1.Text.ToString() + "";

                eliminar.ExecuteNonQuery();
                this.tusuarioBindingSource.MoveNext();
                miconexion.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tusuarioBindingSource.MovePrevious();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "usuario1" || textBox2.Text == "usuario1" || comboBox1.Text == "1"
                || textBox1.Text == "usuario2" || textBox2.Text == "usuario2" || comboBox1.Text == "2"
                || textBox1.Text == "usuario3" || textBox2.Text == "usuario3" || comboBox1.Text == "3")
            {
                Dialogos principal = new Dialogos();
                principal.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Error de usuario o clave de acceso", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveFirst();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MovePrevious();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveNext();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveLast();
        }
    }
}
