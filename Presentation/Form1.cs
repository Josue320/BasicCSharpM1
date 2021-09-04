using Domainzzz;
using Domainzzz.Enums1;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {

        public int Count { get; set; }
        public AcademicLevel AcademicLevel { get; private set; }

        public EmpleadoModel empleadoModel;
        public Form1()
        {
            empleadoModel = new EmpleadoModel();
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string dni, names, lastnames;
            decimal wage;

            Rellenar();
            dni = txtDni.Text;
            lastnames = txtApellidos.Text;

            names = txtNombres.Text;
            Verificacion(names, lastnames, dni);
            if (!decimal.TryParse(txtSalario.Text, out wage) || wage<0)
            {
                MessageBox.Show($"Error, el salario:{txtSalario.Text} no tiene el formato correcto.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Empleado emp = new Empleado()
            {
                Id = ++Count,
                Dni = dni,
                Names = names,
                Lastnames = lastnames,
                Wage = wage,
                AcademicLevel = (AcademicLevel)cmbAcademicLevel.SelectedIndex,
                Genero = (Genero)cmbGenero.SelectedIndex

            };

            empleadoModel.Add(emp);


            MessageBox.Show($@"
                                Id: {emp.Id}
                                DNI: {emp.Dni}
                                Nombres:{emp.Names}
                                Apellidos: {emp.Lastnames}
                                Salario: {emp.Wage}
                               Count: {empleadoModel.GetEmpleados().Length}
                               Nivel Academico : {emp.AcademicLevel}
                                Genero : {emp.Genero}");
            ClearTextboxes();

        }
        private void ClearTextboxes()
        {
            txtDni.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtDni.Focus();
        }
        public void Verificacion(string nombres, string apellidos, string dni)
        {
            if (nombres.Length > 20)
            {
                MessageBox.Show($"Error, el nombre no puede tener mas de 20 caracteres",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;

            }
            if (apellidos.Length > 20)
            {
                MessageBox.Show($"Error, el apellido no puede tener mas de 20 caracteres",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return;
            }
            if (dni.Length > 16)
            {
                MessageBox.Show($"Error, el dni no puede tener mas de 16 caracteres",
                             "Mensaje de error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                return;
            }
        }
        private void Rellenar()
        {
            if(txtApellidos.Text == "" || txtDni.Text == "" || txtNombres.Text== "" || txtSalario.Text=="")
            {
                MessageBox.Show("Debe rellenar todos los campos.",
                               "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void ButtonSalario_Click(object sender, EventArgs e)
        {
            PrintInformacionMesage($"El Salario Máximo es: {empleadoModel.GetSalarioMaximo()}");
            
        }

        private void ButtonSalarioMin_Click(object sender, EventArgs e)
        {
            PrintInformacionMesage($"El Salario Mínimo es: {empleadoModel.GetSalarioMinimo()}");
        }

        private void ButtonSP_Click(object sender, EventArgs e)
        {
            PrintInformacionMesage($"El Salario Promedio es: {empleadoModel.GetSalarioPromedio()}");
        }
        private void PrintInformacionMesage(string message)
        {
            MessageBox.Show(message, "Mensaje de Información", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ButtonMay_Click(object sender, EventArgs e)
        {
            PrintInformacionMesage($"Los Salarios Mayores que el Promedio son: {empleadoModel.GetMayorPromedio()}");
        }

        private void GroupBoxDatos_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form2s f2 = new Form2s();
            this.Hide();
            f2.Show();
        }
    }
}
