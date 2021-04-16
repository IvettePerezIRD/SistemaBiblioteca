using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.OleDb;

namespace ProyectoProgramacion
{
    class Class1
    {
        private DataSet miDataSet = new DataSet();

        public bool probar_conectar()
        {
            DataTable datos = new DataTable();
            System.Data.OleDb.OleDbConnection conn = new
            System.Data.OleDb.OleDbConnection();

            if (File.Exists(@"cuentas.accdb"))
            {
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @"cuentas.accdb ;" + "Persist Security Info=False;";

                try
                {
                    conn.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            { return false; }
        }
        public DataTable Traer_datos_de_access_estudiantes()
        {
            DataTable dt = new DataTable();
            System.Data.OleDb.OleDbConnection conn = new
            System.Data.OleDb.OleDbConnection();

            string sentencia_sql = "select * from USUARIOS";

            if (File.Exists(@"cuentas.accdb"))
            {
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @"cuentas.accdb ;" + "Persist Security Info=False;";
                OleDbDataAdapter da_oldb = new OleDbDataAdapter(sentencia_sql, conn.ConnectionString);

                try
                {
                    conn.Open();
                    da_oldb.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            { return null; }

        }
        public DataTable Traer_datos_de_access_carreras()
        {
            DataTable dt = new DataTable();
            System.Data.OleDb.OleDbConnection conn = new
            System.Data.OleDb.OleDbConnection();

            string sentencia_sql = "select * from USUARIOS";

            if (File.Exists(@"cuentas.accdb"))
            {
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @"cuentas.accdb ;" + "Persist Security Info=False;";
                OleDbDataAdapter da_oldb = new OleDbDataAdapter(sentencia_sql, conn.ConnectionString);

                try
                {
                    conn.Open();
                    da_oldb.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            { return null; }

        }

        public bool ingresar_a_la_Base_De_Datos(string password,
         string cuenta_usuario)
        {

            string sentencia = "insert into USUARIOS(password,cuenta_usuario) values('";
            sentencia += password + "', '";
            sentencia += cuenta_usuario + "');";

            System.Data.OleDb.OleDbConnection conn = new
     System.Data.OleDb.OleDbConnection();
            if (File.Exists(@"cuentas.accdb"))
            {
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @"cuentas.accdb ;" + "Persist Security Info=False;";
                OleDbCommand comando = new OleDbCommand(sentencia, conn);
                comando.CommandType = CommandType.Text;

                try
                {
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return false;
            }
        }
    }
}