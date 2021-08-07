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
            txtCantidad.Focus();
            gbDatos.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //valido que hayan cargado la cantidad de participantes
            if (!(txtCantidad.Text == string.Empty))
            {
                n = Convert.ToInt32(txtCantidad.Text);
                txtCantidad.Enabled = false;
                btnAceptar.Enabled = false;
                gbDatos.Enabled = true;
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debe ingresar la cantidad de participantes", "ATENCION");
                txtCantidad.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpio los controles y rehabilito botones y campos
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
            btnAgregar.Enabled = true;
            btnAceptar.Enabled = true;
            txtCantidad.Enabled = true;
            txtCantidad.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //verificio que esten todos los campos requeridos cargados antes de ejecutar el código
            bool completo = true;
            foreach (Control control in gbDatos.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == string.Empty) completo = false;
                }
            }
            if (completo)
            {
                //armo un array con las notas, solo sumo y promedio las 3 centrales
                double p1 = Convert.ToDouble(txtPunt1.Text);
                double p2 = Convert.ToDouble(txtPunt2.Text);
                double p3 = Convert.ToDouble(txtPunt3.Text);
                double p4 = Convert.ToDouble(txtPunt4.Text);
                double p5 = Convert.ToDouble(txtPunt5.Text);

                double[] Puntuaciones = new double[] { p1, p2, p3, p4, p5 };
                Array.Sort(Puntuaciones);
                double promedio = (Puntuaciones[1] + Puntuaciones[2] + Puntuaciones[3]) / 3;

                string nombre = txtNombre.Text;

                //Agrego los datos en el listbox y lo ordeno
                lbxRanking.Items.Add($"PUNTAJE:  {promedio}  -  {nombre}");
                lbxRanking.Sorted = true;

                //limpio los campos para cargar nuevos participantes
                foreach (Control control in gbDatos.Controls)
                {
                    if (control is TextBox) ((TextBox)control).Text = string.Empty;                        
                }

                //decremento la variable cantidad para no permitir cargar mas competidores que los indicados al principio
                n--;
            } else MessageBox.Show("Complete todos los campos", "ERROR");
            
            //verifico si se cargaron todos los participantes indicados al comenzar, inhabilito el groupbox
            if (n == 0) gbDatos.Enabled = false;
        }
    }
}