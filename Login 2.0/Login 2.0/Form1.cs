﻿using System;
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
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra formulario
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {
            if (TbNombre.Text == "juancho" && TbContra.Text == "123tamarindo")
            {
                MessageBox.Show("Bienvenido Sr Juancho");
                this.Hide();
                ventana2 CursosVentana = new ventana2();
                CursosVentana.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no valido");
                TbNombre.Text = "";
                TbContra.Text = "";
                TbNombre.Focus();
            }
        }

        private void TbContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
            {
                if (TbNombre.Text == "juancho" && TbContra.Text == "123tamarindo")
                {
                    MessageBox.Show("Bienvenido Sr Juancho");
                    this.Hide();
                    ventana2 CursosVentana = new ventana2();
                    CursosVentana.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña no valido");
                    TbNombre.Text = "";
                    TbContra.Text = "";
                    TbNombre.Focus();
                }
            }
        }
    }
}
