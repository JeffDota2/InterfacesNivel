using Celular.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace This_Deber
{
    public class Cliente:ICelular
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cedula { get; set; }

        public string Celular { get; set; }

        public string MiNombre(string Nombre)
        {
            return $"Hola me llamo { Nombre} y tu como te llamas?: {this.Nombre}";
        }
        public string MiApellido(string Apellido)
        {
            return $"Me apellido {Apellido}  Y el tuyo? :{this.Apellido }";
        }
        public string MiCedula(string Cedula)
        {
            return $"Mi cedula es: {Cedula} Cual es tu numero de cdula? :{this.Cedula}";
        }
        public string MiCelular(string Celular)
        {
            return $"Mi numero es :{Celular} cual es su numero de celular :{ this.Celular}";
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
            return $"1750815";
        }

        public string MiCelula()
        {
            return $"17508244";
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
            return $"Quito la Tola";
        }

        public string CantidadDeProducto()
        {
            return $"200";
        }

        public string llega()
        {
            return $"LLega el dia Lunes";
        }

        public string ProductoColor()
        {
            return $":";
        }

        public string ProductoMarca()
        {
            return $"Samsung";
        }

        public string ProductoModelo()
        {
            return $"A20";
        }
    }
}
