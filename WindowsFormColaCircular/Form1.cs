using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormColaCircular
{
    public partial class Form1 : Form
    {
        Cola cola;
        public Form1()
        {
            cola = new Cola(4);
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (txtdato.Text == "")
            {
                MessageBox.Show("Digite un valor");

            }
            else
            {
                cola.InsertarItem(txtdato.Text);
                ListarELementos();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            cola.EliminarItem();
            ListarELementos();
        }

        private void btnvaciar_Click(object sender, EventArgs e)
        {
            //de tarea
        }
        public void ListarELementos()
        {
            colalista.Items.Clear();
            string[] elemento = cola.Elementos();
            for (int i=0; i< elemento.Length; i++)
            {
                colalista.Items.Add("["+i+"] => "+ elemento[i]);
            }
        }
    }
}
