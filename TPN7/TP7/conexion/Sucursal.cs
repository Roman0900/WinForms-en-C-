using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP7_PROG3_2021_1C
{
    public class Sucursal
    {
        private int Id_Sucursal;
        private String NombreSucursal;
        private String DescripcionSucursal;
        private int Id_ProvinciaSucursal;
        private String URL_Imagen_Sucursal;


        public Sucursal() { }

        public Sucursal (int Id_Sucursal, String NombreSucursal, String DescripcionSucursal, int Id_ProvinciaSucursal, String URL_Imagen_Sucursal)
        {
            this.NombreSucursal = NombreSucursal;
            this.Id_Sucursal = Id_Sucursal;
            this.DescripcionSucursal = DescripcionSucursal;
            this.Id_ProvinciaSucursal = Id_ProvinciaSucursal;
            this.URL_Imagen_Sucursal = URL_Imagen_Sucursal;
        }

        public int IdSucursal
        {
            get { return Id_Sucursal; }
            set { Id_Sucursal = value; }
        }

        public String Nombre_Sucursal
        {
            get { return NombreSucursal; }
            set { NombreSucursal = value; }
        }

        public String Descripcion_Sucursal
        {
            get { return DescripcionSucursal; }
            set { DescripcionSucursal = value; }
        }

        public int IdProvinciaSucursal
        {
            get { return Id_ProvinciaSucursal; }
            set { Id_ProvinciaSucursal = value; }
        }

        public String UrlImagenSucursal
        {
            get { return URL_Imagen_Sucursal; }
            set { URL_Imagen_Sucursal = value; }
        }

    }
}