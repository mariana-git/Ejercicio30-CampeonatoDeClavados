using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio30_CampeonatoDeClavados
{
    public partial class Form1 : Form

    {
        private int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbDatos.Visible = false;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //valido que hayan cargado la cantidad de participantes
            if (!(txtCantidad.Text == string.Empty))
            {
                n = Convert.ToInt32(txtCantidad.Text);
                txtCantidad.Enabled = false;
                gbDatos.Visible = true;
                lblParticipante.Text = "Participante Nº 1";

            }
            else MessageBox.Show("Debe ingresar la cantidad de participantes");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox) control.Text = "";
                if (control is GroupBox)
                {
                    foreach (Control controlGrup in control.Controls)
                    {
                        if (controlGrup is TextBox) controlGrup.Text = "";
                        if (controlGrup is ListBox) ((ListBox)controlGrup).Items.Clear();
                    }
                }
            }
            txtCantidad.Enabled = true;
            gbDatos.Visible = false;
            txtCantidad.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                //valido que hayan cargado todas las puntuaciones para ejecutar el código
                if (!(txtPunt1.Text == string.Empty || txtPunt2.Text == string.Empty || txtPunt3.Text == string.Empty || txtPunt4.Text == string.Empty || txtPunt5.Text == string.Empty))
                {
                    lblParticipante.Text = $"Participante Nº {i + 2}";

                    double p1 = Convert.ToDouble(txtPunt1.Text);
                    double p2 = Convert.ToDouble(txtPunt2.Text);
                    double p3 = Convert.ToDouble(txtPunt3.Text);
                    double p4 = Convert.ToDouble(txtPunt4.Text);
                    double p5 = Convert.ToDouble(txtPunt5.Text);

                    double[] Puntuaciones = new double[] { p1, p2, p3, p4, p5 };
                    Array.Sort(Puntuaciones);

                    double promedio = (Puntuaciones[1] + Puntuaciones[2] + Puntuaciones[3]) / 3;
                    string nombre = txtNombre.Text;

                    lbxRanking.Items.Add($"{promedio}    {nombre}");
                    lbxRanking.Sorted = true;

                    foreach (Control control in gbDatos.Controls)
                    {
                        if (control is TextBox) control.Text = "";
                    }
                }
                else MessageBox.Show("Debe ingresar TODAS las puntuaciones de los Jurados");
            }
            gbDatos.Enabled = false;
        }
    }
}