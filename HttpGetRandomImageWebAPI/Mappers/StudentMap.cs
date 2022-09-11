using CsvHelper.Configuration;

namespace HttpGetRandomImageWebAPI.Mappers
{
    public sealed class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {
            Map(x => x.RollNo).Name("RollNo");
            Map(x => x.Name).Name("Name");
            Map(x => x.Course).Name("Course");
            Map(x => x.Fees).Name("Fees");
            Map(x => x.Mobile).Name("Mobile");
            Map(x => x.City).Name("City");
        }
    }
}
