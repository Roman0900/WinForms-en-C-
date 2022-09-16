using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajo_Practico_N6
{ 
        public class Producto
        {
            private int IdProducto;
            private String NombreProducto;
            private String CantidadPorUnidad;
            private float PrecioUnidad;

            public Producto()
            {

            }

            public Producto(int IdProducto, String NombreProducto, String CantidadPorUnidad, float PrecioUnidad)
            {
                this.IdProducto = IdProducto;
                this.NombreProducto = NombreProducto;
                this.CantidadPorUnidad = CantidadPorUnidad;
                this.PrecioUnidad = PrecioUnidad;
            }

            public int Id_Producto
            {
                get { return IdProducto; }
                set { IdProducto = value; }
            }
            public String Nombre_Producto
            {
                get { return NombreProducto; }
                set { NombreProducto = value; }
            }
            public String Cantidad_Por_Unidad
            {
                get { return CantidadPorUnidad; }
                set { CantidadPorUnidad = value; }
            }
            public float Precio_Unidad
            {
                get { return PrecioUnidad; }
                set { PrecioUnidad = value; }
            }
        }
    }