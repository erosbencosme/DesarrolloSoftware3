using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDesarrollo_Infidelidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
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
                infidelidades.SexoAfectado = char.Parse(Console.ReadLine());

                Console.WriteLine("Sexo del infiel: ");
                infidelidades.SexoInfiel = char.Parse(Console.ReadLine());

                Console.WriteLine("Fecha del evento: ");
                infidelidades.FechaEvento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Fecha del ingreso: ");
                infidelidades.FechaIngreso = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Estado de la pareja: ");
                infidelidades.EstadoPareja = Console.ReadLine();

                Console.WriteLine("Cantidad de veces que les fue infiel: ");
                infidelidades.PrimeraVez = int.Parse(Console.ReadLine());


                // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\Eros Bencosme\source\repos\LabDesarrollo3_\LabDesarrollo_Infidelidades\InfidelidadesDB.mdf";Integrated Security=True
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Eros Bencosme\\source\\repos\\LabDesarrollo3_\\LabDesarrollo_Infidelidades\\InfidelidadesDB.mdf\";Integrated Security=True");
                connection.Open();
                Console.WriteLine(connection.State);
                SqlCommand command = new SqlCommand("insert into tblInfidelidades (NombreAfectado, ApellidosAfectado, NombreInfiel, ApellidoInfiel, SexoAfectado, SexoInfiel, FechaEvento, FechaIngreso, EstadoPareja, PrimeraVez) values(@NombreAfectado, @ApellidosAfectado, @NombreInfiel, @ApellidoInfiel, @SexoAfectado, @SexoInfiel, @FechaEvento, @FechaIngreso, @EstadoPareja, @PrimeraVez)", connection);

                command.Parameters.AddWithValue("@NombreAfectado", infidelidades.NombreAfectado);
                command.Parameters.AddWithValue("@ApellidosAfectado", infidelidades.ApellidosAfectado);
                command.Parameters.AddWithValue("@NombreInfiel", infidelidades.NombreInfiel);
                command.Parameters.AddWithValue("@ApellidoInfiel", infidelidades.ApellidoInfiel);
                command.Parameters.AddWithValue("@SexoAfectado", infidelidades.SexoAfectado);
                command.Parameters.AddWithValue("@SexoInfiel", infidelidades.SexoInfiel);
                command.Parameters.AddWithValue("@FechaEvento", infidelidades.FechaEvento);
                command.Parameters.AddWithValue("@FechaIngreso", infidelidades.FechaIngreso);
                command.Parameters.AddWithValue("@EstadoPareja", infidelidades.EstadoPareja);
                command.Parameters.AddWithValue("@PrimeraVez", infidelidades.PrimeraVez);
                command.ExecuteNonQuery();
            }
            
        }
    }
}
