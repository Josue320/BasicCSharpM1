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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form3 F3 = new Form3();
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int id, Cantidad;
            decimal precio;
            String Nombre, Descripcion ;
            id = Int32.Parse(txtId.Text);
            Cantidad = Int32.Parse(txtCantidad.Text);
            Nombre = txtNombre.Text;
            Descripcion = txtDescripcion.Text;
            precio = Int32.Parse(txtPrecio.Text);
            DateTime Caducidad;
            

            if (Nombre == "")
            {
                MessageBox.Show("Debe llenar la caja de texto con su Nombre.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Descripcion == "")
            {
                MessageBox.Show("Debe llenar la caja de texto con su Nombre.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Cantidad < 0 )
            {
                MessageBox.Show("Tiene que ingresar un numero negativo",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (precio < 0)
            {
                MessageBox.Show("Tiene que ingresar un numero negativo",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Verificacion(Nombre, Descripcion, id);
        }
        public void Verificacion(string nombre, string descripcion, int id)
        {
            if (nombre.Length > 20)
            {
                MessageBox.Show($"Error, el nombre no puede tener mas de 20 caracteres",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            if (descripcion.Length > 30)
            {
                MessageBox.Show($"Error, la descripcion es muy larga no puede tener mas de 30 caracteres",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            if (id == null)
            {
                MessageBox.Show("Debe llenar la caja de texto con un Id para el producto.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (id is string)
            {
                MessageBox.Show($"Error, el ID:{txtId.Text} no tiene el formato correcto.",
                           "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            F3.Show();
        }
    }
}
