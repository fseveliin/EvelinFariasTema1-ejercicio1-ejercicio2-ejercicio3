using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                Console.Write("Ingrese la base del paralelogramo: ");
                double baseParalelogramo = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la altura del paralelogramo: ");
                double alturaParalelogramo = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el lado del paralelogramo: ");
                double ladoParalelogramo = double.Parse(Console.ReadLine());

                
                if (baseParalelogramo <= 0 || alturaParalelogramo <= 0 || ladoParalelogramo <= 0)
                {
                    Console.WriteLine("Error: Los valores de la base, altura y lado deben ser mayores que 0.");
                    return;
                }

               
                double perimetro = 2 * (baseParalelogramo + ladoParalelogramo);

                
                double superficie = baseParalelogramo * alturaParalelogramo;

                
                Console.WriteLine("Datos del Paralelogramo:");
                Console.WriteLine($"Base: {baseParalelogramo}");
                Console.WriteLine($"Altura: {alturaParalelogramo}");
                Console.WriteLine($"Lado: {ladoParalelogramo}");
                Console.WriteLine($"Perímetro: {perimetro} (Perímetro = 2 * (Base + Lado))");
                Console.WriteLine($"Superficie: {superficie} (Superficie = Base * Altura)");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese valores numéricos válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }
    }
}



