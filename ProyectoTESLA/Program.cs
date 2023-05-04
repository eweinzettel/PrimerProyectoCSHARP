using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTESLA
{
    internal class Program
    { 
        struct InformacionTesla 
        {
            public string modelo;
            public int año;
            public int kmActual;
            public int kmService;
            public string color;
            public string dueño;            
            
            // Constructor de la estructura que recibe los parametros
            public InformacionTesla(string modelo, int año, int kmActual, int kmService, string color, string dueño)
            {
                this.modelo = modelo;
                this.año = año;
                this.kmActual = kmActual;
                this.kmService = kmService;
                this.color = color;
                this.dueño = dueño;
            }

        }


        static void Main(string[] args)
        {

            string modeloAuto;
            int añoFabricacion;
            int kmActual;
            int kmService;
            string color;
            string dueño;

            
            Console.WriteLine("ingrese informacion del auto");
            Console.WriteLine("ingrese modelo");
            modeloAuto = Console.ReadLine();

            Console.WriteLine("ingrese año fabricacion");
            añoFabricacion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese Km Actual");
            kmActual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese Km service");
            kmService = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese Color");
            color = Console.ReadLine();

            Console.WriteLine("ingrese dueño");
            dueño = Console.ReadLine();

            InformacionTesla vehiculo = new InformacionTesla(modeloAuto,añoFabricacion,kmActual,kmService,color,dueño );




            //Dictionary<string, int> serviceAuto = new Dictionary<string, int>();

            //serviceAuto.Add("1service", 15000);
            //serviceAuto.Add("2service", 30000);
            //serviceAuto.Add("3service", 45000);
            //serviceAuto.Add("4service", 60000);
            //serviceAuto.Add("5service", 75000);
            //serviceAuto.Add("6service", 100000);
            //serviceAuto.Add("7service", 115000);
            //serviceAuto.Add("8service", 130000);


            //if (serviceAuto["1service"] == vehiculo.kmActual) 
            //{
            //    Console.WriteLine("service");            
            //}

            if (vehiculo.kmActual >= vehiculo.kmService)
            {
                Console.WriteLine("service");
            }

            else 
            {
                Console.WriteLine("Todavia falta");
            }

            Console.WriteLine("AUTO Modelo {0}: Año fabricacion {1}: Km Actuales {2}: Km service {3}: Color {4}: Actual Dueño {5}", vehiculo.modelo,vehiculo.año,vehiculo.kmActual,vehiculo.kmService,vehiculo.color,vehiculo.dueño);
            Console.ReadLine();
        }
    }
}
