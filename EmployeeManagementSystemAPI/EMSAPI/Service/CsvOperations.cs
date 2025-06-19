using Test.Model;
using CsvHelper;
using System.Globalization;


namespace Test.Service;

public class CsvOperations
{
    public List<EmployeesDto> ReadCsv(string path)
    {
       using var reader = new StreamReader(path);
       using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
       var records = csv.GetRecords<EmployeesDto>().ToList();
       return records;
    }

    public Boolean WriteCSV(string path, EmployeesDto employees)
    {
        try
        {
            using var writer = new StreamWriter(path, append: true);
            using var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvWriter.WriteRecord(employees);
            writer.WriteLine();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}