using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su ciudad: ");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Ingrese la distancia a la que se encuentra de la universidad en km: ");
            double distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cuanto ganan sus acudientes: ");
            double ingresos = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su estrado: ");
            int estrato = int.Parse(Console.ReadLine());

            int porcentajeDeBeca = 44;
            float salarioMinimo = 1423500;

            // sumar un 44% mas al salario minimo
            float salarioDeBeca = (float)(salarioMinimo * (porcentajeDeBeca / 100.0));
        
            // condiciones de aplicacion a la beca
            //1. Viva a más de 5 km de distancia de la Universidad.
            //2. Sus ingresos familiares sean menores $600.000
            //3. El estrato sea uno o dos.
            if (distancia > 5 && ingresos < 600000 && estrato == 1 || estrato == 2)
            {
                Console.WriteLine("Cumple con las condiciones, felicidades " + nombre + " :3" + "El salario que ganara sera: " + salarioDeBeca);
            }
            else
            {
                Console.WriteLine("No cumple con la condicion de distancia");
                return;
            }

        }
    }
}
