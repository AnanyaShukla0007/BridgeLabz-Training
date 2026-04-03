using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using AddressBookSystem.Models;

namespace AddressBookSystem.IO
{
    // UC-14: JSON Service
    public class JsonService
    {
        public static void WriteJson(string path, List<ContactPerson> contacts)
        {
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
