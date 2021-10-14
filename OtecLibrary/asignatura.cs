using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    class asignatura
    {
        private int cod_asignatura;
        private string nombre_a;
        private string profesor;
        

        public asignatura()
        {
        }

        public asignatura(int cod_asignatura, string nombre_a, string profesor)
        {
            this.cod_asignatura = cod_asignatura;
            this.nombre_a = nombre_a;
            this.profesor = profesor;
        }

        public int Cod_asignatura { get => cod_asignatura; set => cod_asignatura = value; }
        public string Nombre_a { get => nombre_a; set => nombre_a = value; }
        public string Profesor { get => profesor; set => profesor = value; }
    }
}
