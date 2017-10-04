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


        private static SqlConnection conn = new SqlConnection("user id=dev;password=forge2017;server=devforge.c0muduoou4ac.us-east-1.rds.amazonaws.com;Trusted_Connection=No;database=bd_forge;connection timeout=30");
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
        public static void insertarUser()
        {
            conn.Open();
            String sentenciaSQL = "Insert into usuario (ci, idrol, nombre, contraseña) values (1234567, 3, 'Matias', '1234')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }
        public static void insertPersona()
        {
            conn.Open();
            String sentenciaSQL = "INSERT INTO persona(ci, nombre, apellido, fech_nac, tel ) VALUES (1234567,'Mati','Martinez','20170809','26008003')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
           
        }
        public static void instertarRol()
        {
            conn.Open();
            String sentenciaSQL = "  INSERT INTO ROL(NOMBRE, FUNCION) VALUES('ADMINISTRADOR', 'Administrar el sistema')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
          
        }
        public static Boolean Login(string usuario, String contraseña)
        {
            try
            {
                conn.Open();
                String sentenciaSQL = "SELECT NOMBRE FROM USUARIO WHERE NOMBRE = '" + usuario + "' AND CONTRASEÑA = '" + contraseña + "'";
                cmnd = new SqlCommand(sentenciaSQL, conn);
                dtr = cmnd.ExecuteReader();
                if (dtr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void prueba(int ci, int idPostulante, int sueldoEsperado, string paisDePreferencia, string puestoDePreferencia, string direccion, DateTime date, string email)
        {
            conn.Open();
            String sentenciaSQL = "INSERT INTO postulante VALUES (" + ci + ", '" + null + "', " + null + ", '" + null + "', " + sueldoEsperado + ", '" + paisDePreferencia + "', '" + null + "', '" + puestoDePreferencia + "', '" + direccion + "', '" + email + "')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }
            public static int InsertarPostulante(int ci, int idPostulante, int sueldoEsperado, string paisDePreferencia, string puestoDePreferencia, string direccion,DateTime date, string email)
        {
            try
            {
                conn.Open();
                String sentenciaSQL = "INSERT INTO postulante VALUES (" + ci + ", '" + idPostulante + "', '" + "a" + "', '" + date + "', '" + null + "', '" + sueldoEsperado + "', '" + paisDePreferencia + "', '" + null + "', '" + puestoDePreferencia + "', '" + direccion + "', '" + email + "')";
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
                cmnd = new SqlCommand("SELECT * FROM usuario", conn);
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