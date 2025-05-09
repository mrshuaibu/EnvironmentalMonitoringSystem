using EnvironmentalMonitoringSystem;

namespace EnvironmentalMonitoringSystemTest
{
    public class SensorDataTest
    {
        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenTemperatureIsWithinThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.Temperature = 1;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Temperature out of range: 1°C", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenHumidityIsWithinThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.Humidity = 50;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Humidity out of range: 50%", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenSoilMoistureIsWithinThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.SoilMoisture = 50;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Soil Moisture out of range: 50%", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenLightIntensityIsWithinThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.LightIntensity = 500;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Light Intensity out of range: 50 lux", result);
        }

        [Fact] 
        public void CheckAlerts_ShouldTrigger_WhenTemperatureExceedsThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.Temperature = 100;

            string result = sensor.CheckAlerts();

            Assert.Contains("[WARNING] Temperature out of range: 100°C", result);
        }

        [Fact]
        public void CheckAlerts_ShouldTrigger_WhenTemperatureGoesBelowThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.Temperature = -300;

            string result = sensor.CheckAlerts();

            Assert.Contains("[WARNING] Temperature out of range: -300°C", result);
        }

        [Fact]
        public void CheckAlerts_ShouldTrigger_WhenHumidityExceedsThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.Humidity = 105;

            string result = sensor.CheckAlerts();

            Assert.Contains("[WARNING] Humidity out of range: 105%", result);
        }

        [Fact]
        public void CheckAlerts_ShouldTrigger_WhenHumidityGoesBelowThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.Humidity = 5;

            string result = sensor.CheckAlerts();

            Assert.Contains("[WARNING] Humidity out of range: 5%", result);
        }

        [Fact]
        public void CheckAlerts_ShouldTrigger_WhenSoilMoistureExceedsThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.SoilMoisture = 80;

            string result = sensor.CheckAlerts();

            Assert.Contains("[WARNING] Soil Moisture out of range: 80%", result);
        }

        [Fact]
        public void CheckAlerts_ShouldTrigger_WhenSoilMoistureGoesBelowThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.SoilMoisture = 1;

            string result = sensor.CheckAlerts();

            Assert.Contains("[WARNING] Soil Moisture out of range: 1%", result);
        }


        [Fact]
        public void CheckAlerts_ShouldTrigger_WhenLightIntensityExceedsThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.LightIntensity = 2000;

            string result = sensor.CheckAlerts();

            Assert.Contains("[WARNING] Light Intensity out of range: 2000 lux", result);
        }

        [Fact]
        public void CheckAlerts_ShouldTrigger_WhenLightIntensityGoesBelowThreshold()
        {
            SensorData sensor = new SensorData();

            sensor.LightIntensity = 50;

            string result = sensor.CheckAlerts();

            Assert.Contains("[WARNING] Light Intensity out of range: 50 lux", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenTemperatureIsWithinThreshold_ButAtTheLowerEdge()
        {
            SensorData sensor = new SensorData();

            sensor.Temperature = -10;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Temperature out of range: -10°C", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenHumidityIsWithinThreshold_ButAtTheLowerEdge()
        {
            SensorData sensor = new SensorData();

            sensor.Humidity = 20;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Humidity out of range: 20%", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenSoilMoistureIsWithinThreshold_ButAtTheLowerEdge()
        {
            SensorData sensor = new SensorData();

            sensor.SoilMoisture = 5;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Soil Moisture out of range: 5%", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenLightIntensityIsWithinThreshold_ButAtTheLowerEdge()
        {
            SensorData sensor = new SensorData();

            sensor.LightIntensity = 100;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Light Intensity out of range: 100 lux", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenTemperatureIsWithinThreshold_ButAtTheHigherEdge()
        {
            SensorData sensor = new SensorData();

            sensor.Temperature = 45;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Temperature out of range: 45°C", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenHumidityIsWithinThreshold_ButAtTheHigherEdge()
        {
            SensorData sensor = new SensorData();

            sensor.Humidity = 90;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Humidity out of range: 90%", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenSoilMoistureIsWithinThreshold_ButAtTheHigherEdge()
        {
            SensorData sensor = new SensorData();

            sensor.SoilMoisture = 70;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Soil Moisture out of range: 70%", result);
        }

        [Fact]
        public void CheckAlerts_ShouldNotTrigger_WhenLightIntensityIsWithinThreshold_ButAtTheHigherEdge()
        {
            SensorData sensor = new SensorData();

            sensor.LightIntensity = 1200;

            string result = sensor.CheckAlerts();

            Assert.DoesNotContain("[WARNING] Light Intensity out of range: 1200 lux", result);
        }

        [Fact]
        public void CheckAlerts_ShouldTrigger_WhenAllValuesAreExtremelyOutOfRange()
        {
            SensorData sensor = new SensorData();

            sensor.Temperature = -100;  
            sensor.Humidity = 200;      
            sensor.SoilMoisture = -10;  
            sensor.LightIntensity = 10000; 

            string result = sensor.CheckAlerts();

            Assert.Contains("[WARNING] Temperature out of range: -100°C", result);
            Assert.Contains("[WARNING] Humidity out of range: 200%", result);
            Assert.Contains("[WARNING] Soil Moisture out of range: -10%", result);
            Assert.Contains("[WARNING] Light Intensity out of range: 10000 lux", result);
        }
    }
}