using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    class curso
    {
        private int id_Curso;
        private string nombre;
        private coordinador coordinador;
        private List<asignatura> asignatura;

        public curso()
        {
        }

        public curso(int id_Curso, string nombre, coordinador coordinador, List<asignatura> asignatura)
        {
            this.id_Curso = id_Curso;
            this.nombre = nombre;
            this.coordinador = coordinador;
            this.asignatura = asignatura;
        }

        public int Id_Curso { get => id_Curso; set => id_Curso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        internal coordinador Coordinador { get => coordinador; set => coordinador = value; }
        internal List<asignatura> Asignatura { get => asignatura; set => asignatura = value; }
    }
}
