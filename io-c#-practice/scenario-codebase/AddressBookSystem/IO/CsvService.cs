using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using AddressBookSystem.Models;

namespace AddressBookSystem.IO
{
    // UC-13: CSV Service using CsvHelper
    public class CsvService
    {
        public static void WriteCsv(string path, List<ContactPerson> contacts)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(contacts);
            }
        }
    }
}
