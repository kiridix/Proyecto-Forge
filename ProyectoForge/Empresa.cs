using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoForge
{
    class Empresa
    {
        private int rUT;
        private string nombre;
        private string direccion_fiscal;
        private string direccion_fisica;
        private string tel;
        private string email;
        private DateTime fecha_de_ingreso;
        private string rubro;

        public int RUT { get => rUT; set => rUT = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion_fiscal { get => direccion_fiscal; set => direccion_fiscal = value; }
        public string Direccion_fisica { get => direccion_fisica; set => direccion_fisica = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Fecha_de_ingreso { get => fecha_de_ingreso; set => fecha_de_ingreso = value; }
        public string Rubro { get => rubro; set => rubro = value; }

        public Empresa(string rUT)
        {
            RUT = Int32.Parse(rUT);
            cargarEmpresa();
        }
        public void cargarEmpresa()
        {
            nombre = BD.Selecttt("nombre", "empresa", RUT.ToString());
            direccion_fiscal = BD.Selecttt("direccion_fiscal", "empresa", RUT.ToString());
            direccion_fisica = BD.Selecttt("dirección_fisica", "empresa", RUT.ToString());
            tel = BD.Selecttt("tel", "empresa", RUT.ToString());
            email = BD.Selecttt("email", "empresa", RUT.ToString());
            fecha_de_ingreso = DateTime.Parse(BD.Selecttt("fech_ingreso", "empresa", RUT.ToString()));
            rubro = BD.Selecttt("rubro", "empresa", RUT.ToString());
        }
    }
}
