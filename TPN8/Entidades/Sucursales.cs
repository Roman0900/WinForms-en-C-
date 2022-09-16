using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursales
    {
        private int Id_Sucursal;
        private String Nombre;
        private String Descripcion;
        private int ID_prov;
        private String Direccion;


        public Sucursales()
        { }

        public int getIdSucursal()
        {
            return Id_Sucursal;
        }

        public void setIdSucursal(int id_Sucursal)
        {
            Id_Sucursal = id_Sucursal;
        }

        public String GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(String nombre)
        {
            Nombre = nombre;

        }
        public String GetDescripcion()
        {
            return Descripcion;
        }

        public void SetDescripcion(String descripcion)
        {
            Descripcion = descripcion;

        }

        public int GetID_prov()
        {
            return ID_prov;
        }

        public void SetID_prov(int id_p)
        {
            ID_prov = id_p;
        }

        public String GetDireccion()
        {
            return Direccion;
        }

        public void SetDireccion(String direccion)
        {
            Direccion = direccion;

        }



    }
}
