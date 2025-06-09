using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public abstract class Persona // Mientras sea public se hereda a las clases hijas
    { // Las clases abstractas es una instacia en comun que se comparte entre las clases hijas, esta no se puede instanciar directamente

        // Primero se declaran los campos privados (mayoremento esto es lo regular), luego las propiedades públicas 
        // y por último los métodos públicos (esto ultimo queda a criterio del metodo y su función)
        private string nombres;
        private string apellidos; 

        // Propiedades
        public int Id; // Las propiedades en C# deben de empezar con mayúscula
        public string Nombres
        {
            get
            {
                return nombres.ToUpper(); // ToUpper convierte el string a mayúsculas
            }

            set
            {
                if(value!= null && !string.IsNullOrEmpty(value)) // Validación para evitar que se asigne un valor nulo o vacío
                {
                    nombres = value.Trim(); // Trim elimina los espacios en blanco al inicio y al final del string
                }
                else
                {
                    throw new ArgumentException("El nombre no puede estar vacío");
                }
            }

    } // Las propiedades en C# deben de empezar con mayúscula y se recomienda usar PascalCase
        public string Apellidos
        {
            get
            {
                return apellidos.ToUpper(); // ToUpper convierte el string a mayúsculas
            }

            set
            {
                if(value!= null && !string.IsNullOrEmpty(value)) // Validación para evitar que se asigne un valor nulo o vacío
                {
                    apellidos = value.Trim(); // Trim elimina los espacios en blanco al inicio y al final del string
                }
                else
                {
                    throw new ArgumentException("El apellido no puede estar vacío");
                }
            } // Propiedad de solo lectura (get) y escritura (set)
        }
        public string Email;
        public string Direccion;
        public string Telefono;
        public string Dpi;

        // Métodos
        public void MarcarAsistencia() // Los métodos en C# deben de empezar con mayúscula
        {
            // Lógica para marcar asistencia
        }
    }
}