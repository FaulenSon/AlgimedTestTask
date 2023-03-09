using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace Algimed
{
    class Data
    {
        [Index(0)] //нулевой столбик - А
        public string CellA { get; set; }
        [Index(5)] //пятый столбик - F
        public double CellF { get; set; }
        public static List<Data> LoadFile(String fileName)
        {
            List<Data> items = new List<Data>();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                HasHeaderRecord = false,
            };
            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, config))
            {
                while (csv.Read())
                {
                    var data = new Data()
                    {
                        CellA = csv.GetField<string>(0),
                        CellF = csv.GetField<double>(5),
                    };

                    switch (data.CellA) //выборка определенных данных
                    {
                        case "C01":
                            items.Add(data);
                            break;
                        case "D01":
                            items.Add(data);
                            break;
                        case "F01":
                            items.Add(data);
                            break;
                        case "E01":
                            items.Add(data);
                            break;
                        case "G01":
                            items.Add(data);
                            break;
                        case "H01":
                            items.Add(data);
                            break;
                    }
                }
            }

            //меня местами значения F01 и E01, не знаю важно это или нет, но так указано в скриншоте
            var b = items[2];
            items[2] = items[3];
            items[3] = b;
            return items;
        }
    }
}
