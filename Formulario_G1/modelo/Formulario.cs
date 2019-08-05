using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace modelo
{
    public class Formulario
    {

        private String nombreEdificio;
        private String genero;
        private int cantidadInodoros;
        private double litrosExpulsados;
        private int cantidadLavamanos;
        private double tiempoExpulsion;

        public Formulario(string nombreEdificio, string genero, int cantidadInodoros, double litrosExpulsados, int cantidadLavamanos, double tiempoExpulsion)
        {
            this.nombreEdificio = nombreEdificio;
            this.genero = genero;
            this.cantidadInodoros = cantidadInodoros;
            this.litrosExpulsados = litrosExpulsados;
            this.cantidadLavamanos = cantidadLavamanos;
            this.tiempoExpulsion = tiempoExpulsion;
        }

        public string NombreEdificio { get => nombreEdificio; set => nombreEdificio = value; }
        public string Genero { get => genero; set => genero = value; }
        public int CantidadInodoros { get => cantidadInodoros; set => cantidadInodoros = value; }
        public double LitrosExpulsados { get => litrosExpulsados; set => litrosExpulsados = value; }
        public int CantidadLavamanos { get => cantidadLavamanos; set => cantidadLavamanos = value; }
        public double TiempoExpulsion { get => tiempoExpulsion; set => tiempoExpulsion = value; }


        //public string guardar(string edificio, string genero, int inodoros, double litros, int lavamanos, double tiempo)
        //{


            //StreamWriter escribir = new StreamWriter(@"C:\Users\usuario\Documents\Universidad\Proyecto Integrador\Formulario_G1\formulario.txt");
            //try
            //{

            //}

            //return "hola";
        //}

    }
}
