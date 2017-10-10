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
        public static int InsertarPersona(int ci, string nombre, string apellido, string fecha, string telefono)
        {
            try
            {
                conn.Open();
                String sentenciaSQL = "INSERT INTO persona VALUES (" + ci + ", '" + nombre + "', '" + apellido + "', '"+ fecha +"', '"+ telefono +"')";
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
        public static void insertPersona(int ci, string nombre, string apellido, DateTime fecha, string telefono)
        {
            conn.Open();
            String sentenciaSQL = "INSERT INTO persona(ci, nombre, apellido, fech_nac, tel ) VALUES (" + ci + ", '" + nombre + "', '" + apellido + "', '" + fecha + "', '" + telefono + "')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
           
        }
        public static void deletePersona(string ci)
        {
            conn.Open();
            String sentenciaSQL = "DELETE FROM persona WHERE ci='" + ci + "'";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }
        public static void deletePostulante(string ci)
        {
            conn.Open();
            String sentenciaSQL = "DELETE FROM postulante WHERE ci='"+ ci +"'";
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
            public static int InsertarPostulante(int ci, string licencia, DateTime fecLic, int sueldo, string pais, string cargo, string direccion, string email)
        {
                conn.Open();
                String sentenciaSQL = "Insert into postulante values ("+ ci +", '"+ licencia +"', '"+ fecLic +"', null , "+ sueldo +" , '"+ pais +"' , null , '"+ cargo +"', '" + direccion + "', '" + email + "')";
                cmnd = new SqlCommand(sentenciaSQL, conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
                return 0;
           
        }
        public static System.Data.DataTable Listar(string Table)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                conn.Open();
                cmnd = new SqlCommand("SELECT * FROM " + Table + "", conn);
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
            public static string Select(string dato, string tabla, string donde) {
                string resultado = string.Empty;
                conn.Open();
                cmnd = new SqlCommand("SELECT "+ dato +" FROM "+ tabla +" WHERE ci=" + donde +"", conn);
                resultado = Convert.ToString(cmnd.ExecuteScalar());
                conn.Close();
                return resultado;
            }
        public static int InsertEmpresa(int rut, string nombre, string direccion_fiscal, String direccion_ficica, String tel, String email, DateTime fecha_ingreso, String rubro)

        {
            try
            {
                conn.Open();


                String sentenciaSQL = "INSERT INTO empresa VALUES (" + rut + ", '" + nombre + "', '" + direccion_fiscal + "', '" + direccion_ficica + "', '" + tel + "', '" + email + "', '" + fecha_ingreso + "', '" + rubro + "')";

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

        public static System.Data.DataTable ListarEmpresa(string atributo, string nom)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {



                conn.Open();
                cmnd = new SqlCommand("SELECT * FROM empresa where " + atributo + " like '%" + nom + "%'", conn);
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

        public static int BorrarEmpresa(int dato)

        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM empresa where rut like '%" + dato + "%'", conn);
            dtr = cmnd.ExecuteReader();
            dtr.Close();
            conn.Close();


            return 0;
        }
    }
    }
