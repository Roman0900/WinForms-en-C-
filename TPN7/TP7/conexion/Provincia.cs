using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP7_PROG3_2021_1C
{
    public class Provincia
    {

        private int Id_Provincia;
        private String DescripcionProvincia;

        public Provincia() { }

        public Provincia(int Id_Provincia, String DescripcionProvincia)
        {
            this.Id_Provincia = Id_Provincia;
            this.DescripcionProvincia = DescripcionProvincia;
        }


        public int IdProvincia
        {
            get { return Id_Provincia; }
            set { Id_Provincia = value; }
        }

        public String Descripcion_Provincia
        {
            get { return DescripcionProvincia; }
            set { DescripcionProvincia = value; }
        }
            

    }
}