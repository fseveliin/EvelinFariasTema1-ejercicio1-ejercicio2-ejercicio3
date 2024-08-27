using Entidades;
using System;

namespace Entidades
{
    public struct Paralelogramo
    {
        public double Base { get; private set; }
        public double Altura { get; private set; }
        public double Lado { get; private set; }

        public Paralelogramo(double baseParalelogramo, double alturaParalelogramo, double ladoParalelogramo)
        {
           
            if (baseParalelogramo <= 0 || alturaParalelogramo <= 0 || ladoParalelogramo <= 0)
            {
                throw new ArgumentException("Los valores deben ser mayores que cero.");
            }

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

        public void EstablecerValores(double baseParalelogramo, double alturaParalelogramo, double ladoParalelogramo)
        {
            if (baseParalelogramo > 0) Base = baseParalelogramo;
            if (alturaParalelogramo > 0) Altura = alturaParalelogramo;
            if (ladoParalelogramo > 0) Lado = ladoParalelogramo;
        }

        public string ObtenerValores()
        {
            return $"Base: {Base}, Altura: {Altura}, Lado: {Lado}";
        }
    }
}


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Paralelogramo paralelogramo;

            Console.WriteLine("Ingrese la base del paralelogramo:");
            double baseParalelogramo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del paralelogramo:");
            double alturaParalelogramo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el lado del paralelogramo:");
            double ladoParalelogramo = Convert.ToDouble(Console.ReadLine());

            try
            {
                paralelogramo = new Paralelogramo(baseParalelogramo, alturaParalelogramo, ladoParalelogramo);

                Console.WriteLine($"Valores del paralelogramo: {paralelogramo.ObtenerValores()}");

                double perimetro = paralelogramo.CalcularPerimetro();
                double superficie = paralelogramo.CalcularSuperficie();

                Console.WriteLine($"Perímetro: {perimetro}");
                Console.WriteLine($"Superficie: {superficie}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
