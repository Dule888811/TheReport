using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheReport
{
    public class Driver
    {
        public String name;
        public Decimal distance;
        public Decimal hours;
        public Decimal speed;
        public List<Driver> drivers = new List<Driver>();       
        public Driver() { }
        public Driver(string name, string city, Decimal distance, Decimal hours, Decimal average, bool lazy)
        {
            this.name = name;
            this.distance = distance;
            this.hours = hours;
        }
    }
}
