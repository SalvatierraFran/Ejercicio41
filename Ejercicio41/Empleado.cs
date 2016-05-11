using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Empleado:SerHumano
    {
        private float _sueldo;

        public Empleado(float Sueldo, string Nombre, string Sexo):base(Nombre, Sexo)
        {
            this._sueldo = Sueldo;
        }

        public void SueldoMayor()
        {
            if (this._sueldo > 500)
                Console.WriteLine("El sueldo es mayor a 500");
            else
                Console.WriteLine("El sueldo es menor a 500");
        }
    }
}
