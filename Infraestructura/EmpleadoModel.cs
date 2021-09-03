using Domainzzz;
using System;

namespace Infraestructura
{
    public class EmpleadoModel

    {
        private Empleado[] empleados;


        public EmpleadoModel() { }

        public void Add(Empleado empleado)
        {
            if (empleados == null)
            {
                empleados = new Empleado[1];
                empleados[0] = empleado;
                return;
            }
            Empleado[] tmp = new Empleado[empleados.Length + 1];
            Array.Copy(empleados, tmp, empleados.Length);
            tmp[tmp.Length - 1] = empleado;
            empleados = tmp;

        }

        public Empleado[] GetEmpleados()
        {
            return empleados;
        }

        public decimal GetSalarioMaximo()
        {
            decimal max = 0;
            foreach (Empleado e in empleados)
            {
                if(e.Wage > max)
                {
                    max = e.Wage;
                }
                
            }
            return max;
        }
        public decimal GetSalarioMinimo()
        {
            if (empleados == null)
            {
                return 0;
            }
            Array.Sort(empleados,EmpleadoSalarioComparer);
            return empleados[0].Wage;
        }
        #region Private method
        private int EmpleadoSalarioComparer(Empleado e1, Empleado e2)
        {
            if (e1 == null || e2 == null)
            {
                throw new ArgumentException("Error, los objetos no pueden ser null");
            }
            if(e1.Wage > e2.Wage)
            {
                return 1;
            }else if(e1.Wage < e2.Wage)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        #endregion
      public decimal GetSalarioPromedio()
        {
            decimal suma = 0M;
            foreach(Empleado e in empleados)
            {
                suma += e.Wage;
            }
            return (suma / empleados.Length);
        }
       public decimal GetMayorPromedio()
        {
            decimal[] salarioM = new decimal[10];
            int i = 0;
            foreach(Empleado e in empleados)
            {
                while(i > empleados.Length){ 
                     if(e.Wage > GetSalarioPromedio())
                     {
                         salarioM[i]= e.Wage;
                     }
                    i++;
                }

            }
            return salarioM[empleados.Length - 1];
        }
    }
}
