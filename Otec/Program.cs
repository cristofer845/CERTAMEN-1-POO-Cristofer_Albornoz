using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtecLibrary;

namespace Otec
{
    class Program
    {
        static void Main(string[] args)
        {
            //code
            asignatura asignatura = new asignatura(1, "Filosofia", "Tales de Mileto");
            coordinador coordinador = new coordinador(1, "Luis Alberto Fuenzalida", "+56923456789", "Los robles 845", "luis.alberto.fuen@gmail.com");
            administrador administrador = new administrador(1, "Tales de Mileto", "11.120.235-9", "talesdemileto@gmail.com", "los alerces 123", "+56999998888");
            //encaso de que se quiera  agregar mas cursos y mas asignatuas se ocupan las listas
            List<asignatura> lista_asignaturas = new List<asignatura>();
            lista_asignaturas.Add(asignatura);
            curso curso = new curso(coordinador, lista_asignaturas, 1, "Primero b");
            List<curso> lista_cursos = new List<curso>();
            lista_cursos.Add(curso);
            sede sede = new sede(1, "GRECIA ", administrador, lista_cursos);
            Console.WriteLine("nombre sede : " + sede.Nombre);
            Console.WriteLine("nombre administrador u encargado : " + sede.Administrador.Nombre_adm);
            Console.WriteLine("nombre coordinador : " + coordinador.Nombre_c1);
            Console.WriteLine("nombre curso : " + curso.Nombre);
            Console.WriteLine("nombre asignatura : " + asignatura.Nombre_a);
            Console.WriteLine("Cantidad de Cursos: " + sede.Cursos.Count());
            Console.ReadKey();

        }
    }
}
     