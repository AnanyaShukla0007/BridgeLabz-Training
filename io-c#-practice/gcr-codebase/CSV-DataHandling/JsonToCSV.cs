using System;
using System.IO;

class Program
{
    static void Main()
    {
        // STEP 1: Create JSON file manually
        StreamWriter jsonWriter = new StreamWriter("students.json");

        jsonWriter.WriteLine("[");
        jsonWriter.WriteLine("{\"ID\":1,\"Name\":\"Amit\",\"Age\":20},");
        jsonWriter.WriteLine("{\"ID\":2,\"Name\":\"Riya\",\"Age\":21},");
        jsonWriter.WriteLine("{\"ID\":3,\"Name\":\"Neha\",\"Age\":22}");
        jsonWriter.WriteLine("]");

        jsonWriter.Close();
        Console.WriteLine("students.json created");

        // STEP 2: JSON -> CSV (manual reading)
        StreamReader jsonReader = new StreamReader("students.json");
        StreamWriter csvWriter = new StreamWriter("students.csv");

        csvWriter.WriteLine("ID,Name,Age");

        string line;
        while ((line = jsonReader.ReadLine()) != null)
        {
            if (line.Contains("ID"))
            {
                line = line.Replace("{", "")
                           .Replace("}", "")
                           .Replace("\"", "")
                           .Replace(",", " ")
                           .Replace(":", " ");

                string[] data = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                csvWriter.WriteLine(data[1] + "," + data[3] + "," + data[5]);
            }
        }

        jsonReader.Close();
        csvWriter.Close();
        Console.WriteLine("JSON converted to CSV");

        // STEP 3: CSV -> JSON
        StreamReader csvReader = new StreamReader("students.csv");
        StreamWriter jsonWriter2 = new StreamWriter("students_from_csv.json");

        csvReader.ReadLine(); // skip header
        jsonWriter2.WriteLine("[");

        bool first = true;
        while ((line = csvReader.ReadLine()) != null)
        {
            string[] parts = line.Split(',');

            if (!first)
            {
                jsonWriter2.WriteLine(",");
            }

            jsonWriter2.Write("{\"ID\":" + parts[0] +
                              ",\"Name\":\"" + parts[1] +
                              "\",\"Age\":" + parts[2] + "}");

            first = false;
        }

        jsonWriter2.WriteLine();
        jsonWriter2.WriteLine("]");

        csvReader.Close();
        jsonWriter2.Close();

        Console.WriteLine("CSV converted back to JSON");
    }
}
