using Celular.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace This_Deber
{
    class Destino : ICelular
    {

        public string Producto { get; set; }
        public string Cantidad { get; set; }
        public string Direccion { get; set; }


        //comportamientos de la clases
        public string MarcaDeProducto(string Producto)
        {
            return $"Referencias del producto :{Producto} otros productos para la entrega : {this.Producto}";
        }
        public string NumeroDeProducto(string Cantidad)
        {
            return $"Cantidad de producto que sale : {Cantidad} cantidad de producto que se entrega  :{this.Cantidad}";
        }
        public string DireccionDondeDelEnvio(string Direccion)
        {
            return $"Direccion de salida del producto: {Direccion} destino de lleganda :{this.Direccion}";
        }

        public string MiNombre()
        {
            return $"Jefferson";
        }

        public string MiApellido()
        {
            return $"Cuello";
        }

        public string MiCedula()
        {
            return $"1750823354";
        }

        public string MiCelula()
        {
            return $"1745253";
        }

        public string MarcaDeProducto()
        {
            return $"Samsung";
        }

        public string NumeroDeProducto()
        {
            return $"200";
        }

        public string DireccionDondeDelEnvio()
        {
            return $"LA TOLA";
        }

        public string CantidadDeProducto()
        {
            return $"sON 200 CELULARES";
        }

        public string llega()
        {
            return $"LLEGA EL DIA Lunes";
        }

        public string ProductoColor()
        {
            return $"color negro"; 
        }

        public string ProductoMarca()
        {
            return $"marca samsung";
        }

        public string ProductoModelo()
        {
            return $"modelo a20";
        }
    }
}
