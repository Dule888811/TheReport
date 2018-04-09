using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheReport
{
    class ReadFile
    {
      public  string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\Izvestaj.txt");
    }
}
