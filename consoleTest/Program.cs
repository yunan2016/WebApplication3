using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}: {1}", cultureName,
                                  localDate.ToString(culture));
            }


            string yourString = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt", CultureInfo.InvariantCulture);

            string yourString1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            // to get the location the assembly is executing from
            //(not necessarily where the it normally resides on disk)
            // in the case of the using shadow copies, for instance in NUnit tests, 
            // this will be in a temp directory.
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            //To get the location the assembly normally resides on disk or the install directory
            string path2 = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;

            string path3 = Environment.CurrentDirectory;

            //once you have the path you get the directory with:
            var directory = System.IO.Path.GetDirectoryName(path);
        }
    }
}
