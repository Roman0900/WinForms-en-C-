using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;


namespace Negocio
{
    public class NegocioSucursal
    {
        
        public bool eliminarSucursal(int id)
        {
            
            DatosSucursal dat = new DatosSucursal();
            Sucursales suc = new Sucursales();
            suc.setIdSucursal(id);
            int op = dat.eliminarSucursal(suc);
            if (op == 1)
                return true;
            else
                return false;
        }


        public DataTable ObtenerTablaSucursal(string table,string query)
        {

            DatosSucursal datsuc = new DatosSucursal();

            return datsuc.ObtenerTabla(table, query);

        }


        public DataTable GetTablaProvincia()
        {
            DatosSucursal dao = new DatosSucursal();
            return dao.GetProvincias();
        }

        public bool NewSucursal(String nombre, String Descripcion, String Direccion, int ID_p)
        {
            int cantFilas = 0;

            Sucursales suc = new Sucursales();
            DatosSucursal dao = new DatosSucursal();

            suc.SetNombre(nombre);
            suc.SetDescripcion(Descripcion);
            suc.SetID_prov(ID_p);
            suc.SetDireccion(Direccion);

            if (dao.ExisteSuc(suc) == false)
            {
                cantFilas = dao.AgregarSucursal(suc);
            }

            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }




    }
}
