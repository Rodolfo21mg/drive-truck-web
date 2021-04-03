using System;
using DriveTruck.Models;
using System.Collections.Generic;

namespace DriveTruck.Models
{
    public class Client
    {  
        public int Id { get; set; }
        public string RegisteredName { get; set; }     
        public string FantasyName { get; set; }     
        public string EmployerNumber { get; set; }     
        public string Address { get; set; }     
        public string City { get; set; }     
        public string State { get; set; }     
        public string ZipCode { get; set; }     
        public string Country { get; set; } 
        public string Neighborhood { get; set; }      
        public string LandlinePhone { get; set; }        
        public string MobilePhone { get; set; }  
        public string Email { get; set; }  
        public string Manager { get; set; }  
        public string ContactManager { get; set; }  
        public string EmailManager { get; set; }     

    }
}