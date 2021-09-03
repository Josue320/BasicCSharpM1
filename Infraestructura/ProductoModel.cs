using Domainzzz;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura
{
    public class ProductoModel
    {
        private Producto[] productos;
        public ProductoModel() { }
        public void AddProducto(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentException("Error, producto no puede ser null");
            }
            if (productos == null)
            {
                productos = new Producto[1];
                productos[0] = producto;
                return;
            }
            Producto[] Np = new Producto[productos.Length + 1];
            Array.Copy(productos, Np, productos.Length);
            Np[Np.Length - 1] = producto;
            productos = Np;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }


    }
}
