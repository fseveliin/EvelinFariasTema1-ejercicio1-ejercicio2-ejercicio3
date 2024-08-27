using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio2 
{
    struct Paralelogramo
    {
        public double Base;
        public double Altura;
        public double Lado;

        public Paralelogramo(double baseParalelogramo, double alturaParalelogramo, double ladoParalelogramo)
        {
            Base = baseParalelogramo;
            Altura = alturaParalelogramo;
            Lado = ladoParalelogramo;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Base + Lado);
        }

        public double CalcularSuperficie()
        {
            return Base * Altura;
        }

        public bool ValoresValidos()
        {
            return Base > 0 && Altura > 0 && Lado > 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Paralelogramo paralelogramoMayorPerimetro;
            double mayorPerimetro = double.MinValue;
            int iteracionMayorPerimetro = -1;
            double sumaSuperficies = 0;
            int cantidadParalelogramos = 0;

            while (true)
            {
                Console.WriteLine("Ingrese la base del paralelogramo:");
                double baseParalelogramo = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la altura del paralelogramo:");
                double alturaParalelogramo = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el lado del paralelogramo:");
                double ladoParalelogramo = double.Parse(Console.ReadLine());

                Paralelogramo paralelogramo = new Paralelogramo(baseParalelogramo, alturaParalelogramo, ladoParalelogramo);

                if (!paralelogramo.ValoresValidos())
                {
                    Console.WriteLine("Los valores ingresados no son válidos. Intente nuevamente.");
                    continue;
                }

                double perimetro = paralelogramo.CalcularPerimetro();
                double superficie = paralelogramo.CalcularSuperficie();

                Console.WriteLine($"Perímetro: {perimetro}");
                Console.WriteLine($"Superficie: {superficie}");

                if (perimetro > mayorPerimetro)
                {
                    mayorPerimetro = perimetro;
                    paralelogramoMayorPerimetro = paralelogramo;
                    iteracionMayorPerimetro = cantidadParalelogramos + 1;
                }

                sumaSuperficies += superficie;
                cantidadParalelogramos++;

                Console.WriteLine("¿Desea agregar un nuevo paralelogramo? (si/no)");
                string respuesta = Console.ReadLine();

                if (respuesta != "si")
                {
                    break;
                }
            }

            if (cantidadParalelogramos > 0)
            {
                Console.WriteLine($"El paralelogramo con mayor perímetro fue ingresado en la iteración {iteracionMayorPerimetro}.");
                Console.WriteLine($"El promedio de las superficies es {sumaSuperficies / cantidadParalelogramos}");
            }
            else
            {
                Console.WriteLine("No se ingresaron paralelogramos válidos.");
            }
        }
    }
}

