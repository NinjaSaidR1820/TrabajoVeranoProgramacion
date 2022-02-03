using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoCursoProgramacion.Clases
{
    public class CEmpleado
    {
        private double sueldo;
        private double impuesto;


        public void setSueldo(double psueldo)
        {

            sueldo = psueldo;

        }

        public double getSueldo()
        {
            return sueldo;
        }

        public double getImpuesto()
        {

            return impuesto;
        }

        public void CalcularImpuesto()
        {

            impuesto = sueldo * 0.16;
        }

    }
}
