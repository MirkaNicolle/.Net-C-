using Fundamentos.Models; // Importamos el espacio de nombres donde están nuestras clases
public class Program // Todas las classes en C# deben de empezar con mayúscula y se debe llamar igual que el archivo
{
    public static void Main(string[] args)
    {
        // Objetos
        Estudiante JuanPerez = new Estudiante(); // Creamos una instancia de la clase Estudiante
        JuanPerez.Id = 1; // Asignamos un valor a la propiedad Id
        JuanPerez.Nombres = "Juan"; // Asignamos un valor a la propiedad Nombres
        JuanPerez.Apellidos = "Pérez"; // Asignamos un valor a la propiedad Apellidos
        JuanPerez.Email = "juanperez@gmail.com"; // Asignamos un valor a la propiedad Email
        JuanPerez.Direccion = "Guatemala"; // Asignamos un valor a la propiedad Direccion
        JuanPerez.Telefono = "12345678"; // Asignamos un valor a la propiedad Telefono

        Console.WriteLine("Datos del estudiante: {0} {1} {2}", JuanPerez.Nombres, JuanPerez.Apellidos, JuanPerez.Email); // Imprimimos los datos del estudiante

        Estudiante DanielCoti = new Estudiante(); // Creamos una instancia de la clase Estudiante
        Estudiante MirkaMonzon = new Estudiante();
        Profesor MariaLopez = new Profesor(); // Creamos una instancia de la clase Profesor

        
        // It prints "Hello, World!" to the console.
        Console.WriteLine("Hello, World!");
    }
}