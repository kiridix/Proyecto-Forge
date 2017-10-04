using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoForge
{
    public class BD
    {


        private static SqlConnection conn = new SqlConnection("user id=dev;password=forge2017;server=devforge.c0muduoou4ac.us-east-1.rds.amazonaws.com;Trusted_Connection=No;database=pruebaxd;connection timeout=30");
        private static SqlCommand cmnd;
        private static SqlDataReader dtr;

        public static Boolean TestConnection()
        {
            try
            {
                conn.Open();
                conn.Close();
                return (true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return (false);
            }
        }
        public static int InsertarPersona(int ci, string nombre, string apellido)
        {
            try
            {
                conn.Open();
                String sentenciaSQL = "INSERT INTO persona VALUES (" + ci + ", '" + nombre + "', '" + apellido + "')";
                cmnd = new SqlCommand(sentenciaSQL, conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (Exception e)
            {
                switch (e.HResult)
                {
                    case -2146232060:
                        conn.Close();
                        return 1;
                    default:
                        MessageBox.Show(e.ToString() + "\n\n" + "HResult: " + e.HResult.ToString());
                        conn.Close();
                        return e.HResult;
                }
            }
        }
            public static int InsertarPostulante(int ci, int idPostulante, int sueldoEsperado, string paisDePreferencia, string puestoDePreferencia, string direccion, string email)
        {
            try
            {
                conn.Open();
                String sentenciaSQL = "INSERT INTO postulante VALUES (" + ci + ", '" + idPostulante + "', '" + null + "', '" + null + "', '" + null + "', '" + sueldoEsperado + "', '" + paisDePreferencia + "', '" + null + "', '" + puestoDePreferencia + "', '" + direccion + "', '" + email + "')";
                cmnd = new SqlCommand(sentenciaSQL, conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (Exception e)
            {
                switch (e.HResult)
                {
                    case -2146232060:
                        conn.Close();
                        return 1;
                    default:
                        MessageBox.Show(e.ToString() + "\n\n" + "HResult: " + e.HResult.ToString());
                        conn.Close();
                        return e.HResult;
                }
            }
        }
        public static System.Data.DataTable ListarPostulantes()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                conn.Open();
                cmnd = new SqlCommand("SELECT * FROM postulante", conn);
                dtr = cmnd.ExecuteReader();
                dt.Load(dtr);
                dtr.Close();
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}