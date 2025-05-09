using System.Security.Cryptography.X509Certificates;

namespace EnvironmentalMonitoringSystem
{
    public class Program
    {
        static SensorData sensor = new SensorData();

        static void Main(string[] args)
        {
            Interface();
        }

        public static void Interface()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nEnvironmental Sensor Simulation");
                sensor.DisplaySensorData();
                sensor.CheckAlerts();

                Console.WriteLine("\nSelect from the following options:");
                Console.WriteLine("1 - Generate new sensor data");
                Console.WriteLine("2 - Exit program");

                string? input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("\nNew sensor data generated.............");
                    sensor.GenerateRandomValues();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Exiting program...");
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }
}
