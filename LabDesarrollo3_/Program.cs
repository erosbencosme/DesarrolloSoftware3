using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDesarrollo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Infidelidades infidelidades = new Infidelidades();

            Console.WriteLine("Nombre del afectado: ");
            infidelidades.NombreAfectado = Console.ReadLine();

            Console.WriteLine("Apellido del afectado: ");
            infidelidades.ApellidosAfectado = Console.ReadLine();

            Console.WriteLine("Nombre del infiel: ");
            infidelidades.NombreInfiel = Console.ReadLine();

            Console.WriteLine("Apellido del infiel: ");
            infidelidades.ApellidoInfiel = Console.ReadLine();

            Console.WriteLine("Sexo del afectado: ");
            infidelidades.SexoAfectado = char.Parse (Console.ReadLine());

            Console.WriteLine("Sexo del infiel: ");
            infidelidades.SexoInfiel = char.Parse (Console.ReadLine());

            Console.WriteLine("Fecha del evento: ");
            infidelidades.FechaEvento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Fecha del ingreso: ");
            infidelidades.FechaIngreso = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Estado de la pareja: ");
            infidelidades.EstadoPareja = Console.ReadLine();

            Console.WriteLine("Cantidad de veces que les fue infiel: ");
            infidelidades.PrimeraVez = int.Parse(Console.ReadLine());

            SqlConnection connection  = new SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C: \Users\Eros Bencosme\source\repos\LabDesarrollo3\LabDesarrollo3\InfidelidadesDB.mdf";Integrated Security=True");
        }
    }
}
