using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheReport
{
    class Program
    {
        static void Main(string[] args)
        { 
            WriteFile writeFile = new WriteFile();
            writeFile.Write();
        }
    }
}
