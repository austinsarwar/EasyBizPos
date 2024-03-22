using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBizPos.Models
{
    internal class Employee
    {
        public int Employee_ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Admin { get; set; } // Assuming 'yes' or 'no' as string values for admin


    }
}