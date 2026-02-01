using System.Collections.Generic;
using System.IO;
using AddressBookSystem.Models;

namespace AddressBookSystem.IO
{
    // UC-12: File IO Service
    public class FileIOService
    {
        public static void WriteText(string path, List<ContactPerson> contacts)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var c in contacts)
                    sw.WriteLine(c.ToString());
            }
        }
    }
}
