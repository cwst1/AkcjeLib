using System;
using System.Collections.Generic;
using System.Linq;

namespace AkcjeLib
{
    public class VehicleBase
    {
        public string RegistrationNumber { get; set; }
    }

    public class Vehicle : VehicleBase
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public List<ServiceTask> ServiceHistory { get; set; } = new List<ServiceTask>();

        public string DisplayInfo => $"{Brand} {Model} ({RegistrationNumber}) - {Mileage} km";

        public override string ToString()
        {
            return DisplayInfo;
        }
    }

    public class ServiceTask
    {
        public string TaskName { get; set; }
        public int MileageAtService { get; set; }
        public DateTime DateOfService { get; set; }

        public override string ToString()
        {
            return $"{TaskName} - {MileageAtService} km - {DateOfService.ToShortDateString()}";
        }
    }

    public class DuplicateServiceException : Exception
    {
        public DuplicateServiceException(string message) : base(message) { }
    }

    public class ServiceManager
    {
        private readonly Dictionary<int, List<string>> serviceTasks = new Dictionary<int, List<string>>
        {
            { 5000, new List<string> { "Kontrola poziomu płynów", "Kontrola komputera", "Kontrola połączeń śrubowych" } },
            { 15000, new List<string> { "Wymiana oleju", "Kontrola hamulców", "Kontrola ogumienia" } },
            { 30000, new List<string> { "Wymiana filtra powietrza", "Kontrola zawieszenia" } },
            { 60000, new List<string> { "Wymiana rozrządu", "Kontrola układu chłodzenia", "Wymiana oleju w skrzyni biegów" } }
        };

        public delegate void ServiceDueHandler(string task, int mileage);
        public event ServiceDueHandler ServiceDue;

        public void AddService(Vehicle vehicle, ServiceTask task)
        {
            if (vehicle.ServiceHistory.Any(t => t.TaskName == task.TaskName && t.MileageAtService == task.MileageAtService))
            {
                throw new DuplicateServiceException("Ta czynność serwisowa została już wykonana.");
            }

            vehicle.ServiceHistory.Add(task);
        }

        public List<string> GetServiceTasks(int mileage)
        {
            return serviceTasks
                .Where(t => mileage >= t.Key)
                .SelectMany(t => t.Value)
                .ToList();
        }

       
    }
}
