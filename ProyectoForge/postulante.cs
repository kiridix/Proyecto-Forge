using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoForge
{
    class postulante
    {
        private string ci;
        private string nombre;
        private string apellido;
        private string fechaNac;
        private string telefono;
        private string licCat;
        private string licVen;
        private int sueldoEsperado;
        private string paisPreferncia;
        private string puestoPreferencia;
        private string direccion;
        private string email;

        public postulante(string ci)
        {
            this.ci = ci;

        }

        public string Ci { get => ci; set => ci = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string LicCat { get => licCat; set => licCat = value; }
        public string LicVen { get => licVen; set => licVen = value; }
        public int SueldoEsperado { get => sueldoEsperado; set => sueldoEsperado = value; }
        public string PaisPreferncia { get => paisPreferncia; set => paisPreferncia = value; }
        public string PuestoPreferencia { get => puestoPreferencia; set => puestoPreferencia = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }

        public void CargarPostulante()
        {
            this.nombre = BD.Select("nombre", "persona", ci.ToString());
            this.apellido = BD.Select("apellido", "persona", ci.ToString());
            this.fechaNac = BD.Select("fech_nac", "persona", ci.ToString());
            this.telefono = BD.Select("tel", "persona", ci.ToString());
            this.licCat = BD.Select("licencia_cat", "postulante", ci.ToString());
            this.licVen = BD.Select("licencia_vec", "postulante", ci.ToString());
            this.sueldoEsperado = Int32.Parse(BD.Select("sueldo_esperado", "postulante", ci.ToString()));
            this.paisPreferncia = BD.Select("pais_preferencia", "postulante", ci.ToString());
            this.puestoPreferencia = BD.Select("puesto_prefencia", "postulante", ci.ToString());
            this.direccion = BD.Select("direccion", "postulante", ci.ToString());
            this.email = BD.Select("email", "postulante", ci.ToString());


        }
    }
}
