using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models
{
    public class Employee
    {
        public int EmployeeId
        {
            get; set;
        }
        public string Name
        {
            get;set;
        }
        public string Gendar
        {
            set;get;
        }
        public string City
        {
            get;set;
        }
    }
}