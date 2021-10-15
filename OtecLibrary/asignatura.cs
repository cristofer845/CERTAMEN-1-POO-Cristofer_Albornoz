using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class asignatura
    {
        
        private int cod_asignatura;
        private string nombre_a;
        private string profesor;

        //constructor  vacio
        
        public asignatura()
        {
        }
        
        //constructor con datos
        
        public asignatura(int cod_asignatura, string nombre_a, string profesor)
        {
            this.cod_asignatura = cod_asignatura;
            this.nombre_a = nombre_a;
            this.profesor = profesor;
        }
        
        //get y set
        public int Cod_asignatura { get => cod_asignatura; set => cod_asignatura = value; }
        public string Nombre_a { get => nombre_a; set => nombre_a = value; }
        public string Profesor { get => profesor; set => profesor = value; }
    }
}
