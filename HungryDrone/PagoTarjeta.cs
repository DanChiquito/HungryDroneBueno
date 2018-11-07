using System;

namespace HungryDrone
{
    class PagoTarjeta
    {

        #region Constructores
        public PagoTarjeta(string Numero, string Fecha, string Cvv, string Nombre)
        {
            this.Numero = Numero;
            this.Fecha = Fecha;
            this.Cvv = Cvv;
            this.Nombre = Nombre;
        }
        #endregion

        #region Atributos
        private string numero;
        private string fecha;
        private string cvv;
        private string nombre;

        #endregion

        #region Propiedades

        public string Numero
        {
            get => numero;
            set => numero = value;
        }
        public string Fecha
        {
            get => fecha;
            set => fecha = value;
        }
        public string Cvv
        {
            get => cvv;
            set => cvv = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        #endregion

        #region Métodos
        public bool Tarjeta()
        {

            return true;
        }
        #endregion
    }
}
