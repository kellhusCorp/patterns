using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//single responsibility principle
namespace SRP
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        public void AddEntry(string text)
        {
            entries.Add(text);
        }

        public void RemoveEntry(int index)
        {
            if (index < entries.Count && index > 0)
                entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        //bad example
        public void Save(string filename, bool overwrite = false)
        {
            File.WriteAllText(filename, ToString());
        }

        ///bad example
        public void Load(string filename) { }

        //bad example
        public void Load(Uri uri) { }
    }

    //good practice
    public class PersistenceManager
    {
        private void verify(string filename)
        {

        }

        public void Save(Journal journal, string filename, bool overwrite = false)
        {
            verify(filename);
            File.WriteAllText(filename, journal.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("test");
            j.AddEntry("test 1");
            Console.WriteLine(j);

            var p = new PersistenceManager();
            var filename = @"c:\users\XXX\desktop\example.txt";
            p.Save(j, filename, true);
        }
    }
}
