using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalMonitoringSystem
{
    public class SensorData
    {
        private static readonly Random random = new Random();

        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double SoilMoisture { get; set; }
        public int LightIntensity { get; set; }

        public SensorData()
        {
            GenerateRandomValues();
        }

        public void GenerateRandomValues()
        {
            Temperature = GetRandomDouble(-10, 45);
            Humidity = GetRandomDouble(20, 90);
            SoilMoisture = GetRandomDouble(5, 70);
            LightIntensity = GetRandomInt(100, 1200);
        }

        public string CheckAlerts()
        {
            StringBuilder alerts = new StringBuilder();

            if (Temperature < -10 || Temperature > 45)
                alerts.AppendLine($"[WARNING] Temperature out of range: {Temperature}°C");

            if (Humidity < 20 || Humidity > 90)
                alerts.AppendLine($"[WARNING] Humidity out of range: {Humidity}%");

            if (SoilMoisture < 5 || SoilMoisture > 70)
                alerts.AppendLine($"[WARNING] Soil Moisture out of range: {SoilMoisture}%");

            if (LightIntensity < 100 || LightIntensity > 1200)
                alerts.AppendLine($"[WARNING] Light Intensity out of range: {LightIntensity} lux");

            string result = alerts.ToString().Trim();
            Console.WriteLine(result); 
            return result; 
        }

        private static double GetRandomDouble(double min, double max)
        {
            return Math.Round(random.NextDouble() * (max - min) + min, 2); 
        }

        private static int GetRandomInt(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public void DisplaySensorData()
        {
            Console.WriteLine($"Temperature: {Temperature}°C");
            Console.WriteLine($"Humidity: {Humidity}%");
            Console.WriteLine($"Soil Moisture: {SoilMoisture}%");
            Console.WriteLine($"Light Intensity: {LightIntensity} lux");
        }
    }
}
