using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheReport
{
    class Company : ReadFile
    {
        public Dictionary<String, Driver> drivers = new Dictionary<String, Driver>();
        public Dictionary<String, Driver> LazyDrivers = new Dictionary<String, Driver>();
        public void AddDrivers()
        {
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                if (String.IsNullOrWhiteSpace(words[0]) || words[0].Equals("-"))
                {
                    continue;
                }
                Driver driver = new Driver();
                driver.name = words[0];
                if (words.Length > 1)
                {
                    driver.distance = Decimal.Parse(words[2]);
                    driver.hours = Decimal.Parse(words[3]);
                    driver.speed = driver.distance / driver.hours;
                     if (drivers.ContainsKey(driver.name))
                      {
                         drivers[driver.name].distance += driver.distance;
                         drivers[driver.name].hours += driver.hours;
                         drivers[driver.name].speed = drivers[driver.name].distance / drivers[driver.name].hours;   
                      }
                     else
                      {
                         drivers.Add(driver.name, driver);
                      }
                 }
                 else
                 {
                     if (!drivers.ContainsKey(driver.name))
                     {
                         LazyDrivers.Add(driver.name, driver);
                     }
                 }
            }
        }
    }
}
