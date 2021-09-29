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
using System.Data.SqlClient;




namespace Formulario_MenuStrip
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                if (textBox1.Text == "usuario1" || textBox2.Text == "clave1")
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
                fusuario1 f1 =  new fusuario1();
                f1.Show();
                this.Hide();
            

            
             
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
                fusuario2 f2 = new fusuario2();
                f2.Show();
                this.Hide();
           
            
            try
            {
                //Creado la variable para la nueva conexion
                //Proyecto de Acceso a Base de Datos Access
                
               OleDbConnection conexion_access = new OleDbConnection();
                //Cadena de conexión para la base de datos
                //Se recomienda generar la cadena de conexion para evitar errores
                //conexion_access.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data 
                //Source = C:\sistema.accdb; Persist Security Info = False; ";
                conexion_access.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Sistema\sistema.accdb";
                //Abriendo conexion

                conexion_access.Open();
                //Consulta a tabla de usuarios en la base de datos
                //Para encontrar fila que tiene los datos del usuario y clave ingresados
                OleDbDataAdapter consulta = new OleDbDataAdapter("SELECT * FROM tusuario",
                conexion_access);
                //OleDbDataReader reader = command.ExecuteReader();
                DataSet resultado = new DataSet();
                consulta.Fill(resultado);
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    if ((textBox1.Text == registro["nombre"].ToString()) && (textBox2.Text ==
                    registro["clave"].ToString()))
                    {
                        //llamando formulario principal llamado menu
                        Dialogos fm = new Dialogos();
                        fm.Show(); //abrir menu
                        this.Hide();//ocultar el formulario de login
                    }
                } //Cierre de ciclo for
                  //Finalizando la conexión
                conexion_access.Close();
            } //Cierre de Try
              //Si la conexion falla muestra mensaje de error
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                //en caso que usuario y clave sean incorrectos mostrar mensaje de error
                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textBox1.Focus();
            }
            
        }


    }

}


