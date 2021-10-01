using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAlumno
{
    public partial class Form1 : Form
    {
        private List<Alumno> alumnos = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(Validar())
            {
                alumnos.Add(new Alumno(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDni.Text), txtLegajo.Text, txtCarrera.Text, Int32.Parse(txtAñoinsc.Text)));
                MessageBox.Show("Dato agregado correctamente");
                txtNombre.Clear();
                txtApellido.Clear();
                txtDni.Clear();
                txtLegajo.Clear();
                txtCarrera.Clear();
                txtAñoinsc.Clear();
                if(alumnos.Count == 1)
                {
                    lblDatos.Text = "Usted ha ingresado: " + (alumnos.Count) + " Alumno.";
                }
                else
                {
                    lblDatos.Text = "Usted ha ingresado: " + (alumnos.Count) + " Alumnos.";
                }
                
            }
            else
            {
                MessageBox.Show("Intente nuevamente");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtLegajo.Clear();
            txtCarrera.Clear();
            txtAñoinsc.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Validación para los campos ingresados por el usuario
        private bool Validar()
        {
            bool datoValido;
            datoValido = true;

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre esta vacío");
                txtNombre.Focus();
                datoValido = false;

            }
            
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("El Apellido esta vacío");
                txtApellido.Focus();
                datoValido = false;
            }

            try
            {
                Int32.Parse(txtDni.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El dato DNI es incorrecto o esta vacio");
                datoValido = false;
            }

            if (txtLegajo.Text.Trim() == "")
            {
                MessageBox.Show("El Legajo esta vacío");
                txtLegajo.Focus();
                datoValido = false;
            }

            if (txtCarrera.Text.Trim() == "")
            {
                MessageBox.Show("La Carrera esta vacío");
                txtCarrera.Focus();
                datoValido = false;
            }

            try
            {
                Int32.Parse(txtAñoinsc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Año de Inscripción es incorrecto o esta vacio");
                datoValido = false;
            }

            return datoValido;
        }

    }
}
