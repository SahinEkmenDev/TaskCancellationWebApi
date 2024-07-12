using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParallelForeachApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string picturesPath = @"C:\\Users\\sahin\\Desktop";

            var files= Directory.GetFiles(picturesPath);
            Parallel.ForEach(files, (item) => 
            { 
            
           
            
            });
        }
    }
}
