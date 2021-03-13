using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace main01
{

    public class RootObject
    {
        public List<records> records { get; set; }
    }
    public class records
    {
        public string SiteName { get; set; }
        public string AQI { get; set; }
        public string Status { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!_1106105227");

            string jsonFilePath = @"D:\109-1_nkust\0311_1\main01\testjson.json";
            Console.WriteLine(jsonFilePath);
            string jsonText = File.ReadAllText(jsonFilePath);

            RootObject rd = JsonConvert.DeserializeObject<RootObject>(jsonText);
            int a = 0, b = 0, c = 0, d = 0;
            Console.WriteLine("\n..縣市\t>>狀態\n");
            for (int i = 0; i < rd.records.Count; i++)
            {
                if (Convert.ToInt32(rd.records[i].AQI) < 51)
                {
                    a += 1;
                    Console.WriteLine((a).ToString() + "." + rd.records[i].SiteName + "\t>>" + rd.records[i].Status);
                }
            }

            Console.WriteLine("共" + a + "個縣市\n");
            for (int i = 0; i < rd.records.Count; i++)
            {
                if (Convert.ToInt32(rd.records[i].AQI) > 50 && Convert.ToInt32(rd.records[i].AQI) < 101)
                {
                    b += 1;
                    Console.WriteLine((b).ToString() + "." + rd.records[i].SiteName + "\t>>" + rd.records[i].Status);
                }
            }
            Console.WriteLine("共" + b + "個縣市\n");
            for (int i = 0; i < rd.records.Count; i++)
            {
                if (Convert.ToInt32(rd.records[i].AQI) > 100 && Convert.ToInt32(rd.records[i].AQI) < 151)
                {
                    c += 1;
                    Console.WriteLine((c).ToString() + "." + rd.records[i].SiteName + "\t>>" + rd.records[i].Status);
                }
            }
            Console.WriteLine("共" + c + "個縣市\n");
            for (int i = 0; i < rd.records.Count; i++)
            {
                if (Convert.ToInt32(rd.records[i].AQI) > 150)
                {
                    d += 1;
                    Console.WriteLine((d).ToString() + "." + rd.records[i].SiteName + "\t>>" + rd.records[i].Status);
                }
            }
            Console.WriteLine("共" + d + "個縣市");
        }
    }
}
