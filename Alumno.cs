using System;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Clase Alumno que hereda datos de clase Grupo
    /// </summary>
    class Alumno : Grupo
    {
        public string name; 
        public string apellidos;

        public string materia1;
        public string materia2;

        //public int[] califM1 = {10, 10, 10};
        //public int[] califM2 = {10, 10, 10};
        
        /// <summary>
        /// Metodo constructor de Alumno(contendrá carrera, grupo, name, apellidos, y materia1,2)       
        /// </summary>
        /// <param name="carrera"></param>
        /// <param name="grupo"></param>
        /// <param name="name"></param>
        /// <param name="apellidos"></param>
        /// <param name="materia1"></param>
        /// <param name="materia2"></param>
        /// <returns></returns>
        public Alumno(string carrera, string grupo, string name, string apellidos, string materia1, string materia2) : base(carrera, grupo){
            this.name = name;
            this.apellidos = apellidos;
            this.materia1 = materia1;
            this.materia2 = materia2;
            //this.califM1 = califM1;
            //this.califM2 = califM2;

        }
    }

}