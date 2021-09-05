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
        
        public bool Update(Producto producto)
        {
            bool success = false;
            int index = GetIndex(producto);
            if (index < 0)
            {
                throw new ArgumentException($"Error, producto con codigo {producto.Id} no existe.");
            }

            productos[index] = producto;
            return !success;
        }

        public bool Delete(Producto producto)
        {
            bool flag = false;
            int index = GetIndex(producto);
            if (index < 0)
            {
                throw new ArgumentException($"Error, producto con codigo {producto.Id} no existe.");
            }
            Producto[] tmp = new Producto[productos.Length - 1];
            productos[index] = productos[productos.Length - 1];
            Array.Copy(productos, tmp, productos.Length - 1);
            productos = tmp;

            return !flag;
        }
        public Producto[] GetProductos()
        {
            return productos;
        }

        public Producto FindById(int id)
        {
            int index = -1;
            if(productos != null){
                for (int i = 0; i < productos.Length; i++)
                {
                    if (productos[i].Id == id)
                    {
                        index = i;
                        break;
                    }
                }

                return index < 0 ? null : productos[index];
            }
            else
            {
                return null;
            }
        }

        public int GetIndex(Producto producto)
        {
            int index = -1, i = 0;
            foreach (Producto prod in productos)
            {
                if (prod.Id == producto.Id)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;
        }


    }
}
