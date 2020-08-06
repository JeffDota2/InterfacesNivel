using Celular.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace This_Deber
{
    class Producto : ICelular
    {

        public string ProdColor { get; set; }
        public string ProdMarca { get; set; }

        public string ProdModelo { get; set; }

        public string CantidadDeProducto()
        {
            return $"200 Celuulares";
        }

        public string DireccionDondeDelEnvio()
        {
            return $"La tola";
        }

        public string llega()
        {
            return $"LLega el dia Lunes";
        }

        public string MarcaDeProducto()
        {
            return $"Marca Samsung";
        }

        public string MiApellido()
        {
            return $"Mi apellido es Cuello";
        }

        public string MiCedula()
        {
            return $"175082365";
        }

        public string MiCelula()
        {
            return $"1750822345";
        }

        public string MiNombre()
        {
            return $"Jefferson ";
        }

        public string NumeroDeProducto()
        {
            return $"200 Celulares";
        }

        public string ProductoColor(string Codigo)
        {
            return $"Codigo de producto: {Codigo} codigos de productos :{this.ProdColor}";
        }

        public string ProductoColor()
        {
            return $"Color Negro";
        }

        public string ProductoMarca(string Marca)
        {
            return $"Marca de productos: {Marca} diferentes marcas : {this.ProdMarca}";
        }

        public string ProductoMarca()
        {
            return $"Producto marca Samsung";
        }

        public string ProductoModelo(string Modelo)
        {
            return $"Marca de productos: {Modelo} diferentes marcas : {this.ProdModelo}";
        }

        public string ProductoModelo()
        {
            return $"Samsung A20";
        }
    }
}
