using System;
using drive_truck_web.Models;
using System.ComponentModel.DataAnnotations;

namespace drive_truck_web.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string number_cpf { get; set; }
        public string number_rg { get; set; }
        public string number_pis { get; set; }
        public string number_driver_license { get; set; }
        public DateTime date_expire_driver_license { get; set; }
        public string address { get; set; }
        public int number { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string phone_emergency { get; set; }
        public string email { get; set; }
        public Garage Garage {get ; set; }
        public Client Client {get ; set; }

    }
}