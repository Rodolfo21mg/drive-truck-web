using System;
using drive_truck_web.Models;

namespace drive_truck_web.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string car_license_plate { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public string year_factory { get; set; }
        public string year_model { get; set; }
        public Garage Garage {get ; set; }
        public Client Client {get ; set; }

    }
}