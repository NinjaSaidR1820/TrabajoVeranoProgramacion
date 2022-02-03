using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa01_ejercicio6
{
    public partial class xD : Form
    {
        public xD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo = 0.0, impuesto = 0.0;

            string LOG;



            CEmpleado2 c = new CEmpleado2();

            LOG = c.Log;

            c.setSueldo(1234487);

            
           
            sueldo = c.getSueldo(Convert.ToInt32(LOG));

            c.CalcularImpuesto();

            impuesto = c.getImpuesto(Convert.ToInt32(LOG));


            MessageBox.Show("Sueldo: "+sueldo+ "\r\n impuesto: "+impuesto);



        }

      
    }
}
