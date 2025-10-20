using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaaAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Metodo para agregar elementos: Nombre, apellidos, cargo y salario

            Stack<string> pilaEmpleados = new Stack<string>();
            string nombre = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string cargo = tbCargo.Text;
            string salario = tbSalario.Text;
            string empleado = $"Nombre: {nombre}, Apellidos: {apellidos}, Cargo: {cargo}, Salario: {salario}";
            pilaEmpleados.Push(empleado);
            lbResultados.Items.Add(empleado);


        }

        private void btnVerTope_Click(object sender, EventArgs e)
        {
            //Metodo para ver el tope de la listbox
            lbResultados.Items.Clear();
            lbResultados.Items.Add("Tope de empleados alcanzado.");



        }

        private void lbResultados_SelectedIndexChanged(object sender, EventArgs e)
        {


            //Crear la pila
             Stack<string> pilaEmpleados = new Stack<string>();
            //Agregar elementos a la pila
            pilaEmpleados.Push("Empleado 1: Juan Perez");
            pilaEmpleados.Push("Empleado 2: Maria Lopez");
            pilaEmpleados.Push("Empleado 3: Carlos Sanchez");
            //Mostrar el elemento en la cima de la pila
            if (pilaEmpleados.Count > 0)
            {
                string empleadoCima = pilaEmpleados.Peek();
                MessageBox.Show($"Empleado en la cima de la pila:\n{empleadoCima}");
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Metodo para eliminar un elemento de la pila
            if (lbResultados.Items.Count > 0)
            {
                lbResultados.Items.RemoveAt(lbResultados.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("No hay empleados para eliminar.");
            }

        }
    }
}
