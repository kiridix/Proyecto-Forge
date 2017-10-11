using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

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
                String sentenciaSQL = "INSERT INTO persona VALUES (" + ci + ", '" + nombre + "', '" + apellido + "', '" + fecha + "', '" + telefono + "')";
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
            String sentenciaSQL = "DELETE FROM postulante WHERE ci='" + ci + "'";
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
        public static int InsertarPostulante(PictureBox pic, int ci, string licencia, DateTime fecLic, int sueldo, string pais, string cargo, string direccion, string email)
        {
            conn.Open();
            String sentenciaSQL = "Insert into postulante values (" + ci + ", '" + licencia + "', '" + fecLic + "', null , " + sueldo + " , '" + pais + "' , @foto , '" + cargo + "', '" + direccion + "', '" + email + "')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.Parameters.Add("@foto", SqlDbType.Image);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmnd.Parameters["@foto"].Value = ms.GetBuffer();
            cmnd.ExecuteNonQuery();
            conn.Close();
            return 0;

        }
        public static Image SelectImage(string tabla, string donde)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT foto FROM " + tabla + " WHERE ci=" + donde + "", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "postulante");
            byte[] datos = new byte[0];
            DataRow dr = ds.Tables["postulante"].Rows[0];
            datos = (byte[])dr["foto"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
            Image foto = Bitmap.FromStream(ms);
            conn.Close();
            return foto;


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
        public static string Selecttt(string dato, string tabla, string donde)
        {
            string resultado = string.Empty;
            conn.Open();
            cmnd = new SqlCommand("SELECT " + dato + " FROM " + tabla + " WHERE rut=" + donde + "", conn);
            resultado = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return resultado;
        }
        public static string Select(string dato, string tabla, string donde)
        {
            string resultado = string.Empty;
            conn.Open();
            cmnd = new SqlCommand("SELECT " + dato + " FROM " + tabla + " WHERE ci=" + donde + "", conn);
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
        public static void deleteConocimiento(string nombre)
        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM conocimiento where nombre like '%" + nombre + "%'", conn);
            dtr = cmnd.ExecuteReader();
            dtr.Close();
            conn.Close();
        }
        public static void deleteEstudio(string nombre)
        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM estudio where nombre like '%" + nombre + "%'", conn);
            dtr = cmnd.ExecuteReader();
            dtr.Close();
            conn.Close();
        }
        public static void listarConocimientos(ComboBox cb, string tabla)
        {
            cb.Items.Clear();
            conn.Open();
            SqlCommand cmnd = new SqlCommand("Select * from "+tabla+"", conn);
            SqlDataReader dr = cmnd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
           
            conn.Close();
        }
        public static void insertConocimiento(string conocimiento, string desc)
        {
            conn.Open();
            String sentenciaSQL = "INSERT INTO conocimiento(NOMBRE, DESCRIPCION) VALUES ('" + conocimiento + "', '" + desc + "')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }





        public static string getIdcon(ComboBox cb, string atributo, string tabla, string compara)
        {

            string idcon = string.Empty;
            conn.Open();
            string sentenciaSQL = "SELECT "+atributo+" FROM "+tabla+" where "+compara+" = '" + cb.SelectedItem.ToString() + "'";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            idcon = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return idcon;
        }
        public static string getNomCon(int idsol)
        {
            string nombre = string.Empty;
            conn.Open();
            string sentenciaSQL = "SELECT conocimiento.nombre FROM conocimiento, poseesol where poseesol.idsol LIKE "+idsol+"";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            nombre = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return nombre;
        }
        public static string getNomEst(int idsol)
        {
            string idcon = string.Empty;
            conn.Open();
            string sentenciaSQL = "SELECT estudio.nombre FROM estudio, tienesol where tienesol.idsol="+idsol+"";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            idcon = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return idcon;
        }

        public static string getIdconsol(string nombre)//asasdasd
        {

            string idcon = string.Empty;
            conn.Open();
            string sentenciaSQL = "SELECT idcon FROM conocimiento where nombre LIKE '" + nombre + "'";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            idcon = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return idcon;
        }
        public static string getIdestudio(string nombre)
        {
            string idcon = string.Empty;
            conn.Open();
            string sentenciaSQL = "SELECT idestudio FROM estudio where nombre= '" + nombre + "'";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            idcon = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return idcon;
        }

        public static string getIdPostulante(string ci)
        {
            string Ci = string.Empty;
            conn.Open();
            string sentenciaSQL = "SELECT idpostulante FROM postulante where ci = '" + ci + "'";       
            cmnd = new SqlCommand(sentenciaSQL, conn);
            Ci = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return Ci;
        }



        public static void insertarestudio (int idestudio, int idpostulante, DateTimePicker fech_inicio, DateTimePicker fech_fin)
        {
            conn.Open();
            string sentenciaSQL = "insert into posee(idestudio,idpostulante,fech_inicio,fech_fin) values ("+idestudio+","+idpostulante+",'"+fech_inicio.Value+"','"+fech_fin.Value+"')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }
        public static void insertarConocimiento(int idcon, int idpost)
        {
            conn.Open();
            string sentenciaSQL = "insert into tiene (idcon, idpostulante) Values (" + idcon + ", " + idpost + ")";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }
        public static void insertarConocimientosol(int idcon, int idsol)
        {
            conn.Open();
            string sentenciaSQL = "insert into poseesol (idcon, idsol) Values (" + idcon + ", " + idsol + ")";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable listarMasEstudios(int idpos)
        {
            DataTable dt = new DataTable();
            conn.Open();
            cmnd = new SqlCommand("SELECT estudio.nombre, posee.fech_Inicio, posee.fech_fin, posee.idestudio FROM estudio, posee WHERE posee.idestudio = estudio.idestudio AND posee.idpostulante = "+ idpos +"", conn); 
            dt.Load(cmnd.ExecuteReader());
            conn.Close();
            return dt;
        }
        public static DataTable ListarMasConocimientos(int idpos)
        {

            System.Data.DataTable dt = new System.Data.DataTable();
                conn.Open();
                cmnd = new SqlCommand("SELECT conocimiento.nombre, conocimiento.descripcion, tiene.idcon FROM conocimiento, tiene WHERE tiene.idcon=conocimiento.idcon AND tiene.idpostulante= "+ idpos +"", conn);
                dtr = cmnd.ExecuteReader();
                dt.Load(dtr);
                dtr.Close();
                conn.Close();
                return dt;
        }
        public static DataTable ListarMasConocimientosSol(int idsol)
        {

            System.Data.DataTable dt = new System.Data.DataTable();
            conn.Open();
            cmnd = new SqlCommand("SELECT conocimiento.nombre, conocimiento.descripcion, poseesol.idcon FROM conocimiento, poseesol WHERE poseesol.idcon=conocimiento.idcon AND poseesol.idsol= " + idsol + "", conn);
            dtr = cmnd.ExecuteReader();
            dt.Load(dtr);
            dtr.Close();
            conn.Close();
            return dt;
        }
        public static int BorrarconocimientoP(int idcon, int idpos)

        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM tiene where idcon="+idcon+" and idpostulante="+idpos+"", conn);
            dtr = cmnd.ExecuteReader();
            dtr.Close();
            conn.Close();


            return 0;
        }
        public static void BorrarEstudioP(int idestudio, int idpos)
        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM posee where idestudio=" + idestudio + " and idpostulante=" + idpos + "", conn);
            dtr = cmnd.ExecuteReader();
            dtr.Close();
            conn.Close();
        }
        public static void insertEstudioinpostulante(int idestudio, int idpost)
        {
            conn.Open();
            string sentenciaSQL = "insert into posee (idestudio, idpostulante) Values (" + idestudio + ", " + idpost + ")";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }
        public static void instertEstudio(string nombre)
        {
            conn.Open();
            string sentenciaSQL = "insert into estudio(nombre) values('"+nombre+"')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }
        public static void EliminarConocimiento(int idcon)
        {
            conn.Open();
            string sentenciaSql = "delete from tiene where idcon=" + idcon + "";
            cmnd = new SqlCommand(sentenciaSql, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();

        }
        public static void EliminarCualidadDePostulante(string table, int idpos)
        {
            conn.Open();
            string sentenciaSql = "delete from "+table+" where idpostulante=" + idpos + "";
            cmnd = new SqlCommand(sentenciaSql, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();

        }
        public static void insertSolicitud(string nombresol, string pais, int sueldo_min, int sueldo_max, string cond_contrato, int estudios, int conocimientos)
        {
            conn.Open();
            String sentenciaSQL = "INSERT INTO solicitud(nombresol, pais, sueldo_min, sueldo_max, cond_contrato, estudios, conocimientos) VALUES ('" + nombresol + "', '" + pais + "', '" + sueldo_min + "', '" + sueldo_max + "', '" + cond_contrato + "', '" + estudios + "', '" + conocimientos + "')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }

        public static string getIdsol(ComboBox cb)
        {

            string idsol = string.Empty;
            conn.Open();
            string sentenciaSQL = "SELECT idsol FROM solicitud where nombresol = '" + cb.SelectedItem.ToString() + "'";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            idsol = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return idsol;
        }

        public static void listarSolicitudes(ComboBox cb)
        {
            cb.Items.Clear();
            conn.Open();
            SqlCommand cmnd = new SqlCommand("Select * from solicitud", conn);
            SqlDataReader dr = cmnd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }

            conn.Close();
        }

        public static void deleteSolicitud(int idsol)
        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM solicitud where idsol like '%" + idsol + "%'", conn);
            dtr = cmnd.ExecuteReader();
            dtr.Close();
            conn.Close();
        }

        public static void insertSolicitud(string nombresol, string pais, int sueldo_min, int sueldo_max, string cond_contrato)
        {
            conn.Open();
            String sentenciaSQL = "INSERT INTO solicitud(nombresol, pais, sueldo_min, sueldo_max, cond_contrato) VALUES ('" + nombresol + "', '" + pais + "', '" + sueldo_min + "', '" + sueldo_max + "', '" + cond_contrato + "')";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }

        public static string Selectt(string dato, string tabla, string donde)
        {
            string resultado = string.Empty;
            conn.Open();
            cmnd = new SqlCommand("SELECT " + dato + " FROM " + tabla + " WHERE idsol=" + donde + "", conn);
            resultado = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return resultado;
        }

        public static string getIdEmpresa(int rut)
        {
            string id = string.Empty;
            conn.Open();
            string sentenciaSQL = "SELECT idempresa FROM postulante where rut = '" + rut + "'";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            id = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return id;
        }
        public static string getIdsolicitud(string nombre, string nombreEmpresa)
        {

            string idsol = string.Empty;
            string cadena = nombre + " --- " + nombreEmpresa;
            conn.Open();
            string sentenciaSQL = "SELECT idsol FROM solicitud where nombresol='" + cadena +"'";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            idsol = Convert.ToString(cmnd.ExecuteScalar());
            conn.Close();
            return idsol;
        }
        public static System.Data.DataTable Listarsol(string nombre)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                conn.Open();
                cmnd = new SqlCommand("SELECT * FROM solicitud WHERE nombresol LIKE '%"+nombre+ "'", conn);
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
        public static System.Data.DataTable Listarsolicitudestodas(string nombre)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                conn.Open();
                cmnd = new SqlCommand("SELECT * FROM solicitud WHERE nombresol LIKE '%" + nombre + "'", conn);
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
        public static void aaa()
        {
           
            conn.Open();
            String sentenciaSQL = "ALTER TABLE tienesol ADD CONSTRAINT PK_tienesol PRIMARY KEY(idestudio, idsol)";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
            
        }

        //"SELECT * FROM sysobjects WHERE name LIKE 'PK__poseesol%"
        public static DataTable wea()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            conn.Open();
            cmnd = new SqlCommand("SELECT * FROM sysobjects WHERE name LIKE 'PK%'", conn);
            dtr = cmnd.ExecuteReader();
            dt.Load(dtr);
            dtr.Close();
            conn.Close();
            return dt;
        }
        public static void insertarEstudioSol(int idestudio, int idsol)
        {
            conn.Open();
            String sentenciaSQL = "Insert into tienesol(idestudio, idsol)  values ("+idestudio+", "+idsol+")";
            cmnd = new SqlCommand(sentenciaSQL, conn);
            cmnd.ExecuteNonQuery();
            conn.Close();
        }
        public static  DataTable listarEstudiosSol(int idsol)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            conn.Open();
            cmnd = new SqlCommand("SELECT estudio.nombre FROM estudio, tienesol WHERE tienesol.idestudio=estudio.idestudio AND tienesol.idsol= " + idsol + "", conn);
            dtr = cmnd.ExecuteReader();
            dt.Load(dtr);
            dtr.Close();
            conn.Close();
            return dt;
        }
        public static void listarsolicitudescbox(ComboBox cb)
        {
            cb.Items.Clear();
            conn.Open();
            SqlCommand cmnd = new SqlCommand("SELECT nombresol from solicitud", conn);
            SqlDataReader dr = cmnd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[0].ToString());
            }

            conn.Close();
        }
        public static DataTable matching(int idcon, int idestudio)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            conn.Open();
            cmnd = new SqlCommand("SELECT postulante.ci, persona.nombre, persona.apellido from tiene, postulante, persona where tiene.idcon="+idcon+" AND tiene.idpostulante=postulante.idpostulante AND postulante.ci=persona.ci", conn);
            dtr = cmnd.ExecuteReader();
            dt.Load(dtr);
            dtr.Close();
            conn.Close();
            return dt;
        }
        public static void deletePoseesol(int idsol)
        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM poseesol where idsol like '%" + idsol + "%'", conn);
            dtr = cmnd.ExecuteReader();
            dtr.Close();
            conn.Close();
        }
        public static void deleteTienesol(int idsol)
        {
            conn.Open();
            cmnd = new SqlCommand("DELETE FROM tienesol where idsol like '%" + idsol + "%'", conn);
            dtr = cmnd.ExecuteReader();
            dtr.Close();
            conn.Close();
        }
    }
    }
