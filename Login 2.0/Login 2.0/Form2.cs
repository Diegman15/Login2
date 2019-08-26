using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_2._0
{
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario formulario = new formulario();
            formulario.Visible = true;
        }

        private void BtComprar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if (CbVCs.Checked == true)
            {
                conteo++;
            }
            if (CbVB.Checked == true)
            {
                conteo++;
            }
            if (RbTC.Checked == true)
            {
                seleccion = "Tarjeta de Crédito";
            }
            else
            {
                seleccion = "PayPal";
            }
            MessageBox.Show("Has seleccionado " + conteo + " cursps y tu método de pago es " + conteo);

            
        }
    }
}
