using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Formulario_G1
{


    class Formulario
    {
        private String nombreEdificio;
        private String genero;
        private int cantidadInodoros;
        private double litrosExpulsados;
        private int cantidadLavamanos;
        private double tiempoExpulsion;

        public Formulario()
        {
        }

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

        public string guardar(string edificio, string genero, int inodoros, double litros, int lavamanos, double tiempo)
        {

            string msj = "Se ha guardado con éxito.";
            //StreamWriter escribir = new StreamWriter(@"C:\Users\usuario\Documents\Universidad\Proyecto Integrador\Formulario_G1\formulario.txt", true);
            StreamWriter escribir = new StreamWriter(@"C:\Users\junior\Documents\ProyectoIntegrador\Formulario_G1\formulario.txt", true);

            try
            {
                escribir.WriteLine("Edificio: " + edificio);
                escribir.WriteLine("Baño de: " + genero);
                escribir.WriteLine("Cantidad de inodoros: " + inodoros);
                escribir.WriteLine("Litros expulsados: " + litros);
                escribir.WriteLine("Cantidad de lavamanos: " + lavamanos);
                escribir.WriteLine("Tiempo promedio de expulsión de agua: " + tiempo);
                escribir.WriteLine("\n");

            }
            catch
            {
                msj = "Error. No se pudo registrar.";
            }

            escribir.Close();
            return msj;
        }

        //metodo para leer
        public string leer()
        {
            StreamReader leer = new StreamReader(@"C:\Users\junior\Documents\ProyectoIntegrador\Formulario_G1\formulario.txt");
            String texto = "";
            String linea;

            try
            {
                linea = leer.ReadLine();

                while (linea != null)
                {
                    texto += (linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                texto = "Error";
            }
            
            leer.Close();
            return texto;
        }



    }
}

