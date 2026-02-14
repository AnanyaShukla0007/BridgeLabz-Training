using System.Collections.Generic;

namespace TechVille.DataStructures.Hashing
{
    public class CitizenHashMap
    {
        private Dictionary<string, string> map = new Dictionary<string, string>();

        public void Add(string key, string value) => map[key] = value;
        public string Get(string key) => map.ContainsKey(key) ? map[key] : null;
    }
}
