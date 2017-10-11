using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoForge
{
    public class Solicitud
    {
        private int idsol;
        private string nombresol;
        private int sueldo_min;
        private int sueldo_max;
        private string cond_empleado;
        private string nacionalidad;


        public int Idsol { get => idsol; set => idsol = value; }
        public string Nombresol { get => nombresol; set => nombresol = value; }
        public int Sueldo_min { get => sueldo_min; set => sueldo_min = value; }
        public int Sueldo_max { get => sueldo_max; set => sueldo_max = value; }
        public string Cond_empleado { get => cond_empleado; set => cond_empleado = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }


        public Solicitud(int idsol)
        {
            this.Idsol = idsol;
        }

        public void CargarSolicitud()
        {
            this.Nombresol = BD.Selectt("nombresol", "solicitud", Idsol.ToString());
            this.Sueldo_min = Int32.Parse(BD.Selectt("sueldo_min", "solicitud", Idsol.ToString()));
            this.Sueldo_max = Int32.Parse(BD.Selectt("sueldo_max", "solicitud", Idsol.ToString()));
            this.Cond_empleado = BD.Selectt("cond_empleado", "solicitud", Idsol.ToString());
            this.Nacionalidad = BD.Selectt("nacionalidad", "solicitud", Idsol.ToString());
        }

    }
}
