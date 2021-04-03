using System;
using DriveTruck.Models;
using System.ComponentModel.DataAnnotations;

namespace DriveTruck.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NumberCpf { get; set; }
        public string NumberRg { get; set; }
        public string NumberPis { get; set; }
        public string NumberDriverLicense { get; set; }
        public DateTime DateExpireDriverLicense { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string PhoneEmergency { get; set; }
        public string Email { get; set; }
        public Garage Garage {get ; set; }
        public Client Client {get ; set; }

    }
}