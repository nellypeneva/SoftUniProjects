namespace _02_VehicleCatalogue
{
    public class Vehicle
    {
        public Vehicle(string model, string type, string color, int horsepower)
        {
            this.Model = model;
            this.Type = type;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Model { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; } 
    }
}
