using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoCursoProgramacion.Clases;

namespace TrabajoCursoProgramacion
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
            

        }
        double sueldo = 10000.50;


        private void button1_Click(object sender, EventArgs e)
        {
            double impuesto = 0.0;
            double sueldo = 0.0;




            CEmpleado Juan = new CEmpleado();

            Juan.setSueldo(10000.0);

            sueldo = Juan.getSueldo();

            Juan.CalcularImpuesto();


            impuesto = Juan.getImpuesto();

            MessageBox.Show("Impuesto: " + impuesto.ToString()+
                "\r\n Sueldo: "+sueldo.ToString());
            

        }

       

    }
}
