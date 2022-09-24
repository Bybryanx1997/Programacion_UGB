using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_de_registro
{
    public partial class Form1 : Form
    {
        Empleados Empleado = new Empleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textafp_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btafp_Click(object sender, EventArgs e)
        {
            textafp.Text = Empleado.AFP(Empleado.Salario).ToString();
        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void btguardar_Click_1(object sender, EventArgs e)
        {
            int ID;

            if (!int.TryParse(textid.Text, out ID))

            {
                errorProvider1.SetError(textid, "No ingresó un ID válido");
                textname.Focus();
                return;
            }
            errorProvider1.SetError(textid, "");

            if (textname.Text == "")
            {
                errorProvider1.SetError(textname, "No ingreso el nombre");
                textname.Focus();
                return;
            }

            errorProvider1.SetError(textname, "");

            if (textdui.Text == "")
            {
                errorProvider1.SetError(textdui, "No ingreso el DUI");
                textname.Focus();
                return;
            }

            errorProvider1.SetError(textname, "");

            double Salario;

            if (!double.TryParse(textsalario.Text, out Salario))

            {
                errorProvider1.SetError(textsalario, "No ingresó el salario de forma correcta");
                textsalario.Focus();
                return;
            }
            errorProvider1.SetError(textid, "");


            Empleado.Id = Convert.ToInt32(textid.Text);
            Empleado.Nombre = textname.Text;
            Empleado.Dui = textdui.Text;
            Empleado.Salario = Convert.ToDouble(textsalario.Text);
            labelRegistro.Text = "¡Registro guardado!";

    

        }
        private void label1_Click_5(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Empleado.ISSS(Empleado.Salario).ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Empleado.neto(Empleado.Salario, Empleado.ISSS(Empleado.Salario), Empleado.AFP(Empleado.Salario)).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
