using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contabilidad
{
    class Coneccion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;database=contabilidad; uid=root;pwd=;");
            conectar.Open();
            return conectar;
        }

        public int insertar(String sql)
        {
            int resultado;
            MySqlCommand comando = new MySqlCommand(sql, Coneccion.ObtenerConexion());
            resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public  MySqlDataReader consultar(String sql)
        {

            MySqlCommand comando = new MySqlCommand(sql, Coneccion.ObtenerConexion());
            MySqlDataReader myReader = comando.ExecuteReader();
            return myReader;
        }
        public void llenarCBX(ComboBox cb, String sql,String id,String descripcion)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Coneccion.ObtenerConexion());

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);

            cb.ValueMember = id;
            cb.DisplayMember = descripcion;
            cb.DataSource = dt;
        }
        public List<LibroDiario> mostrar(String fecha)
        {
            String fecha2, nombre, debe, haber;
            List<LibroDiario> lista = new List<LibroDiario>();
            String sql = "Select * From `ingreso` Where `fecha`='" + fecha + "'";
            MySqlDataReader myReader = consultar(sql);
           
            while(myReader.Read())
            {
                String sql2 = "Select * From `cuenta` Where `id`='" + myReader.GetString(1) + "'";
                MySqlDataReader myReader2 = consultar(sql2);
                fecha2 = myReader.GetDateTime(3).ToString();
                nombre = myReader2.GetString(3);
                debe = "0";
                haber = "0";
                if (myReader.GetInt32(2) == 1)
                {
                    debe = myReader.GetInt32(5).ToString();
                }
                else
                {
                    haber = myReader.GetInt32(5).ToString();
                }
                LibroDiario LD = new LibroDiario(fecha2, nombre, debe, haber);
                lista.Add(LD);
                
            }
            return lista;
        }
        public List<LibroDiario> mostrar_Todo()
        {
            String fecha2, nombre, debe, haber;
            List<LibroDiario> lista = new List<LibroDiario>();
            String sql = "Select * From `ingreso` ";
            MySqlDataReader myReader = consultar(sql);

            while (myReader.Read())
            {
                String sql2 = "Select * From `cuenta` Where `id`='" + myReader.GetString(1) + "'";
                MySqlDataReader myReader2 = consultar(sql2);
                fecha2 = myReader.GetDateTime(3).ToString();
                nombre = myReader2.GetString(3);
                debe = "0";
                haber = "0";
                if (myReader.GetInt32(2) == 1)
                {
                    debe = myReader.GetInt32(5).ToString();
                }
                else
                {
                    haber = myReader.GetInt32(5).ToString();
                }
                LibroDiario LD = new LibroDiario(fecha2, nombre, debe, haber);
                lista.Add(LD);

            }
            return lista;
        }
        public List<LibroDiario> mostrarMayorFecha(String fecha,String fecha2)
        {
            String fecha3, nombre, debe, haber;
            List<LibroDiario> lista = new List<LibroDiario>();
            String sql = "Select * From `ingreso` Where `fecha`>='" + fecha + "'AND `fecha`<='" + fecha2 + "'ORDER BY `id_cuenta`";
            MySqlDataReader myReader = consultar(sql);

            while (myReader.Read())
            {
                String sql2 = "Select * From `cuenta` Where `id`='" + myReader.GetString(1) + "'";
                MySqlDataReader myReader2 = consultar(sql2);
                fecha3 = myReader.GetDateTime(3).ToString();
                nombre = myReader2.GetString(3);
                debe = "0";
                haber = "0";
                if (myReader.GetInt32(2) == 1)
                {
                    debe = myReader.GetInt32(5).ToString();
                }
                else
                {
                    haber = myReader.GetInt32(5).ToString();
                }
                LibroDiario LD = new LibroDiario(fecha3, nombre, debe, haber);
                lista.Add(LD);

            }
            return lista;
        }
        public List<LibroDiario> mostrarMayorTodo()
        {
            String fecha3, nombre, debe, haber;
            List<LibroDiario> lista = new List<LibroDiario>();
            String sql = "Select * From `ingreso` 'ORDER BY `id_cuenta`";
            MySqlDataReader myReader = consultar(sql);

            while (myReader.Read())
            {
                String sql2 = "Select * From `cuenta` Where `id`='" + myReader.GetString(1) + "'";
                MySqlDataReader myReader2 = consultar(sql2);
                fecha3 = myReader.GetDateTime(3).ToString();
                nombre = myReader2.GetString(3);
                debe = "0";
                haber = "0";
                if (myReader.GetInt32(2) == 1)
                {
                    debe = myReader.GetInt32(5).ToString();
                }
                else
                {
                    haber = myReader.GetInt32(5).ToString();
                }
                LibroDiario LD = new LibroDiario(fecha3, nombre, debe, haber);
                lista.Add(LD);

            }
            return lista;
        }

    }
}
