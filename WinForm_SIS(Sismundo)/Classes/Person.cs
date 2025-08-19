using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_SIS_Sismundo_.Classes
{
    internal abstract class Person
    {
        public string PersonId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int RoleId { get; set; }



        public string DisplayInfo()
        {
            return 
                $"Name: {First_Name} {Last_Name}\n" +
                $"Address: {Address}";
        }

        //public abstract void Add();
        
    }
}
