using System;

namespace NamingRulesDemo
{
    // ✅ PascalCase for class names
    public class CarDetails
    {
        // ✅ PascalCase for public properties
        public string Brand { get; set; }
        public string Model { get; set; }

        // ✅ camelCase for private fields (with underscore prefix)
        private int _speed;
        private string _color;

        // ✅ ALL_CAPS for constants
        public const int MAX_SPEED = 200;
        public const float PI = 3.14159265358979323846f;

        // ✅ PascalCase for static readonly fields
        public static readonly string Manufacturer = "Tesla";

        // ✅ Constructor uses PascalCase
        public CarDetails(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            _color = color;
            _speed = 0; // ✅ camelCase for local variables
        }

        // ✅ PascalCase for methods
        public void StartEngine()
        {
            Console.WriteLine($"{Brand} {Model} engine started.");
        }

        // ✅ Event naming convention (verb + past tense)
        public event EventHandler OnEngineStopped;
        public event EventHandler OnEngineStarted;

        public void StopEngine()
        {
            Console.WriteLine($"{Brand} {Model} engine stopped.");
            OnEngineStopped?.Invoke(this, EventArgs.Empty);
        }

        // ✅ Method parameters in camelCase
        public void PaintCar(string newColor)
        {
            _color = newColor;
            Console.WriteLine($"Car painted {_color}");
        }

        // ✅ Interface naming starts with 'I'
        public interface IVehicle
        {
            void StartEngine();
            void StopEngine();
        }
    }

    // ✅ PascalCase for derived class
    public class ElectricCar : CarDetails
    {
        public ElectricCar(string brand, string model, string color)
            : base(brand, model, color) { }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery charging...");
        }
    }
}
