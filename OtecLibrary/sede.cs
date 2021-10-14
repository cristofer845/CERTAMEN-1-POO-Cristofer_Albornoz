using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    class sede
    {
        private int id_Sede;
        private string Nombre;
        private administrador Administrador;
        private List<curso> cursos;

        public sede()
        {
        }

        public sede(int id_Sede, string nombre, administrador administrador, List<curso> cursos)
        {
            this.id_Sede = id_Sede;
            Nombre = nombre;
            Administrador = administrador;
            this.cursos = cursos;
        }

        public int Id_Sede { get => id_Sede; set => id_Sede = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        internal administrador Administrador1 { get => Administrador; set => Administrador = value; }
        internal List<curso> Cursos { get => cursos; set => cursos = value; }
    }
}
