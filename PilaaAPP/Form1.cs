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

        Stack<int> pila = new Stack<int>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerTope_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            { 
                
                  = pila.Peek();
                lblPila.Text = " Ultimo de la pila: ";
            }
            else
            {
                lblPila.Text = "La pila está vacía.";
            }


        }


        private void ActualizarListBox()
        {
            
            lbResultados.Items.Clear();
            foreach ()
            {
               
                lbResultados.Items.Add(emp);
            }
        }

    }
}
