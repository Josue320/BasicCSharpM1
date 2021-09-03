using Domainzzz.Enums1;
using System;
using System.Collections.Generic;

namespace Domainzzz
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Names { get; set; }
        public string Lastnames { get; set; }
        public decimal Wage { get; set; }
        public AcademicLevel AcademicLevel { get; set; }
        public Genero Genero { get; set; }


        public class EmpleadoWageComparer : IComparer<Empleado>
        {
            public int Compare(Empleado x, Empleado y)
            {

                throw new NotImplementedException();
            }
        }


    }
}
