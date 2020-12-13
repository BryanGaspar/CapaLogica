using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();

            string nombre, fecha;
            double x;
            int numeroMes;

            Console.WriteLine("PRACTICA REALIZADA EN CONSOLA (CAPA LOGICA)");

            Console.Write("Fecha: ");
            fecha = Console.ReadLine();

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Saldo Inicial: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el numero del mes: ");
            numeroMes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(conta.Saludos(nombre));
            Console.WriteLine("Sueldo: {0}", conta.getSaldos(x));
            Console.WriteLine("el estado de su Fecha es : {0}", CapaLogica.Utilidades.validarFecha(fecha));
            Console.WriteLine("Mes ingresado: {0}", CapaLogica.Utilidades.getNombreDelMes(numeroMes));
            Console.ReadKey();

        }
    }
}
