using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Image foto;

        public string Ci
        {
            get
            {
                return ci;
            }

            set
            {
                ci = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string FechaNac
        {
            get
            {
                return fechaNac;
            }

            set
            {
                fechaNac = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string LicCat
        {
            get
            {
                return licCat;
            }

            set
            {
                licCat = value;
            }
        }

        public string LicVen
        {
            get
            {
                return licVen;
            }

            set
            {
                licVen = value;
            }
        }

        public int SueldoEsperado
        {
            get
            {
                return sueldoEsperado;
            }

            set
            {
                sueldoEsperado = value;
            }
        }

        public string PaisPreferncia
        {
            get
            {
                return paisPreferncia;
            }

            set
            {
                paisPreferncia = value;
            }
        }

        public string PuestoPreferencia
        {
            get
            {
                return puestoPreferencia;
            }

            set
            {
                puestoPreferencia = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public Image Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public postulante(string ci)
        {
            this.Ci = ci;

        }

        public void CargarPostulante()
        {
            this.Nombre = BD.Select("nombre", "persona", Ci.ToString());
            this.Apellido = BD.Select("apellido", "persona", Ci.ToString());
            this.FechaNac = BD.Select("fech_nac", "persona", Ci.ToString());
            this.Telefono = BD.Select("tel", "persona", Ci.ToString());
            this.LicCat = BD.Select("licencia_cat", "postulante", Ci.ToString());
            this.LicVen = BD.Select("licencia_vec", "postulante", Ci.ToString());
            this.SueldoEsperado = Int32.Parse(BD.Select("sueldo_esperado", "postulante", Ci.ToString()));
            this.PaisPreferncia = BD.Select("pais_preferencia", "postulante", Ci.ToString());
            this.PuestoPreferencia = BD.Select("puesto_prefencia", "postulante", Ci.ToString());
            this.Direccion = BD.Select("direccion", "postulante", Ci.ToString());
            this.Email = BD.Select("email", "postulante", Ci.ToString());
            this.Foto = BD.SelectImage("postulante", Ci.ToString());


        }
    }
}
