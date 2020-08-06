using Celular.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace This_Deber
{
    class Entrega : ICelular
    {
        public string EntregaCantidad { get; set; }
        public string CiudadDeLlegada { get; set; }

        //comportamientos de la clases

        public string CantidadDeProducto(string EntregaCantidad)
        {
            return $"numero de pedido o envio : {EntregaCantidad} codigo del envio : {this.EntregaCantidad}";
        }

        public string CantidadDeProducto()
        {
            throw new NotImplementedException();
        }

        public string DireccionDondeDelEnvio()
        {
            throw new NotImplementedException();
        }

        public string llega(string CiudadDeLlegada)
        {
            return $"ciudad de donde sale el producto : {CiudadDeLlegada} ciudad de destino de los productos : {this.CiudadDeLlegada}";
        }

        public string llega()
        {
            return $"LLega el dia Lunes";
        }

        public string MarcaDeProducto()
        {
            return $"La marca es Samsung";
        }

        public string MiApellido()
        {
            return $"Mi apellido es Cuello";
        }

        public string MiCedula()
        {
            return $"Mi cedula es 175082122";
        }

        public string MiCelula()
        {
            return $"17524014";
        }

        public string MiNombre()
        {
            return $"Mi nombre es Jefferson"; 
        }

        public string NumeroDeProducto()
        {
            return $"Son 200 Celualres";
        }

        public string ProductoColor()
        {
            return $"Coor Negro";
        }

        public string ProductoMarca()
        {
            return $"Marca Samsung";
        }

        public string ProductoModelo()
        {
            return $"Producto Marca Samsung";
        }
    }
}
