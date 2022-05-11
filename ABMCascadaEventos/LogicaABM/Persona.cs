using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaABM
{
    public enum Asignaturas
    {
        MATEMATICA, LENGUA, CIENCIAS, PROGRAMACION
    }
    public class Persona
    {
        public string Nombre { get; set; }
        public Asignaturas Asignatura { get; set; }
        public bool Aprobado { get; set; }
        public int Nota { get; set; }

        public Persona(string nombre, Asignaturas asignatura, int nota)
        {
            Nombre = nombre;
            Asignatura = asignatura;
            Aprobado = nota > 5 ? true : false;
            Nota = nota;
        }

    }
}
