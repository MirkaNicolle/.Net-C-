using System.ComponentModel.DataAnnotations;

namespace Fundamentos.Models
{
    public class Estudiante : Persona
    {
        private string matricula;
        
        public string Matricula
        {
            get { return matricula; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    matricula = value.Trim();
                }
                else
                {
                    throw new ArgumentException("La matrícula no puede estar vacía");
                }
            }
        }
    }
}