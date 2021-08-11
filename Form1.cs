using System;
using System.Collections;
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
            lstvwPosiciones.View = View.Details;
            lstvwPosiciones.Columns.Add("PUNTAJE",80, HorizontalAlignment.Center);
            lstvwPosiciones.Columns.Add("NOMBRE", -2, HorizontalAlignment.Center);
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
            //Limpio los controles instanciando la clase afin
            var limpiar = new Utiles();
            limpiar.LimpiarFormulario(this);
            
            //rehabilito botones y campos
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

                //Agrego los datos en el listview
                ListViewItem participante = new ListViewItem(promedio.ToString());
                participante.SubItems.Add(txtNombre.Text);
                lstvwPosiciones.Items.Add(participante);

                //ordeno por puntaje
                lstvwPosiciones.Sorting = SortOrder.Descending;
                lstvwPosiciones.Sort();

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
        //instancio la clase que permita solo cargar numeros en los txt de puntajes
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numeros = new Utiles();
            numeros.SoloNumeros(e);
        }

        private void txtPunt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numeros = new Utiles();
            numeros.SoloNumeros(e);
        }

        private void txtPunt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numeros = new Utiles();
            numeros.SoloNumeros(e);
        }

        private void txtPunt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numeros = new Utiles();
            numeros.SoloNumeros(e);
        }

        private void txtPunt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numeros = new Utiles();
            numeros.SoloNumeros(e);
        }

        private void txtPunt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numeros = new Utiles();
            numeros.SoloNumeros(e);
        }

        //instancio la clase que permita solo cargar solo letras en el nombre del participante
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numeros = new Utiles();
            numeros.SoloLetras(e);
        }
    }
}