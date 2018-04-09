using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheReport
{
    class WriteFile 
    {
        public StringBuilder builder = new StringBuilder();
        Driver driver = new Driver();
        Company company = new Company();
        public void Write()
        {
            company.AddDrivers();
            var builder = new StringBuilder();
            foreach (var driver in company.drivers)
            { 
                    builder.AppendFormat("{0} {1}", driver.Value.name, Convert.ToString(Convert.ToInt32(driver.Value.speed)));
                    builder.AppendLine();
            }
                    builder.AppendLine();
                    builder.Append("-");
                    builder.AppendLine();
                    builder.AppendLine();
            foreach (var driver in company.LazyDrivers)
            {
                builder.AppendFormat("{0}", driver.Value.name);
                builder.AppendLine();
            }
            System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\x.txt", builder.ToString());
        }
    }
}
