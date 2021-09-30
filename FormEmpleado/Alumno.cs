using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAlumno
{
    class Alumno
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int dni { get; set; }
        private string legajo { get; set; }
        private string carrera { get; set; }
        private int añoInscripcion { get; set; }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public string Carrera
        {
            get { return this.carrera; }
            set { this.carrera = value; }
        }
        public int AñoInscripcion
        {
            get { return this.añoInscripcion; }
            set { this.añoInscripcion = value; }
        }

        public Alumno(string pNombre, string pApellido, int pDNI, string pLegajo, string pCarrera, int pAñoInscripcion)
        {
            nombre = pNombre;
            apellido = pApellido;
            dni = pDNI;
            legajo = pLegajo;
            carrera = pCarrera;
            añoInscripcion = pAñoInscripcion;
        }
    }
}
