using System.ComponentModel.DataAnnotations;

namespace Fundamentos.Models
{
    public class Profesor : Persona
    {
        private string numeroEmpleado;
        
        public string NumeroEmpleado
        {
            get { return numeroEmpleado; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    numeroEmpleado = value.Trim();
                }
                else
                {
                    throw new ArgumentException("El número de empleado no puede estar vacío");
                }
            }
        }
    }
}