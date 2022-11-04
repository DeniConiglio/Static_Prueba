using LibreriaEmpleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarCom_Click(object sender, EventArgs e)
        {
            Empleado emplea1 = new Empleado("Martin", "Lopez", 123);
            MessageBox.Show($"{Empleado.Comision.ToString()}");


            Empleado emplea2 = new Empleado("Felipe", "Gonzales", 321);
            Empleado.Comision = 101;
            MessageBox.Show($"{Empleado.Comision.ToString()}");

           

            Empleado.Comision = 105;
            MessageBox.Show($"{Empleado.Comision.ToString()}");
        }
    }
}
