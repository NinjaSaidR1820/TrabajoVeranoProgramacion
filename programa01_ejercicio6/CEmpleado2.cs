using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa01_ejercicio6
{
    public class CEmpleado2
    {
        private double sueldo;
        private double impuesto;
        private string log; 

        public string Log { get; set; }



        public void setSueldo(double psueldo)
        {

            if(psueldo < 5000 || psueldo > 15000)
            {

                LogError("Monto Ilegal: "+psueldo.ToString() );
            }else 
                sueldo = psueldo;



        }

        public double getSueldo(int pPassword)
        {

            if (pPassword != 123456)
            {
                LogError("Monto Ilegal");
                return 0.0;
            }
            else 
                return sueldo;
        }

        public double getImpuesto(int pPassword)
        {
            if(pPassword != 123456)
            {
                LogError("Monto Ilegal");
                return 0.0;
            }
            else
                return impuesto;

        }

        public void CalcularImpuesto()
        {

            impuesto = sueldo * 0.16;
        }

        public void LogError(string pError)
        {

            log += pError = "\r\n";
        }



    }
}
