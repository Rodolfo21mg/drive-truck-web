using System;

namespace DriveTruck.Models
{
    public class Garage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string LandlinePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Neighborhood { get; set; }
        public string Number { get; set; }
        public Client Client {get ; set; }

    }
}