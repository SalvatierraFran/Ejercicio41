using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class SerHumano
    {
        private string _nombre;
        private Single _peso;
        private Single _altura;
        private string _sexo;

        public SerHumano(string Nombre, string Sexo)
        {
            this._nombre = Nombre;
            this._sexo = Sexo;
        }

        public SerHumano(string Nombre, string Sexo, Single Altura, Single Peso):this(Nombre, Sexo)
        {
            this._altura = Altura;
            this._peso = Peso;
        }

        /*Métodos*/
        public string Comer()
        {
            string rta = "Come Carne";

            return rta;
        }

        public void Dormir()
        {
            Console.WriteLine("Duerme poco");
        }

        public void MostrarString()
        {
            Console.WriteLine("\nNombre: " + this._nombre + "\nSexo: " + this._sexo);
        }

        /*Propiedades*/
        public string Nombre
        {
            get { return _nombre; }
        }

        public string Sexo
        {
            get { return _sexo; }
        }
    }
}
