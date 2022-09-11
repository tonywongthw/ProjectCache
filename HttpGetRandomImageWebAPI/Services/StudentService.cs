using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using HttpGetRandomImageWebAPI.Mappers;

namespace HttpGetRandomImageWebAPI.Services
{
    public class StudentService
    {
        public List<Student> ReadCSVFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location, Encoding.Default))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.RegisterClassMap<StudentMap>();
                    var records = csv.GetRecords<Student>().ToList();
                    return records;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void WriteCSVFile(string path, List<Student> student)
        {
            using (StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(true)))
            using (CsvWriter cw = new CsvWriter(sw))
            {
                cw.WriteHeader<Student>();
                cw.NextRecord();
                foreach (Student stu in student)
                {
                    cw.WriteRecord<Student>(stu);
                    cw.NextRecord();
                }
            }
        }
    }
}
