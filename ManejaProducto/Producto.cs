using System;


namespace ManejaProducto
{
    public class Producto
    {
        #region Atributos
        public string nombre;
        public float precio;
        private bool disponibilidad;
        #endregion

        #region Propiedades 
        public string Nombre
        { get => nombre;
            set
            {
                if(value==" ")
                {
                    nombre = "Producto X";
                }
                else
                {
                    nombre = value;
                }
            } 
        }
        public float Precio
        { get => precio;
            set
            {
                if(value<30||value>1000)
                {
                    precio = 100;
                }
                else
                {
                    precio = value;
                }
                    
            } 
        }
        public bool Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        #endregion

        #region Constructor
        public Producto(string nombre, float precio, bool disponibilidad)
        {
            Nombre = nombre;
            Precio = precio;
            Disponibilidad = disponibilidad;
        }
        #endregion
    }
}
    
    
