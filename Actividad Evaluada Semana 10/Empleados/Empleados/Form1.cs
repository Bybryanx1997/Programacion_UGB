using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {

        Empleados Empleado = new Empleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            


            if (txtNombre.Text == "") 
            {
                errorProvider1.SetError(txtNombre, "No ingresó el nombre");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");

            if (txtDUI.Text == "")
            {
                errorProvider1.SetError(txtDUI, "No ingresó el DUI");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");


            double Salario;

            if (!double.TryParse(txtSalario.Text, out Salario))

            {
                errorProvider1.SetError(txtSalario, "No ingresó el salario de forma correcta");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(txtSalario, "");


            
            Empleado.Nombre = txtNombre.Text;
            Empleado.Dui = txtDUI.Text;
            Empleado.Salario = Convert.ToDouble(txtSalario.Text);
            txtAFP.Text = Empleado.AFP(Empleado.Salario).ToString();
            labelRegistro.Text = "¡Registro guardado!";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btAFP_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
                conexion.Open();
                string nombre = txtNombre.Text;
                string dui = txtDUI.Text;
                string salario = txtSalario.Text;
                string afp = txtAFP.Text;
                string cadena = "insert into [Table] (Nombre, DUI, Salario, AFP) values ('" + nombre + "','" + dui + "','" + salario + "','" + afp + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");

                conexion.Close();

            

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();
            string cod = textBox1.Text;
            string cadena = "select Nombre, DUI from [Table] where Id=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                lbname.Text = registro["Nombre"].ToString();
                lbDUI.Text = registro["DUI"].ToString();
            }
            else
                MessageBox.Show("No existe un Empleado con el código ingresado");
            conexion.Close();

        }

        private void lbDUI_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
