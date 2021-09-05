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
    public partial class Form2s : Form
    {
        public ProductoModel productoModel;
        public Form2s()
        {
            productoModel = new ProductoModel();
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BtnBuscarF2_Click(object sender, EventArgs e)
        {
            int id;
            if (!Int32.TryParse(txtBusqueda.Text, out id) || id<=0)
            {
                MessageBox.Show($"Error, el Id:{txtId.Text} no tiene el formato correcto.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Producto p = new Producto();
            p = productoModel.FindById(id);
            if (p == null)
            {
                MessageBox.Show($"Error, el producto con Id:{txtBusqueda.Text} no existe.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MostrarProducto(p);
            }
            ClearTextboxes();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int id,cantidad;
            DateTime caducidad;
            string nombre, descripcion;
            decimal precio;
            Rellenar();
            if (!Int32.TryParse(txtId.Text, out id) || id<=0)
            {
                MessageBox.Show($"Error, el Id:{txtId.Text} no tiene el formato correcto.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show($"Error, el Precio:{txtPrecio.Text} no tiene el formato correcto.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show($"Error, la cantidad:{txtCantidad.Text} no tiene el formato correcto.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DateTime.TryParse(txtFecha.Text, out caducidad))
            {
                MessageBox.Show($"Error, la fecha:{txtFecha.Text} no tiene el formato correcto.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            caducidad = DateTime.Parse(txtFecha.Text);
            nombre = txtNombre.Text;
            descripcion = txtDescripcion.Text;
            Producto p = new Producto()
            {
                Name = nombre,
                Description = descripcion,
                Quantity = cantidad,
                Caducity = caducidad,
                Price = precio,
                Id = id,
                unidadMedida = (UnidadMedida)Enum.GetValues(typeof(UnidadMedida)).GetValue(cmbUnidadMedida.SelectedIndex)
            };
            productoModel.AddProducto(p);
            MostrarProducto(p);
            ClearTextboxes();
           
        }
        private void ClearTextboxes()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtBusqueda.Text = string.Empty;
            txtId.Focus();
        }
        private void Rellenar()
        {
            if (txtNombre.Text == "" || txtId.Text == "" || txtPrecio.Text == "" || txtDescripcion.Text == "" || txtFecha.Text=="" || txtCantidad.Text=="")
            {
                MessageBox.Show("Debe rellenar todos los campos.",
                               "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void MostrarProducto(Producto producto)
        {
            string text = $@"Id:{producto.Id} 
                          Nombre:{producto.Name}
                     Descripcion:{producto.Description}
                        Cantidad:{producto.Quantity}
                          Precio:{producto.Price}
                       Caducidad:{producto.Caducity}";
            MessageBox.Show(text, "Mensaje de informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        
    }
}
