using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea2 //Hecha por Jonathan Muñoz Lopez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar datos al usuario y leerlos
            Console.WriteLine("Ingrese número de cédula del empleado:");
            string cedula = Console.ReadLine();

            Console.WriteLine("Ingrese nombre del empleado:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese tipo de empleado (1-Operario, 2-Técnico, 3-Profesional):");
            int tipoEmpleado = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad de horas laboradas:");
            double horasLaboradas = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese precio por hora:");
            double precioPorHora = double.Parse(Console.ReadLine());

            // Calcular salario ordinario
            double salarioOrdinario = horasLaboradas * precioPorHora;

            // Calcular aumento salarial dependiendo del tipo de empleado
            double aumento = 0.0;

            switch (tipoEmpleado)
            {
                case 1: // Operario
                    aumento = salarioOrdinario * 0.15;
                    break;
                case 2: // Técnico
                    aumento = salarioOrdinario * 0.10;
                    break;
                case 3: // Profesional
                    aumento = salarioOrdinario * 0.05;
                    break;
                default:
                    Console.WriteLine("Tipo de empleado no válido.");
                    break; // Salir del programa si el tipo de empleado no es válido
            }

            // Calcular salario bruto
            double salarioBruto = salarioOrdinario + aumento;

            // Calcular deducción CCSS (9.17%)
            double deduccionCCSS = salarioBruto * 0.0917;

            // Calcular salario neto
            double salarioNeto = salarioBruto - deduccionCCSS;

            // Mostrar resultados
            Console.WriteLine(""); //Dejar un espacio para que no se vea pegado
            Console.WriteLine("Cedula: " + cedula);
            Console.WriteLine("Nombre Empleado: " + nombre);
            Console.WriteLine("Tipo Empleado: " + tipoEmpleado);
            Console.WriteLine("Salario por Hora: " + precioPorHora);
            Console.WriteLine("Cantidad de Horas: " + horasLaboradas);
            Console.WriteLine("Salario Ordinario: " + salarioOrdinario + " colones");
            Console.WriteLine("Aumento: " + aumento + " colones");
            Console.WriteLine("Salario Bruto: " + salarioBruto + " colones");
            Console.WriteLine("Deducción CCSS: " + deduccionCCSS + " colones");
            Console.WriteLine("Salario Neto: " + salarioNeto + " colones");

            //Importante siempre esperar la entrada de datos para que no se cierre el programa
            Console.ReadLine();
        }
    }
}
