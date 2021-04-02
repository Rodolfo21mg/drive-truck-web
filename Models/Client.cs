using System;
using DriveTruck.Models;
using System.Collections.Generic;

namespace DriveTruck.Models
{
    public class Client
    {  
        public int Id { get; set; }
        public string registered_name { get; set; }     
        public string fantasy_name { get; set; }     
        public string employer_number { get; set; }     
        public string address { get; set; }     
        public string city { get; set; }     
        public string state { get; set; }     
        public string zip_code { get; set; }     
        public string country { get; set; } 
        public string neighborhood { get; set; }      
        public string landline_phone { get; set; }        
        public string mobile_phone { get; set; }  
        public string email { get; set; }  
        public string manager { get; set; }  
        public string contact_manager { get; set; }  
        public string email_manager { get; set; }     

    }
}