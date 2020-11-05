using System;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Clase Carrera genera variable carrera, se heredará a clase Grupo
    /// </summary>
    class Carrera
    {
        public string carrera;
        
        /// <summary>
        /// Método constructor de clase Carrera
        /// </summary>
        /// <param name="carrera"></param>
        public Carrera(string carrera) 
        {
            this.carrera = carrera;
        }
    }
}