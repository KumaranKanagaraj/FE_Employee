using Newtonsoft.Json;
using ProblemOne.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace ProblemOne.Service
{
    public class Save<T> where T : class, IEntity
    {
        string _outputPath;
        Format _format;
        List<T> _employee;
        public Save(List<T> employee, Format format)
        {
            this._employee = employee;
            this._format = format;
            this._outputPath = Path.Combine(Assembly.GetExecutingAssembly().Location, "..", "..", "..", "..", "output");
        }

        public string SaveAs()
        {
            var filePath = "";
            switch (_format)
            {
                case Format.xml:
                    filePath = SaveToXml(_employee);
                    break;
                case Format.json:
                    filePath = SaveToJson(_employee);
                    break;
                case Format.csv:
                    filePath = SaveToCsv(_employee);
                    break;
                default:
                    filePath = SaveToJson(_employee);
                    break;
            }
            return filePath;
        }

        private string SaveToXml(List<T> employee)
        {
            var filePath = Path.Combine(_outputPath, Guid.NewGuid() + ".xml");
            using (StreamWriter myWriter = new StreamWriter(filePath, false))
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(List<T>));
                mySerializer.Serialize(myWriter, employee);
            }
            return filePath;
        }

        private string SaveToJson(List<T> employee)
        {
            var filePath = Path.Combine(_outputPath, Guid.NewGuid() + ".json");
            File.WriteAllText(filePath, JsonConvert.SerializeObject(employee));
            return filePath;
        }

        private string SaveToCsv(List<T> employee)
        {
            var filePath = Path.Combine(_outputPath, Guid.NewGuid() + ".csv");
            using (TextWriter tw = File.CreateText(filePath))
            {
                foreach (var line in ToCsv(employee))
                {
                    tw.WriteLine(line);
                }
            }
            return filePath;
        }

        public static IEnumerable<string>ToCsv(IEnumerable<T> objectlist, string separator = ",", bool header = true)
        {
            FieldInfo[] fields = typeof(T).GetFields();
            PropertyInfo[] properties = typeof(T).GetProperties();
            if (header)
            {
                yield return String.Join(separator, fields.Select(f => f.Name).Concat(properties.Select(p => p.Name)).ToArray());
            }
            foreach (var o in objectlist)
            {
                yield return string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray());
            }
        }
    }
}
