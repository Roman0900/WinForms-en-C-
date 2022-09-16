using System;
using System.Data;
using System.Data.SqlClient;

namespace Trabajo_Practico_N5
{
    

    public class Conexiondb
    {
       

        private DataSet dataset;
       
        private SqlConnection connection;
        
        private  SqlDataAdapter adapter;
          
       public Conexiondb(String connectiondb)
        {           
            connection = new SqlConnection(connectiondb);
        }

        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();

        }

        public DataSet GetDataset(String querydb ,String namedataset="default")
        {

            dataset = new DataSet();

            adapter = new SqlDataAdapter(querydb, connection);

            adapter.Fill(dataset, namedataset);

            return dataset;

        }
        public int ejecutaTransaccion(String consulta,string ruta)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();

            SqlCommand conrr = new SqlCommand(consulta, conexion);

            int lineasAfectadas = conrr.ExecuteNonQuery();
            conexion.Close();
            return lineasAfectadas;
        }

    }
}