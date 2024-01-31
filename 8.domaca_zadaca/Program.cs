using System;
using System.Collections.Generic;

namespace MementoZadatak
{
    public class CarConfigurator
    {
        private string Model { get; set; }
        private List<Equipment> additionalEquipment = new List<Equipment>();

        public void AddExtra(Equipment package)
        {
            additionalEquipment.Add(package);
        }
        public void Remove(Equipment package)
        {
            additionalEquipment.Remove(package);
        }
        public Memento Store()
        {
            return new Memento(Model, new List<Equipment>(additionalEquipment));
        }
        public void Rollback(Memento memento)
        {
            Model = memento.GetModel();
            additionalEquipment = new List<Equipment>(memento.GetPackages());
        }
        public void DisplayConfiguration()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine("Additional Equipment:");
            foreach (var equipment in additionalEquipment)
            {
                Console.WriteLine($"- {equipment}");
            }
        }
    }

    public class Memento
    {
        private readonly string model;
        private readonly List<Equipment> additionalEquipment;
        public Memento(string model, List<Equipment> additionalEquipment)
        {
            this.model = model;
            this.additionalEquipment = additionalEquipment;
        }
        public string GetModel()
        {
            return model;
        }
        public List<Equipment> GetPackages()
        {
            return additionalEquipment;
        }
    }

    public class Equipment
    {
        public string Name { get; set; }
        public Equipment(string name)
        {
            Name = name;
        }
    }

    public class ConfigurationManager
    {
        private List<Memento> configurations = new List<Memento>();
        public void AddConfiguration(Memento configuration)
        {
            configurations.Add(configuration);
        }
        public void DeleteConfiguration(Memento configuration)
        {
            configurations.Remove(configuration);
        }

        public Memento GetConfiguration(int index)
        {
            return configurations[index];
        }
    }

    class Program
    {
        static void Main()
        {
            var configurator = new CarConfigurator();
            configurator.AddExtra(new Equipment("Leather Seats"));
            configurator.AddExtra(new Equipment("Sunroof"));
            var initialConfig = configurator.Store();
            configurator.AddExtra(new Equipment("Advanced Stereo"));
            var modifiedConfig = configurator.Store();
            configurator.Rollback(initialConfig);
            configurator.DisplayConfiguration();
        }
    }
}
