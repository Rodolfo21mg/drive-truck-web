using System;

namespace DriveTruck.Models
{
    public class Garage
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string country { get; set; }
        public string landline_phone { get; set; }
        public string mobile_phone { get; set; }
        public string neighborhood { get; set; }
        public string number { get; set; }
        public Client Client {get ; set; }

    }
}