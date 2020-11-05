using System;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Clase Boleta contiene arreglos con las calificaciones de materias, + la creacion de un alumno1 de clase Alumno + la impresion de todos sus datos ordenados
    /// </summary>
    class Boleta 
    {
        /// <summary>
        /// Areglo de calificaciones de la materia 1, este se usaria para calcular su promedio parcial y final
        /// </summary>
        /// <value></value>
        public int[] califM1 = {10, 10, 10};
        /// <summary>
        /// Areglo de calificaciones de la materia 2, este se usaria para calcular su promedio parcial y final
        /// </summary>
        /// <value></value>
        public int[] califM2 = {10, 10, 10};
        /// <summary>
        /// Método Main con el que corre el programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Se crea objeto Alumno alumno1 y se le ingresan los datos correspondientes
            // orden de args: "Carrera", "Grupo", "Nombre", "Apellidos", "Materia1", "Materia2"
            Alumno alumno1 = new Alumno("Ing Multimedia", "Grupo 1", "Isaac" , "Najera H", "Ingles", "Mate");
            Alumno alumno2 = new Alumno("Artes Visuales", "Grupo 2", "Chicharito", "Hernandez M", "Arte1", "Diseño");

                //print alumno1
                System.Console.WriteLine("---------------------------------------------------------");
            
                System.Console.WriteLine("| {0} | {1} | Alumno: {2} {3} ", alumno1.carrera, alumno1.grupo, alumno1.name, alumno1.apellidos);

                System.Console.WriteLine("-{0} : __ , -{1} : __", alumno1.materia1, alumno1.materia2);

                System.Console.WriteLine("---------------------------------------------------------"); 

                //print alumno2
                System.Console.WriteLine("---------------------------------------------------------");
            
                System.Console.WriteLine("| {0} | {1} | Alumno: {2} {3} ", alumno2.carrera, alumno2.grupo, alumno2.name, alumno2.apellidos);

                System.Console.WriteLine("-{0} : __ , -{1} : __", alumno2.materia1, alumno2.materia2);

                System.Console.WriteLine("---------------------------------------------------------"); 



                // TODO : obtener con exito los valores de los arrays de calificaciones (califM1, califM2) para poder sacar el promedio y mostrarlo en la consola junto con los datos del alumno...

        }
    }
}