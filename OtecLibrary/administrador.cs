using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    class administrador
    {
        private int cod_administrador;
        private string nombre_adm;
        private string run;
        private string correo;
        private string direccion;
        private string telefono;

        public administrador()
        {
        }

        public administrador(int cod_administrador, string nombre_adm, string run, string correo, string direccion, string telefono)
        {
            this.cod_administrador = cod_administrador;
            this.nombre_adm = nombre_adm;
            this.run = run;
            this.correo = correo;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public int Cod_administrador { get => cod_administrador; set => cod_administrador = value; }
        public string Nombre_adm { get => nombre_adm; set => nombre_adm = value; }
        public string Run { get => run; set => run = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
