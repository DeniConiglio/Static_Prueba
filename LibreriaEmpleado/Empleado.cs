using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Empleado
    {
        public Empleado(string nombre, string apellido, int id)
        {
            Id = id;
            Nombre=nombre;
            Apellido=apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }

        private static int comision=100;

        public static int Comision
        {
            get { return comision; }
            set { comision = value; }
        }
    }
}
