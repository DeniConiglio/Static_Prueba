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
            Empleado emplea1 = new Empleado() {Nombre= "Martin", Apellido= "Lopez", Id= 1 };
            MessageBox.Show($"Nombre: {emplea1.Nombre} \nApellido: {emplea1.Apellido} \nId: {emplea1.Id} \nCOM: {Empleado.Comision.ToString()}");


            Empleado emplea2 = new Empleado(){ Nombre = "Felipe", Apellido = "Gonzales", Id=2 };
            Empleado.Comision = 101;
            MessageBox.Show($"Nombre: {emplea2.Nombre} \nApellido: {emplea2.Apellido} \nId: {emplea2.Id} \nCOM: {Empleado.Comision.ToString()}");

           

            Empleado.Comision = 105;


            Empleado emplea3 = new Empleado() { Nombre = "Joaquin", Apellido = "Gimenez", Id = 3 };
            Empleado.Comision = 104;
            MessageBox.Show($"Nombre: {emplea3.Nombre} \nApellido: {emplea3.Apellido} \nId: {emplea3.Id} \nCOM: {Empleado.Comision.ToString()}");

            Empleado emplea4 = new Empleado() { Nombre = "Gonzalo", Apellido = "Ortiz", Id = 4 };
            Empleado.Comision = 106;
            MessageBox.Show($"Nombre: {emplea4.Nombre} \nApellido: {emplea4.Apellido} \nId: {emplea4.Id} \nCOM: {Empleado.Comision.ToString()}");
        }
    }
}
