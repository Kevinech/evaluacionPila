using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaaAPP.Parte2
{
    public class Metodos2
    {

        public void MostrarUltimo()
        {
            try
            {

                pila.Peek();

                int elemento = pila.Peek();


                lblPila.Text = "Ultimo elemento ingresado: " + elemento.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Pila vacía",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        return pila



    }
}
