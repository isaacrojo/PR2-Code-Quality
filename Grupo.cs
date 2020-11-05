using System;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Clase Grupo hereda datos de clase Carrera
    /// </summary>
    class Grupo : Carrera 
    {
        public string grupo;

        //Método constructor de clase Grupo. Admite datos los carrera y grupo
        public Grupo(string carrera, string grupo) : base(carrera)
        {
            this.grupo = grupo;
        }

    }
}