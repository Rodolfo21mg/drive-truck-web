using System;
using DriveTruck.Models;

namespace DriveTruck.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CarLicensePlate { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string YearFactory { get; set; }
        public string YearModel { get; set; }
        public Garage Garage {get ; set; }
        public Client Client {get ; set; }

    }
}